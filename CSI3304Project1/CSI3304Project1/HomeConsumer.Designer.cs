namespace CSI3304Project1
{
    partial class HomeConsumer
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkboxlistTags = new System.Windows.Forms.CheckedListBox();
            this.bttnDownload = new System.Windows.Forms.Button();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLoginHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home - Consumer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkboxlistTags);
            this.groupBox1.Controls.Add(this.bttnDownload);
            this.groupBox1.Controls.Add(this.bttnSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(184, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 309);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download UploadedImage";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkboxlistTags
            // 
            this.chkboxlistTags.FormattingEnabled = true;
            this.chkboxlistTags.Location = new System.Drawing.Point(157, 33);
            this.chkboxlistTags.Margin = new System.Windows.Forms.Padding(2);
            this.chkboxlistTags.Name = "chkboxlistTags";
            this.chkboxlistTags.Size = new System.Drawing.Size(370, 154);
            this.chkboxlistTags.TabIndex = 7;
            this.chkboxlistTags.SelectedIndexChanged += new System.EventHandler(this.chkboxlistTags_SelectedIndexChanged);
            // 
            // bttnDownload
            // 
            this.bttnDownload.Location = new System.Drawing.Point(280, 270);
            this.bttnDownload.Name = "bttnDownload";
            this.bttnDownload.Size = new System.Drawing.Size(75, 23);
            this.bttnDownload.TabIndex = 6;
            this.bttnDownload.Text = "Download";
            this.bttnDownload.UseVisualStyleBackColor = true;
            // 
            // bttnSearch
            // 
            this.bttnSearch.Location = new System.Drawing.Point(280, 201);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(75, 23);
            this.bttnSearch.TabIndex = 5;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = true;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select UploadedImage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Tags:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 484);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Change Customer Details";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnLoginHome
            // 
            this.btnLoginHome.Location = new System.Drawing.Point(797, 12);
            this.btnLoginHome.Name = "btnLoginHome";
            this.btnLoginHome.Size = new System.Drawing.Size(94, 23);
            this.btnLoginHome.TabIndex = 14;
            this.btnLoginHome.Text = "Return to login";
            this.btnLoginHome.UseVisualStyleBackColor = true;
            this.btnLoginHome.Click += new System.EventHandler(this.btnLoginHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(897, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // HomeConsumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 552);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoginHome);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "HomeConsumer";
            this.Text = "HomeConsumer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnDownload;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLoginHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckedListBox chkboxlistTags;
    }
}