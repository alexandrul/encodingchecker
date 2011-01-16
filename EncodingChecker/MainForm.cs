using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Ude;

namespace EncodingChecker
{
    public partial class MainForm : Form
    {
        private sealed class WorkerArgs
        {
            internal string BaseDirectory;
            internal bool IncludeSubdirectories;
            internal string FileMasks;
            internal List<string> ValidCharsets;
        }

        private sealed class WorkerProgress
        {
            internal string FileName;
            internal string DirectoryName;
            internal string Charset;
        }

        private enum ValidateButtonAction
        {
            Validate,
            Cancel,
        }

        private readonly BackgroundWorker _validationWorker;
        private Settings _settings;

        public MainForm()
        {
            InitializeComponent();

            _validationWorker = new BackgroundWorker {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            _validationWorker.DoWork += ValidationWorkerDoWork;
            _validationWorker.ProgressChanged += ValidationWorkerProgressChanged;
            _validationWorker.RunWorkerCompleted += ValidationWorkerCompleted;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            //Populate the valid charsets list
            FieldInfo[] charsetConstants =
                typeof(Charsets).GetFields(BindingFlags.GetField | BindingFlags.Static | BindingFlags.Public);
            foreach (FieldInfo charsetConstant in charsetConstants)
            {
                if (charsetConstant.FieldType != typeof(string))
                    continue;
                object value = charsetConstant.GetValue(null);
                lstValidCharsets.Items.Add(value);
            }

            //Set the initial action for the validate button
            btnValidate.Tag = ValidateButtonAction.Validate;

            LoadSettings();

            //Size the result list columns
            lstResults.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            int remainingWidth = lstResults.Width - lstResults.Columns[0].Width;
            lstResults.Columns[1].Width = (30 * remainingWidth) / 100;
            lstResults.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void OnBrowseDirectories(object sender, EventArgs e)
        {
            dlgBrowseDirectories.SelectedPath = txtBaseDirectory.Text;
            if (dlgBrowseDirectories.ShowDialog(this) == DialogResult.OK)
                txtBaseDirectory.Text = dlgBrowseDirectories.SelectedPath;
        }

        private void OnAbout(object sender, EventArgs e)
        {
            using (var aboutForm = new AboutForm())
                aboutForm.ShowDialog(this);
        }

        #region Loading and saving of settings
        private void LoadSettings()
        {
            string settingsFileName = Path.Combine(Environment.CurrentDirectory, SettingsFileName);
            if (!File.Exists(settingsFileName))
                return;
            using (var settingsFile = new FileStream(settingsFileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var formatter = new BinaryFormatter();
                object settingsInstance = formatter.Deserialize(settingsFile);
                _settings = (Settings)settingsInstance;
            }

            txtBaseDirectory.Text = _settings.BaseDirectory;
            chkIncludeSubdirectories.Checked = _settings.IncludeSubdirectories;
            txtFileMasks.Text = _settings.FileMasks;
            if (_settings.WindowPosition != null)
                _settings.WindowPosition.ApplyTo(this);
        }

        private void SaveSettings()
        {
            if (_settings == null)
                _settings = new Settings();
            _settings.BaseDirectory = txtBaseDirectory.Text;
            _settings.IncludeSubdirectories = chkIncludeSubdirectories.Checked;
            _settings.FileMasks = txtFileMasks.Text;
            _settings.WindowPosition = new WindowPosition {
                Left = Left,
                Top = Top,
                Width = Width,
                Height = Height
            };

            string settingsFileName = Path.Combine(Environment.CurrentDirectory, SettingsFileName);
            using (
                var settingsFile = new FileStream(settingsFileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(settingsFile, _settings);
                settingsFile.Flush();
            }
        }

        private const string SettingsFileName = "Settings.bin";
        #endregion

        #region Validate button handling
        private void OnValidate(object sender, EventArgs e)
        {
            var validateAction = (ValidateButtonAction)btnValidate.Tag;
            if (validateAction == ValidateButtonAction.Validate)
                StartValidation();
            else
                CancelValidation();
        }

        private void StartValidation()
        {
            string directory = txtBaseDirectory.Text;
            if (string.IsNullOrEmpty(directory))
            {
                MessageBox.Show("Please specify a directory to check");
                return;
            }
            if (!Directory.Exists(directory))
            {
                MessageBox.Show(string.Format("The directory you specified '{0}' does not exist", directory));
                return;
            }

            btnValidate.Text = CancelCaption;
            btnValidate.Tag = ValidateButtonAction.Cancel;
            progressValidation.Value = 0;
            statusValidation.Text = string.Empty;
            statusBar.Visible = true;
            lstResults.Items.Clear();

            var validCharsets = new List<string>(lstValidCharsets.CheckedItems.Count);
            foreach (string validCharset in lstValidCharsets.CheckedItems)
                validCharsets.Add(validCharset);

            _validationWorker.RunWorkerAsync(new WorkerArgs
            {
                BaseDirectory = directory,
                IncludeSubdirectories = chkIncludeSubdirectories.Checked,
                FileMasks = txtFileMasks.Text,
                ValidCharsets = validCharsets
            });
        }

        private void CancelValidation()
        {
            btnValidate.Enabled = false;
            if (_validationWorker.IsBusy)
                _validationWorker.CancelAsync();
        }
        #endregion

        #region Background worker event handlers and helper methods
        private static void ValidationWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;
            var args = (WorkerArgs)e.Argument;

            string[] allFiles = Directory.GetFiles(args.BaseDirectory, "*.*",
                args.IncludeSubdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

            IEnumerable<Regex> maskPatterns = GenerateMaskPatterns(args.FileMasks);
            for (int i = 0; i < allFiles.Length; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                string path = allFiles[i];
                string fileName = Path.GetFileName(path);
                if (!SatisfiesMaskPatterns(fileName, maskPatterns))
                    continue;

                var detector = new CharsetDetector();
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    detector.Feed(fs);
                    detector.DataEnd();
                }
                if (detector.Charset == null)
                    continue;
                if (args.ValidCharsets.Contains(detector.Charset))
                    continue;

                string directoryName = Path.GetDirectoryName(path);

                int percentageCompleted = (i * 100) / allFiles.Length;
                worker.ReportProgress(percentageCompleted, new WorkerProgress {
                    Charset = detector.Charset,
                    FileName = fileName,
                    DirectoryName = directoryName
                });
            }
        }

        private static IEnumerable<Regex> GenerateMaskPatterns(string fileMaskString)
        {
            string[] fileMasks = fileMaskString.Split(new[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

            var maskPatterns = new List<Regex>(fileMasks.Length);
            foreach (string fileMask in fileMasks)
            {
                if (string.IsNullOrEmpty(fileMask))
                    continue;
                var maskPattern =
                    new Regex("^" + fileMask.Replace(".", "[.]").Replace("*", ".*").Replace("?", ".") + "$",
                        RegexOptions.IgnoreCase);
                maskPatterns.Add(maskPattern);
            }
            return maskPatterns;
        }

        private static bool SatisfiesMaskPatterns(string fileName, IEnumerable<Regex> maskPatterns)
        {
            foreach (Regex maskPattern in maskPatterns)
            {
                if (maskPattern.IsMatch(fileName))
                    return true;
            }
            return false;
        }

        private void ValidationWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var progress = (WorkerProgress)e.UserState;

            var resultItem = new ListViewItem(new[] { progress.Charset, progress.FileName, progress.DirectoryName }, -1);
            lstResults.Items.Add(resultItem);

            progressValidation.Value = e.ProgressPercentage;
            statusValidation.Text = progress.FileName;
        }

        private void ValidationWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (ColumnHeader columnHeader in lstResults.Columns)
                columnHeader.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

            statusBar.Visible = false;
            btnValidate.Text = ValidateCaption;
            btnValidate.Tag = ValidateButtonAction.Validate;
            if (e.Cancelled)
                btnValidate.Enabled = true;
        }
        #endregion

        private const string ValidateCaption = "&Validate";

        private const string CancelCaption = "&Cancel";
    }
}