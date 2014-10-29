namespace CSI3304Project1
{
    partial class AddTag
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
            this.bttnAddTag = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.lblEnterTag = new System.Windows.Forms.Label();
            this.txtboxTag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnAddTag
            // 
            this.bttnAddTag.Location = new System.Drawing.Point(341, 48);
            this.bttnAddTag.Name = "bttnAddTag";
            this.bttnAddTag.Size = new System.Drawing.Size(188, 44);
            this.bttnAddTag.TabIndex = 0;
            this.bttnAddTag.Text = "Add Tag";
            this.bttnAddTag.UseVisualStyleBackColor = true;
            this.bttnAddTag.Click += new System.EventHandler(this.bttnAddTag_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(341, 125);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(188, 44);
            this.bttnCancel.TabIndex = 1;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // lblEnterTag
            // 
            this.lblEnterTag.AutoSize = true;
            this.lblEnterTag.Location = new System.Drawing.Point(31, 48);
            this.lblEnterTag.Name = "lblEnterTag";
            this.lblEnterTag.Size = new System.Drawing.Size(112, 26);
            this.lblEnterTag.TabIndex = 2;
            this.lblEnterTag.Text = "Enter Tag:";
            this.lblEnterTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxTag
            // 
            this.txtboxTag.Location = new System.Drawing.Point(36, 125);
            this.txtboxTag.Name = "txtboxTag";
            this.txtboxTag.Size = new System.Drawing.Size(202, 31);
            this.txtboxTag.TabIndex = 3;
            // 
            // AddTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 231);
            this.Controls.Add(this.txtboxTag);
            this.Controls.Add(this.lblEnterTag);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnAddTag);
            this.Name = "AddTag";
            this.Text = "AddTag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAddTag;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Label lblEnterTag;
        private System.Windows.Forms.TextBox txtboxTag;
    }
}