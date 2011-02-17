namespace EncodingChecker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblBaseDirectory;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label lblFileMasks;
            System.Windows.Forms.Label lblValidCharsets;
            System.Windows.Forms.ColumnHeader colEncoding;
            System.Windows.Forms.ColumnHeader colFileName;
            System.Windows.Forms.ColumnHeader colDirectory;
            this.btnBrowseDirectories = new System.Windows.Forms.Button();
            this.chkIncludeSubdirectories = new System.Windows.Forms.CheckBox();
            this.txtFileMasks = new System.Windows.Forms.TextBox();
            this.lstValidCharsets = new System.Windows.Forms.CheckedListBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListView();
            this.dlgBrowseDirectories = new System.Windows.Forms.FolderBrowserDialog();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.actionProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.actionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnView = new System.Windows.Forms.Button();
            this.lstBaseDirectory = new System.Windows.Forms.ComboBox();
            this.lblConvert = new System.Windows.Forms.Label();
            this.lstConvert = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.chkSelectDeselectAll = new System.Windows.Forms.CheckBox();
            lblBaseDirectory = new System.Windows.Forms.Label();
            lblFileMasks = new System.Windows.Forms.Label();
            lblValidCharsets = new System.Windows.Forms.Label();
            colEncoding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colDirectory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaseDirectory
            // 
            resources.ApplyResources(lblBaseDirectory, "lblBaseDirectory");
            lblBaseDirectory.Name = "lblBaseDirectory";
            // 
            // lblFileMasks
            // 
            resources.ApplyResources(lblFileMasks, "lblFileMasks");
            lblFileMasks.Name = "lblFileMasks";
            // 
            // lblValidCharsets
            // 
            resources.ApplyResources(lblValidCharsets, "lblValidCharsets");
            lblValidCharsets.Name = "lblValidCharsets";
            // 
            // colEncoding
            // 
            resources.ApplyResources(colEncoding, "colEncoding");
            // 
            // colFileName
            // 
            resources.ApplyResources(colFileName, "colFileName");
            // 
            // colDirectory
            // 
            resources.ApplyResources(colDirectory, "colDirectory");
            // 
            // btnBrowseDirectories
            // 
            resources.ApplyResources(this.btnBrowseDirectories, "btnBrowseDirectories");
            this.btnBrowseDirectories.Name = "btnBrowseDirectories";
            this.btnBrowseDirectories.UseVisualStyleBackColor = true;
            this.btnBrowseDirectories.Click += new System.EventHandler(this.OnBrowseDirectories);
            // 
            // chkIncludeSubdirectories
            // 
            resources.ApplyResources(this.chkIncludeSubdirectories, "chkIncludeSubdirectories");
            this.chkIncludeSubdirectories.Name = "chkIncludeSubdirectories";
            this.chkIncludeSubdirectories.UseVisualStyleBackColor = true;
            // 
            // txtFileMasks
            // 
            this.txtFileMasks.AcceptsReturn = true;
            resources.ApplyResources(this.txtFileMasks, "txtFileMasks");
            this.txtFileMasks.Name = "txtFileMasks";
            // 
            // lstValidCharsets
            // 
            this.lstValidCharsets.CheckOnClick = true;
            this.lstValidCharsets.FormattingEnabled = true;
            resources.ApplyResources(this.lstValidCharsets, "lstValidCharsets");
            this.lstValidCharsets.Name = "lstValidCharsets";
            // 
            // btnValidate
            // 
            resources.ApplyResources(this.btnValidate, "btnValidate");
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.OnAction);
            // 
            // btnAbout
            // 
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.OnAbout);
            // 
            // lstResults
            // 
            resources.ApplyResources(this.lstResults, "lstResults");
            this.lstResults.CheckBoxes = true;
            this.lstResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colEncoding,
            colFileName,
            colDirectory});
            this.lstResults.FullRowSelect = true;
            this.lstResults.GridLines = true;
            this.lstResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstResults.HideSelection = false;
            this.lstResults.Name = "lstResults";
            this.lstResults.UseCompatibleStateImageBehavior = false;
            this.lstResults.View = System.Windows.Forms.View.Details;
            this.lstResults.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstResults_ItemChecked);
            // 
            // dlgBrowseDirectories
            // 
            resources.ApplyResources(this.dlgBrowseDirectories, "dlgBrowseDirectories");
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionProgress,
            this.actionStatus});
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Name = "statusBar";
            // 
            // actionProgress
            // 
            this.actionProgress.Name = "actionProgress";
            resources.ApplyResources(this.actionProgress, "actionProgress");
            this.actionProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // actionStatus
            // 
            this.actionStatus.Name = "actionStatus";
            resources.ApplyResources(this.actionStatus, "actionStatus");
            // 
            // btnView
            // 
            resources.ApplyResources(this.btnView, "btnView");
            this.btnView.Name = "btnView";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.OnAction);
            // 
            // lstBaseDirectory
            // 
            resources.ApplyResources(this.lstBaseDirectory, "lstBaseDirectory");
            this.lstBaseDirectory.FormattingEnabled = true;
            this.lstBaseDirectory.Name = "lstBaseDirectory";
            // 
            // lblConvert
            // 
            resources.ApplyResources(this.lblConvert, "lblConvert");
            this.lblConvert.Name = "lblConvert";
            // 
            // lstConvert
            // 
            this.lstConvert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstConvert.FormattingEnabled = true;
            resources.ApplyResources(this.lstConvert, "lstConvert");
            this.lstConvert.Name = "lstConvert";
            // 
            // btnConvert
            // 
            resources.ApplyResources(this.btnConvert, "btnConvert");
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // chkSelectDeselectAll
            // 
            resources.ApplyResources(this.chkSelectDeselectAll, "chkSelectDeselectAll");
            this.chkSelectDeselectAll.Name = "chkSelectDeselectAll";
            this.chkSelectDeselectAll.UseVisualStyleBackColor = true;
            this.chkSelectDeselectAll.CheckedChanged += new System.EventHandler(this.chkSelectDeselectAll_CheckedChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkSelectDeselectAll);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lstConvert);
            this.Controls.Add(this.lblConvert);
            this.Controls.Add(this.lstBaseDirectory);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lstValidCharsets);
            this.Controls.Add(lblValidCharsets);
            this.Controls.Add(this.txtFileMasks);
            this.Controls.Add(lblFileMasks);
            this.Controls.Add(this.chkIncludeSubdirectories);
            this.Controls.Add(this.btnBrowseDirectories);
            this.Controls.Add(lblBaseDirectory);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseDirectories;
        private System.Windows.Forms.CheckBox chkIncludeSubdirectories;
        private System.Windows.Forms.TextBox txtFileMasks;
        private System.Windows.Forms.CheckedListBox lstValidCharsets;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ListView lstResults;
        private System.Windows.Forms.FolderBrowserDialog dlgBrowseDirectories;
        private System.Windows.Forms.ToolStripProgressBar actionProgress;
        private System.Windows.Forms.ToolStripStatusLabel actionStatus;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox lstBaseDirectory;
        private System.Windows.Forms.Label lblConvert;
        private System.Windows.Forms.ComboBox lstConvert;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.CheckBox chkSelectDeselectAll;
    }
}

