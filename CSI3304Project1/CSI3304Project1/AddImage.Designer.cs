namespace CSI3304Project1
{
    partial class AddImage
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
            this.lblAddImage = new System.Windows.Forms.Label();
            this.lblImageFile = new System.Windows.Forms.Label();
            this.txtboxImageFIleAddress = new System.Windows.Forms.TextBox();
            this.bttnBrowse = new System.Windows.Forms.Button();
            this.lblImageName = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.chkboxlistTags = new System.Windows.Forms.CheckedListBox();
            this.btnLoginHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.bttnAddImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnAddTag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddImage
            // 
            this.lblAddImage.AutoSize = true;
            this.lblAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.93194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddImage.Location = new System.Drawing.Point(17, 13);
            this.lblAddImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddImage.Name = "lblAddImage";
            this.lblAddImage.Size = new System.Drawing.Size(157, 18);
            this.lblAddImage.TabIndex = 0;
            this.lblAddImage.Text = "Add UploadedImage";
            this.lblAddImage.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblImageFile
            // 
            this.lblImageFile.AutoSize = true;
            this.lblImageFile.Location = new System.Drawing.Point(18, 64);
            this.lblImageFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageFile.Name = "lblImageFile";
            this.lblImageFile.Size = new System.Drawing.Size(104, 13);
            this.lblImageFile.TabIndex = 1;
            this.lblImageFile.Text = "UploadedImage File:";
            this.lblImageFile.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtboxImageFIleAddress
            // 
            this.txtboxImageFIleAddress.Location = new System.Drawing.Point(98, 64);
            this.txtboxImageFIleAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxImageFIleAddress.Name = "txtboxImageFIleAddress";
            this.txtboxImageFIleAddress.Size = new System.Drawing.Size(157, 20);
            this.txtboxImageFIleAddress.TabIndex = 2;
            // 
            // bttnBrowse
            // 
            this.bttnBrowse.Location = new System.Drawing.Point(268, 64);
            this.bttnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnBrowse.Name = "bttnBrowse";
            this.bttnBrowse.Size = new System.Drawing.Size(94, 23);
            this.bttnBrowse.TabIndex = 3;
            this.bttnBrowse.Text = "Browse";
            this.bttnBrowse.UseVisualStyleBackColor = true;
            this.bttnBrowse.Click += new System.EventHandler(this.bttnBrowse_Click);
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(18, 93);
            this.lblImageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(116, 13);
            this.lblImageName.TabIndex = 4;
            this.lblImageName.Text = "UploadedImage Name:";
            this.lblImageName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(98, 90);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(157, 20);
            this.txtboxName.TabIndex = 5;
            // 
            // chkboxlistTags
            // 
            this.chkboxlistTags.FormattingEnabled = true;
            this.chkboxlistTags.Location = new System.Drawing.Point(20, 127);
            this.chkboxlistTags.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkboxlistTags.Name = "chkboxlistTags";
            this.chkboxlistTags.Size = new System.Drawing.Size(318, 304);
            this.chkboxlistTags.TabIndex = 6;
            this.chkboxlistTags.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnLoginHome
            // 
            this.btnLoginHome.Location = new System.Drawing.Point(797, 12);
            this.btnLoginHome.Name = "btnLoginHome";
            this.btnLoginHome.Size = new System.Drawing.Size(94, 23);
            this.btnLoginHome.TabIndex = 15;
            this.btnLoginHome.Text = "Return to login";
            this.btnLoginHome.UseVisualStyleBackColor = true;
            this.btnLoginHome.Click += new System.EventHandler(this.btnLoginHome_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(897, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bttnAddImage
            // 
            this.bttnAddImage.Location = new System.Drawing.Point(20, 457);
            this.bttnAddImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnAddImage.Name = "bttnAddImage";
            this.bttnAddImage.Size = new System.Drawing.Size(94, 23);
            this.bttnAddImage.TabIndex = 16;
            this.bttnAddImage.Text = "Add UploadedImage";
            this.bttnAddImage.UseVisualStyleBackColor = true;
            this.bttnAddImage.Click += new System.EventHandler(this.bttnAddImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(471, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 431);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(242, 457);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(94, 23);
            this.bttnCancel.TabIndex = 18;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnAddTag
            // 
            this.bttnAddTag.Location = new System.Drawing.Point(124, 457);
            this.bttnAddTag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnAddTag.Name = "bttnAddTag";
            this.bttnAddTag.Size = new System.Drawing.Size(94, 23);
            this.bttnAddTag.TabIndex = 19;
            this.bttnAddTag.Text = "Add Tag";
            this.bttnAddTag.UseVisualStyleBackColor = true;
            this.bttnAddTag.Click += new System.EventHandler(this.bttnAddTag_Click);
            // 
            // AddImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.bttnAddTag);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttnAddImage);
            this.Controls.Add(this.btnLoginHome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chkboxlistTags);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.bttnBrowse);
            this.Controls.Add(this.txtboxImageFIleAddress);
            this.Controls.Add(this.lblImageFile);
            this.Controls.Add(this.lblAddImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddImage";
            this.Text = "AddImage";
            this.Load += new System.EventHandler(this.AddImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddImage;
        private System.Windows.Forms.Label lblImageFile;
        private System.Windows.Forms.TextBox txtboxImageFIleAddress;
        private System.Windows.Forms.Button bttnBrowse;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.CheckedListBox chkboxlistTags;
        private System.Windows.Forms.Button btnLoginHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button bttnAddImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnAddTag;
    }
}