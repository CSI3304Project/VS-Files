﻿namespace CSI3304Project1
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
            this.components = new System.ComponentModel.Container();
            this.lblAddImage = new System.Windows.Forms.Label();
            this.lblImageFile = new System.Windows.Forms.Label();
            this.txtImageFIleAddress = new System.Windows.Forms.TextBox();
            this.bttnBrowse = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnLoginHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddImage
            // 
            this.lblAddImage.AutoSize = true;
            this.lblAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.93194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddImage.Location = new System.Drawing.Point(17, 13);
            this.lblAddImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddImage.Name = "lblAddImage";
            this.lblAddImage.Size = new System.Drawing.Size(86, 18);
            this.lblAddImage.TabIndex = 0;
            this.lblAddImage.Text = "Add Image";
            this.lblAddImage.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblImageFile
            // 
            this.lblImageFile.AutoSize = true;
            this.lblImageFile.Location = new System.Drawing.Point(18, 64);
            this.lblImageFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageFile.Name = "lblImageFile";
            this.lblImageFile.Size = new System.Drawing.Size(58, 13);
            this.lblImageFile.TabIndex = 1;
            this.lblImageFile.Text = "Image File:";
            this.lblImageFile.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtImageFIleAddress
            // 
            this.txtImageFIleAddress.Location = new System.Drawing.Point(98, 64);
            this.txtImageFIleAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtImageFIleAddress.Name = "txtImageFIleAddress";
            this.txtImageFIleAddress.Size = new System.Drawing.Size(157, 20);
            this.txtImageFIleAddress.TabIndex = 2;
            // 
            // bttnBrowse
            // 
            this.bttnBrowse.Location = new System.Drawing.Point(268, 64);
            this.bttnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnBrowse.Name = "bttnBrowse";
            this.bttnBrowse.Size = new System.Drawing.Size(54, 17);
            this.bttnBrowse.TabIndex = 3;
            this.bttnBrowse.Text = "Browse";
            this.bttnBrowse.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Image Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 90);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 5;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(20, 127);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(112, 19);
            this.checkedListBox1.TabIndex = 6;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnLoginHome
            // 
            this.btnLoginHome.Location = new System.Drawing.Point(797, 12);
            this.btnLoginHome.Name = "btnLoginHome";
            this.btnLoginHome.Size = new System.Drawing.Size(94, 23);
            this.btnLoginHome.TabIndex = 15;
            this.btnLoginHome.Text = "Return to login";
            this.btnLoginHome.UseVisualStyleBackColor = true;
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
            // AddImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.btnLoginHome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnBrowse);
            this.Controls.Add(this.txtImageFIleAddress);
            this.Controls.Add(this.lblImageFile);
            this.Controls.Add(this.lblAddImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddImage";
            this.Text = "AddImage";
            this.Load += new System.EventHandler(this.AddImage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddImage;
        private System.Windows.Forms.Label lblImageFile;
        private System.Windows.Forms.TextBox txtImageFIleAddress;
        private System.Windows.Forms.Button bttnBrowse;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnLoginHome;
        private System.Windows.Forms.Button btnExit;
    }
}