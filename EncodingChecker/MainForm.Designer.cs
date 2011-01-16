﻿namespace EncodingChecker
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
            this.progressValidation = new System.Windows.Forms.ToolStripProgressBar();
            this.statusValidation = new System.Windows.Forms.ToolStripStatusLabel();
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
            lblBaseDirectory.AutoSize = true;
            lblBaseDirectory.Location = new System.Drawing.Point(10, 10);
            lblBaseDirectory.Name = "lblBaseDirectory";
            lblBaseDirectory.Size = new System.Drawing.Size(98, 13);
            lblBaseDirectory.TabIndex = 0;
            lblBaseDirectory.Text = "&Directory to check:";
            // 
            // lblFileMasks
            // 
            lblFileMasks.AutoSize = true;
            lblFileMasks.Location = new System.Drawing.Point(10, 59);
            lblFileMasks.Name = "lblFileMasks";
            lblFileMasks.Size = new System.Drawing.Size(149, 13);
            lblFileMasks.TabIndex = 4;
            lblFileMasks.Text = "Enter file &masks (one per line)";
            // 
            // lblValidCharsets
            // 
            lblValidCharsets.AutoSize = true;
            lblValidCharsets.Location = new System.Drawing.Point(220, 59);
            lblValidCharsets.Name = "lblValidCharsets";
            lblValidCharsets.Size = new System.Drawing.Size(133, 13);
            lblValidCharsets.TabIndex = 6;
            lblValidCharsets.Text = "Select valid &character sets";
            // 
            // colEncoding
            // 
            colEncoding.Text = "Encoding";
            colEncoding.Width = 25;
            // 
            // colFileName
            // 
            colFileName.Text = "File name";
            colFileName.Width = 25;
            // 
            // colDirectory
            // 
            colDirectory.Text = "Directory";
            colDirectory.Width = 25;
            // 
            // txtBaseDirectory
            // 
            this.txtBaseDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaseDirectory.Location = new System.Drawing.Point(10, 28);
            this.txtBaseDirectory.Name = "txtBaseDirectory";
            this.txtBaseDirectory.Size = new System.Drawing.Size(480, 21);
            this.txtBaseDirectory.TabIndex = 1;
            // 
            // btnBrowseDirectories
            // 
            this.btnBrowseDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDirectories.Location = new System.Drawing.Point(500, 28);
            this.btnBrowseDirectories.Name = "btnBrowseDirectories";
            this.btnBrowseDirectories.Size = new System.Drawing.Size(30, 21);
            this.btnBrowseDirectories.TabIndex = 2;
            this.btnBrowseDirectories.Text = "....";
            this.btnBrowseDirectories.UseVisualStyleBackColor = true;
            this.btnBrowseDirectories.Click += new System.EventHandler(this.OnBrowseDirectories);
            // 
            // chkIncludeSubdirectories
            // 
            this.chkIncludeSubdirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIncludeSubdirectories.AutoSize = true;
            this.chkIncludeSubdirectories.Location = new System.Drawing.Point(540, 30);
            this.chkIncludeSubdirectories.Name = "chkIncludeSubdirectories";
            this.chkIncludeSubdirectories.Size = new System.Drawing.Size(135, 17);
            this.chkIncludeSubdirectories.TabIndex = 3;
            this.chkIncludeSubdirectories.Text = "Include &sub-directories";
            this.chkIncludeSubdirectories.UseVisualStyleBackColor = true;
            // 
            // txtFileMasks
            // 
            this.txtFileMasks.AcceptsReturn = true;
            this.txtFileMasks.Location = new System.Drawing.Point(10, 77);
            this.txtFileMasks.Multiline = true;
            this.txtFileMasks.Name = "txtFileMasks";
            this.txtFileMasks.Size = new System.Drawing.Size(200, 100);
            this.txtFileMasks.TabIndex = 5;
            this.txtFileMasks.WordWrap = false;
            // 
            // lstValidCharsets
            // 
            this.lstValidCharsets.CheckOnClick = true;
            this.lstValidCharsets.FormattingEnabled = true;
            this.lstValidCharsets.Location = new System.Drawing.Point(220, 77);
            this.lstValidCharsets.Name = "lstValidCharsets";
            this.lstValidCharsets.Size = new System.Drawing.Size(200, 100);
            this.lstValidCharsets.TabIndex = 7;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(430, 126);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 8;
            this.btnValidate.Text = "&Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.OnValidate);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(430, 154);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // lstResults
            // 
            this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colEncoding,
            colFileName,
            colDirectory});
            this.lstResults.Location = new System.Drawing.Point(10, 187);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(680, 300);
            this.lstResults.TabIndex = 9;
            this.lstResults.UseCompatibleStateImageBehavior = false;
            this.lstResults.View = System.Windows.Forms.View.Details;
            // 
            // dlgBrowseDirectories
            // 
            this.dlgBrowseDirectories.Description = "Select the directory that you wish to check:";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressValidation,
            this.statusValidation});
            this.statusBar.Location = new System.Drawing.Point(0, 499);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(700, 22);
            this.statusBar.TabIndex = 12;
            this.statusBar.Visible = false;
            // 
            // progressValidation
            // 
            this.progressValidation.Name = "progressValidation";
            this.progressValidation.Size = new System.Drawing.Size(100, 16);
            this.progressValidation.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // statusValidation
            // 
            this.statusValidation.Name = "statusValidation";
            this.statusValidation.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 519);
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
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(525, 350);
            this.Name = "MainForm";
            this.Text = "File Encoding Checker";
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
        private System.Windows.Forms.ToolStripProgressBar progressValidation;
        private System.Windows.Forms.ToolStripStatusLabel statusValidation;
        private System.Windows.Forms.StatusStrip statusBar;
    }
}

