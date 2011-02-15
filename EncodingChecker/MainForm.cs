using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Application;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Ude;

namespace EncodingChecker
{
    public partial class MainForm : Form
    {
        private sealed class WorkerArgs
        {
            internal CurrentAction Action;
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

        private enum CurrentAction
        {
            View,
            Validate,
        }

        private readonly BackgroundWorker _actionWorker;
        private CurrentAction _currentAction;
        private readonly List<string> _detectionEncodings;
        private readonly List<string> _conversionEncodings;
        private Settings _settings;

        public MainForm()
        {
            InitializeComponent();

            _actionWorker = new BackgroundWorker();
            _actionWorker.WorkerReportsProgress = true;
            _actionWorker.WorkerSupportsCancellation = true;
            _actionWorker.DoWork += ActionWorkerDoWork;
            _actionWorker.ProgressChanged += ActionWorkerProgressChanged;
            _actionWorker.RunWorkerCompleted += ActionWorkerCompleted;

            //Using reflection, figure out all the charsets that the Ude framework supports by reflecting
            //over all the strings constants in the Ude.Charsets class. These represent all the encodings
            //that can be detected by the program.
            FieldInfo[] charsetConstants = typeof(Charsets).GetFields(BindingFlags.GetField | BindingFlags.Static | BindingFlags.Public);
            _detectionEncodings = new List<string>(charsetConstants.Length);
            foreach (FieldInfo charsetConstant in charsetConstants)
            {
                if (charsetConstant.FieldType == typeof(string))
                    _detectionEncodings.Add((string)charsetConstant.GetValue(null));
            }

            EncodingInfo[] availableEncodings = Encoding.GetEncodings();
            _conversionEncodings = new List<string>(_detectionEncodings.Count);
            foreach (string detectionEncoding in _detectionEncodings)
            {
                string encodingToCheck = detectionEncoding;
                bool encodingExists = Array.Exists(availableEncodings,
                    delegate(EncodingInfo ei) { return ei.Name.Equals(encodingToCheck, StringComparison.OrdinalIgnoreCase); });
                if (!encodingExists)
                    _conversionEncodings.Add(encodingToCheck);
            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            foreach (string encoding in _detectionEncodings)
                lstValidCharsets.Items.Add(encoding);

            //Set the initial action for the action buttons in their Tag properties
            btnView.Tag = CurrentAction.View;
            btnValidate.Tag = CurrentAction.Validate;

            Converter<string, ToolStripItem> converter =
                delegate(string encodingName) {
                    ToolStripMenuItem menu = new ToolStripMenuItem(encodingName, null, OnAction);
                    //menu.Tag = CurrentAction.Convert;
                    return menu;
                };
            ToolStripItem[] conversionItems = _conversionEncodings.ConvertAll(converter).ToArray();
            tbtnConvert.DropDownItems.AddRange(conversionItems);

            LoadSettings();

            //Size the result list columns based on the initial size of the window
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
            dlgBrowseDirectories.SelectedPath = lstBaseDirectory.Text;
            if (dlgBrowseDirectories.ShowDialog(this) == DialogResult.OK)
            {
                lstBaseDirectory.Text = dlgBrowseDirectories.SelectedPath;
                lstBaseDirectory.Items.Add(dlgBrowseDirectories.SelectedPath);
            }
        }

        private void OnResultItemChecked(object sender, ItemCheckedEventArgs e)
        {
            tbtnConvert.Enabled = lstResults.CheckedItems.Count > 0;
        }

        private void OnSelectAllResults(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstResults.Items)
                item.Checked = true;
        }

        private void OnUnselectAllResults(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstResults.Items)
                item.Checked = false;
        }

        private void OnToggleResultSelections(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstResults.Items)
                item.Checked = !item.Checked;
        }

        private void OnAbout(object sender, EventArgs e)
        {
            using (AboutForm aboutForm = new AboutForm())
                aboutForm.ShowDialog(this);
        }

        #region Loading and saving of settings
        private void LoadSettings()
        {
            string settingsFileName = GetSettingsFileName();
            if (!File.Exists(settingsFileName))
                return;
            using (
                FileStream settingsFile = new FileStream(settingsFileName, FileMode.Open, FileAccess.Read,
                    FileShare.Read))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                object settingsInstance = formatter.Deserialize(settingsFile);
                _settings = (Settings)settingsInstance;
            }

