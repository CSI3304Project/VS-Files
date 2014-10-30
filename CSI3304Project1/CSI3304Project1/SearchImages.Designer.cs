namespace CSI3304Project1
{
    partial class SearchImages
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkboxlistTags = new System.Windows.Forms.CheckedListBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select one or more tags to search images";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkboxlistTags
            // 
            this.chkboxlistTags.FormattingEnabled = true;
            this.chkboxlistTags.Location = new System.Drawing.Point(56, 116);
            this.chkboxlistTags.Name = "chkboxlistTags";
            this.chkboxlistTags.Size = new System.Drawing.Size(918, 628);
            this.chkboxlistTags.TabIndex = 1;
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(56, 784);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(196, 44);
            this.bttnSearch.TabIndex = 3;
            this.bttnSearch.Text = "Search Images";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(778, 784);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(196, 44);
            this.bttnCancel.TabIndex = 4;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            // 
            // SearchImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 855);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.chkboxlistTags);
            this.Controls.Add(this.label1);
            this.Name = "SearchImages";
            this.Text = "SearchImages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkboxlistTags;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.Button bttnCancel;
    }
}