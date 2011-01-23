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
            this.txtBaseDirectory = new System.Windows.Forms.TextBox();
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
            // txtBaseDirectory
            // 
            resources.ApplyResources(this.txtBaseDirectory, "txtBaseDirectory");
            this.txtBaseDirectory.Name = "txtBaseDirectory";
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
            resources.ApplyResources(this.lstValidCharsets, "lstValidCharsets");
            this.lstValidCharsets.CheckOnClick = true;
            this.lstValidCharsets.FormattingEnabled = true;
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
            this.lstResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colEncoding,
            colFileName,
            colDirectory});
            this.lstResults.FullRowSelect = true;
            this.lstResults.GridLines = true;
            this.lstResults.Name = "lstResults";
            this.lstResults.UseCompatibleStateImageBehavior = false;
            this.lstResults.View = System.Windows.Forms.View.Details;
            // 
            // dlgBrowseDirectories
            // 
            resources.ApplyResources(this.dlgBrowseDirectories, "dlgBrowseDirectories");
            // 
            // statusBar
            // 
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionProgress,
            this.actionStatus});
            this.statusBar.Name = "statusBar";
            // 
            // actionProgress
            // 
            resources.ApplyResources(this.actionProgress, "actionProgress");
            this.actionProgress.Name = "actionProgress";
            this.actionProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // actionStatus
            // 
            resources.ApplyResources(this.actionStatus, "actionStatus");
            this.actionStatus.Name = "actionStatus";
            // 
            // btnView
            // 
            resources.ApplyResources(this.btnView, "btnView");
            this.btnView.Name = "btnView";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.OnAction);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.txtBaseDirectory);
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

        private System.Windows.Forms.TextBox txtBaseDirectory;
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
    }
}