            if (_settings.RecentDirectories != null && _settings.RecentDirectories.Count > 0)
            {
                foreach (string recentDirectory in _settings.RecentDirectories)
                    lstBaseDirectory.Items.Add(recentDirectory);
                lstBaseDirectory.SelectedIndex = 0;
            }
            else
                lstBaseDirectory.Text = Environment.CurrentDirectory;
            chkIncludeSubdirectories.Checked = _settings.IncludeSubdirectories;
            txtFileMasks.Text = _settings.FileMasks;
            if (_settings.ValidCharsets != null && _settings.ValidCharsets.Length > 0)
            {
                for (int i = 0; i < lstValidCharsets.Items.Count; i++)
                    if (Array.Exists(_settings.ValidCharsets, delegate(string charset) {
                                                                  return charset.Equals((string)lstValidCharsets.Items[i]);
                                                              }))
                        lstValidCharsets.SetItemChecked(i, true);
            }
            if (_settings.WindowPosition != null)
                _settings.WindowPosition.ApplyTo(this);
        }

        private void SaveSettings()
        {
            if (_settings == null)
                _settings = new Settings();
            _settings.IncludeSubdirectories = chkIncludeSubdirectories.Checked;
            _settings.FileMasks = txtFileMasks.Text;

            _settings.ValidCharsets = new string[lstValidCharsets.CheckedItems.Count];
            for (int i = 0; i < lstValidCharsets.CheckedItems.Count; i++)
                _settings.ValidCharsets[i] = (string)lstValidCharsets.CheckedItems[i];

            _settings.WindowPosition = new WindowPosition();
            _settings.WindowPosition.Left = Left;
            _settings.WindowPosition.Top = Top;
            _settings.WindowPosition.Width = Width;
            _settings.WindowPosition.Height = Height;

            string settingsFileName = GetSettingsFileName();
            using (
                FileStream settingsFile = new FileStream(settingsFileName, FileMode.Create, FileAccess.Write,
                    FileShare.None))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(settingsFile, _settings);
                settingsFile.Flush();
            }
        }

        private static string GetSettingsFileName()
        {
            string dataDirectory = ApplicationDeployment.IsNetworkDeployed
                ? ApplicationDeployment.CurrentDeployment.DataDirectory
                : Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (string.IsNullOrEmpty(dataDirectory) || !Directory.Exists(dataDirectory))
                dataDirectory = Environment.CurrentDirectory;
            dataDirectory = Path.Combine(dataDirectory, "EncodingChecker");
            if (!Directory.Exists(dataDirectory))
                Directory.CreateDirectory(dataDirectory);
            return Path.Combine(dataDirectory, "Settings.bin");
        }
        #endregion

        #region Action button handling
        private void OnAction(object sender, EventArgs e)
        {
            Button actionButton = (Button)sender;
            if (actionButton.Tag == null)
                CancelAction();
            else
            {
                _currentAction = (CurrentAction)actionButton.Tag;
                actionButton.Tag = null;
                StartAction(_currentAction);
            }
        }

        private void StartAction(CurrentAction action)
        {
            string directory = lstBaseDirectory.Text;
            if (string.IsNullOrEmpty(directory))
            {
                ShowWarning("Please specify a directory to check");
                return;
            }
            if (!Directory.Exists(directory))
            {
                ShowWarning("The directory you specified '{0}' does not exist", directory);
                return;
            }
            if (action == CurrentAction.Validate && lstValidCharsets.CheckedItems.Count == 0)
            {
                ShowWarning("Select one or more valid character sets to proceed with validation");
                return;
            }

            _currentAction = action;

            _settings.RecentDirectories.Add(directory);

            UpdateControlsOnActionStart(action);

            List<string> validCharsets = new List<string>(lstValidCharsets.CheckedItems.Count);
            foreach (string validCharset in lstValidCharsets.CheckedItems)
                validCharsets.Add(validCharset);

            WorkerArgs args = new WorkerArgs();
            args.Action = action;
            args.BaseDirectory = directory;
            args.IncludeSubdirectories = chkIncludeSubdirectories.Checked;
            args.FileMasks = txtFileMasks.Text;
            args.ValidCharsets = validCharsets;
            _actionWorker.RunWorkerAsync(args);
        }

        private void CancelAction()
        {
            if (_actionWorker.IsBusy)
            {
                Button actionButton = _currentAction == CurrentAction.View ? btnView : btnValidate;
                actionButton.Enabled = false;
                _actionWorker.CancelAsync();
            }
        }
        #endregion

        #region Background worker event handlers and helper methods
        private static void ActionWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            WorkerArgs args = (WorkerArgs)e.Argument;

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

                System.Threading.Thread.SpinWait(1);

                string path = allFiles[i];
                string fileName = Path.GetFileName(path);
                if (!SatisfiesMaskPatterns(fileName, maskPatterns))
                    continue;

                CharsetDetector detector = new CharsetDetector();
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    detector.Feed(fs);
                    detector.DataEnd();
                }
                if (args.Action == CurrentAction.Validate)
                {
                    if (detector.Charset == null)
                        continue;
                    if (args.ValidCharsets.Contains(detector.Charset))
                        continue;
                }

                string directoryName = Path.GetDirectoryName(path);

                int percentageCompleted = (i * 100) / allFiles.Length;
                WorkerProgress progress = new WorkerProgress();
                progress.Charset = detector.Charset ?? "(Unknown)";
                progress.FileName = fileName;
                progress.DirectoryName = directoryName;
                worker.ReportProgress(percentageCompleted, progress);
            }
        }

        private static IEnumerable<Regex> GenerateMaskPatterns(string fileMaskString)
        {
            string[] fileMasks = fileMaskString.Split(new string[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);
            string[] processedFileMasks = Array.FindAll(fileMasks, delegate(string mask) { return mask.Trim().Length > 0; });
            if (processedFileMasks.Length == 0)
                processedFileMasks = new string[] { "*.*" };

            List<Regex> maskPatterns = new List<Regex>(processedFileMasks.Length);
            foreach (string fileMask in processedFileMasks)
            {
                if (string.IsNullOrEmpty(fileMask))
                    continue;
                Regex maskPattern =
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

        private void ActionWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WorkerProgress progress = (WorkerProgress)e.UserState;

            ListViewItem resultItem =
                new ListViewItem(new string[] { progress.Charset, progress.FileName, progress.DirectoryName }, -1);
            lstResults.Items.Add(resultItem);

            actionProgress.Value = e.ProgressPercentage;
            actionStatus.Text = progress.FileName;
        }

        private void ActionWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (lstResults.Items.Count > 0)
            {
                foreach (ColumnHeader columnHeader in lstResults.Columns)
                    columnHeader.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            UpdateControlsOnActionDone(e.Cancelled);
        }
        #endregion

        private void UpdateControlsOnActionStart(CurrentAction action)
        {
            Button actionButton = action == CurrentAction.View ? btnView : btnValidate;
            Button otherActionButton = action == CurrentAction.View ? btnValidate : btnView;

            actionButton.Text = CancelCaption;
            actionButton.Tag = null;
            otherActionButton.Enabled = false;

            tbtnConvert.Enabled = false;
            tbtnSelectAll.Enabled = false;
            tbtnSelectNone.Enabled = false;
            tbtnToggleSelection.Enabled = false;

            lstResults.Items.Clear();

            actionProgress.Value = 0;
            actionProgress.Visible = true;
            actionStatus.Text = string.Empty;
        }

        private void UpdateControlsOnActionDone(bool cancelled)
        {
            Button actionButton = _currentAction == CurrentAction.View ? btnView : btnValidate;
            Button otherActionButton = _currentAction == CurrentAction.View ? btnValidate : btnView;

            actionButton.Text = _currentAction == CurrentAction.View ? ViewCaption : ValidateCaption;
            actionButton.Tag = _currentAction;
            otherActionButton.Enabled = true;
            if (cancelled)
                actionButton.Enabled = true;

            if (lstResults.Items.Count > 0)
            {
                tbtnSelectAll.Enabled = true;
                tbtnSelectNone.Enabled = true;
                tbtnToggleSelection.Enabled = true;
            }

            actionProgress.Visible = false;

            string statusMessage = _currentAction == CurrentAction.View
                ? "{0} files processed" : "{0} files do not have the correct encoding";
            actionStatus.Text = string.Format(statusMessage, lstResults.Items.Count);
        }

        private void ShowWarning(string message, params object[] args)
        {
            MessageBox.Show(this, string.Format(message, args), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private const string ViewCaption = "Vie&w";
        private const string ValidateCaption = "&Validate";
        private const string CancelCaption = "&Cancel";

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem result in lstResults.CheckedItems)
            {
                string charset = result.SubItems[0].Text;
                string fileName = result.SubItems[1].Text;
                string directory = result.SubItems[2].Text;

                string filePath = Path.Combine(directory, fileName);
                string content;
                using (StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding(charset)))
                    content = reader.ReadToEnd();
                string correctCharset = (string)lstValidCharsets.CheckedItems[0];
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.GetEncoding(correctCharset)))
                {
                    writer.Write(content);
                    writer.Flush();
                }
            }
        }
    }
}