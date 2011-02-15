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
            System.Windows.Forms.ToolStrip ts;
            System.Windows.Forms.ToolStripSeparator tsep1;
            System.Windows.Forms.ToolStripSeparator tsep2;
            this.tbtnConvert = new System.Windows.Forms.ToolStripDropDownButton();
            this.tbtnSelectAll = new System.Windows.Forms.ToolStripButton();
            this.tbtnSelectNone = new System.Windows.Forms.ToolStripButton();
            this.tbtnToggleSelection = new System.Windows.Forms.ToolStripButton();
            this.tbtnAbout = new System.Windows.Forms.ToolStripButton();
            this.btnBrowseDirectories = new System.Windows.Forms.Button();
            this.chkIncludeSubdirectories = new System.Windows.Forms.CheckBox();
            this.txtFileMasks = new System.Windows.Forms.TextBox();
            this.lstValidCharsets = new System.Windows.Forms.CheckedListBox();
            this.lstResults = new System.Windows.Forms.ListView();
            this.dlgBrowseDirectories = new System.Windows.Forms.FolderBrowserDialog();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.actionProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.actionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstBaseDirectory = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            lblBaseDirectory = new System.Windows.Forms.Label();
            lblFileMasks = new System.Windows.Forms.Label();
            lblValidCharsets = new System.Windows.Forms.Label();
            colEncoding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colDirectory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ts = new System.Windows.Forms.ToolStrip();
            tsep1 = new System.Windows.Forms.ToolStripSeparator();
            tsep2 = new System.Windows.Forms.ToolStripSeparator();
            ts.SuspendLayout();
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
            // ts
            // 
            resources.ApplyResources(ts, "ts");
            ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsep1,
            this.tbtnConvert,
            this.tbtnSelectAll,
            this.tbtnSelectNone,
            this.tbtnToggleSelection,
            tsep2,
            this.tbtnAbout});
            ts.Name = "ts";
            ts.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            ts.TabStop = true;
            // 
            // tsep1
            // 
            tsep1.Name = "tsep1";
            resources.ApplyResources(tsep1, "tsep1");
            // 
            // tbtnConvert
            // 
            this.tbtnConvert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.tbtnConvert, "tbtnConvert");
            this.tbtnConvert.Name = "tbtnConvert";
            // 
            // tbtnSelectAll
            // 
            this.tbtnSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.tbtnSelectAll, "tbtnSelectAll");
            this.tbtnSelectAll.Name = "tbtnSelectAll";
            this.tbtnSelectAll.Click += new System.EventHandler(this.OnSelectAllResults);
            // 
            // tbtnSelectNone
            // 
            this.tbtnSelectNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.tbtnSelectNone, "tbtnSelectNone");
            this.tbtnSelectNone.Name = "tbtnSelectNone";
            this.tbtnSelectNone.Click += new System.EventHandler(this.OnUnselectAllResults);
            // 
            // tbtnToggleSelection
            // 
            this.tbtnToggleSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.tbtnToggleSelection, "tbtnToggleSelection");
            this.tbtnToggleSelection.Name = "tbtnToggleSelection";
            this.tbtnToggleSelection.Click += new System.EventHandler(this.OnToggleResultSelections);
            // 
            // tsep2
            // 
            tsep2.Name = "tsep2";
            resources.ApplyResources(tsep2, "tsep2");
            // 
            // tbtnAbout
            // 
            this.tbtnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.tbtnAbout, "tbtnAbout");
            this.tbtnAbout.Name = "tbtnAbout";
            this.tbtnAbout.Click += new System.EventHandler(this.OnAbout);
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
            this.lstResults.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.OnResultItemChecked);
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
            // lstBaseDirectory
            // 
            resources.ApplyResources(this.lstBaseDirectory, "lstBaseDirectory");
            this.lstBaseDirectory.FormattingEnabled = true;
            this.lstBaseDirectory.Name = "lstBaseDirectory";
            // 
            // btnView
            // 
            resources.ApplyResources(this.btnView, "btnView");
            this.btnView.Name = "btnView";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.OnAction);
            // 
            // btnValidate
            // 
            resources.ApplyResources(this.btnValidate, "btnValidate");
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.OnAction);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(ts);
            this.Controls.Add(this.lstBaseDirectory);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.lstResults);
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
            ts.ResumeLayout(false);
            ts.PerformLayout();
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
        private System.Windows.Forms.ListView lstResults;
        private System.Windows.Forms.FolderBrowserDialog dlgBrowseDirectories;
        private System.Windows.Forms.ToolStripProgressBar actionProgress;
        private System.Windows.Forms.ToolStripStatusLabel actionStatus;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ComboBox lstBaseDirectory;
        private System.Windows.Forms.ToolStripDropDownButton tbtnConvert;
        private System.Windows.Forms.ToolStripButton tbtnSelectAll;
        private System.Windows.Forms.ToolStripButton tbtnSelectNone;
        private System.Windows.Forms.ToolStripButton tbtnToggleSelection;
        private System.Windows.Forms.ToolStripButton tbtnAbout;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button button1;
    }
}

