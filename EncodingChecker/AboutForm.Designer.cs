namespace EncodingChecker
{
    partial class AboutForm
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
            System.Windows.Forms.Label lblProductName;
            System.Windows.Forms.Label lblVersion;
            System.Windows.Forms.Label lblCredits;
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHomepage = new System.Windows.Forms.LinkLabel();
            this.lblAuthor = new System.Windows.Forms.LinkLabel();
            this.lblLicense = new System.Windows.Forms.LinkLabel();
            this.lblCreditsUde = new System.Windows.Forms.LinkLabel();
            this.lblCreditsCodePlex = new System.Windows.Forms.LinkLabel();
            lblProductName = new System.Windows.Forms.Label();
            lblVersion = new System.Windows.Forms.Label();
            lblCredits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblProductName.Location = new System.Drawing.Point(5, 10);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new System.Drawing.Size(312, 33);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "File Encoding Checker";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(255, 224);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblHomepage
            // 
            this.lblHomepage.AutoSize = true;
            this.lblHomepage.Location = new System.Drawing.Point(15, 66);
            this.lblHomepage.Name = "lblHomepage";
            this.lblHomepage.Size = new System.Drawing.Size(58, 18);
            this.lblHomepage.TabIndex = 2;
            this.lblHomepage.TabStop = true;
            this.lblHomepage.Text = "Homepage";
            this.lblHomepage.UseCompatibleTextRendering = true;
            this.lblHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(OnLinkClicked);
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new System.Drawing.Point(15, 48);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(60, 18);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Version 1.0";
            lblVersion.UseCompatibleTextRendering = true;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.LinkArea = new System.Windows.Forms.LinkArea(11, 12);
            this.lblAuthor.Location = new System.Drawing.Point(15, 89);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(131, 18);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.TabStop = true;
            this.lblAuthor.Text = "Created by Jeevan James";
            this.lblAuthor.UseCompatibleTextRendering = true;
            this.lblAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(OnLinkClicked);
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.LinkArea = new System.Windows.Forms.LinkArea(19, 26);
            this.lblLicense.Location = new System.Drawing.Point(15, 107);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(229, 18);
            this.lblLicense.TabIndex = 4;
            this.lblLicense.TabStop = true;
            this.lblLicense.Text = "Licensed under the Mozilla Public License 1.1";
            this.lblLicense.UseCompatibleTextRendering = true;
            this.lblLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(OnLinkClicked);
            // 
            // lblCredits
            // 
            lblCredits.AutoSize = true;
            lblCredits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCredits.Location = new System.Drawing.Point(15, 130);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new System.Drawing.Size(49, 18);
            lblCredits.TabIndex = 5;
            lblCredits.Text = "Credits:";
            lblCredits.UseCompatibleTextRendering = true;
            // 
            // lblCreditsUde
            // 
            this.lblCreditsUde.AutoSize = true;
            this.lblCreditsUde.LinkArea = new System.Windows.Forms.LinkArea(0, 3);
            this.lblCreditsUde.Location = new System.Drawing.Point(25, 148);
            this.lblCreditsUde.Name = "lblCreditsUde";
            this.lblCreditsUde.Size = new System.Drawing.Size(265, 18);
            this.lblCreditsUde.TabIndex = 6;
            this.lblCreditsUde.TabStop = true;
            this.lblCreditsUde.Text = "ude, a C# port of Mozilla Universal Charset Detector";
            this.lblCreditsUde.UseCompatibleTextRendering = true;
            this.lblCreditsUde.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(OnLinkClicked);
            // 
            // lblCreditsCodePlex
            // 
            this.lblCreditsCodePlex.AutoSize = true;
            this.lblCreditsCodePlex.LinkArea = new System.Windows.Forms.LinkArea(0, 8);
            this.lblCreditsCodePlex.Location = new System.Drawing.Point(25, 166);
            this.lblCreditsCodePlex.Name = "lblCreditsCodePlex";
            this.lblCreditsCodePlex.Size = new System.Drawing.Size(149, 18);
            this.lblCreditsCodePlex.TabIndex = 7;
            this.lblCreditsCodePlex.TabStop = true;
            this.lblCreditsCodePlex.Text = "CodePlex, for project hosting";
            this.lblCreditsCodePlex.UseCompatibleTextRendering = true;
            this.lblCreditsCodePlex.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(OnLinkClicked);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(340, 257);
            this.Controls.Add(this.lblCreditsCodePlex);
            this.Controls.Add(this.lblCreditsUde);
            this.Controls.Add(lblCredits);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(lblVersion);
            this.Controls.Add(this.lblHomepage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(lblProductName);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lblHomepage;
        private System.Windows.Forms.LinkLabel lblAuthor;
        private System.Windows.Forms.LinkLabel lblLicense;
        private System.Windows.Forms.LinkLabel lblCreditsUde;
        private System.Windows.Forms.LinkLabel lblCreditsCodePlex;
    }
}