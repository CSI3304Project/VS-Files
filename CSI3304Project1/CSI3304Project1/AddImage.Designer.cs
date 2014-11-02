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
            this.lblFile = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxFile = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.bttnBrowse = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnAddTag = new System.Windows.Forms.Button();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(89, 57);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(53, 26);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "File:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(89, 165);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 26);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtboxFile
            // 
            this.txtboxFile.Location = new System.Drawing.Point(227, 57);
            this.txtboxFile.Name = "txtboxFile";
            this.txtboxFile.Size = new System.Drawing.Size(254, 31);
            this.txtboxFile.TabIndex = 2;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(227, 165);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(254, 31);
            this.txtboxName.TabIndex = 3;
            // 
            // bttnBrowse
            // 
            this.bttnBrowse.Location = new System.Drawing.Point(591, 57);
            this.bttnBrowse.Name = "bttnBrowse";
            this.bttnBrowse.Size = new System.Drawing.Size(186, 31);
            this.bttnBrowse.TabIndex = 4;
            this.bttnBrowse.Text = "Browse";
            this.bttnBrowse.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(94, 260);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(683, 576);
            this.checkedListBox1.TabIndex = 5;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(929, 260);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(652, 576);
            this.picImage.TabIndex = 6;
            this.picImage.TabStop = false;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(94, 869);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(186, 31);
            this.bttnAdd.TabIndex = 7;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(591, 869);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(186, 31);
            this.bttnCancel.TabIndex = 8;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            // 
            // bttnAddTag
            // 
            this.bttnAddTag.Location = new System.Drawing.Point(341, 869);
            this.bttnAddTag.Name = "bttnAddTag";
            this.bttnAddTag.Size = new System.Drawing.Size(186, 31);
            this.bttnAddTag.TabIndex = 9;
            this.bttnAddTag.Text = "Cancel";
            this.bttnAddTag.UseVisualStyleBackColor = true;
            // 
            // bttnLogin
            // 
            this.bttnLogin.Location = new System.Drawing.Point(1395, 57);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(186, 31);
            this.bttnLogin.TabIndex = 10;
            this.bttnLogin.Text = "Return to Login";
            this.bttnLogin.UseVisualStyleBackColor = true;
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(1611, 57);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(186, 31);
            this.bttnExit.TabIndex = 11;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(94, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 26);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Add Image";
            // 
            // AddImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 1021);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.bttnAddTag);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.bttnBrowse);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.txtboxFile);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFile);
            this.Name = "AddImage";
            this.Text = "AddImage";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxFile;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Button bttnBrowse;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnAddTag;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Label lblTitle;
    }
}