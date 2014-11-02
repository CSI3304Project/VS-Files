namespace CSI3304Project1
{
    partial class ModerateImages
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoginHome = new System.Windows.Forms.Button();
            this.lblAddImage = new System.Windows.Forms.Label();
            this.imagesearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageBaseDataBaseDataSet = new CSI3304Project1.ImageBaseDataBaseDataSet();
            this.tblImageTagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblImageTagsTableAdapter = new CSI3304Project1.ImageBaseDataBaseDataSetTableAdapters.tblImageTagsTableAdapter();
            this.tagslist = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addtagcombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imgname = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.existingtags = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBaseDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblImageTagsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(897, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoginHome
            // 
            this.btnLoginHome.Location = new System.Drawing.Point(797, 12);
            this.btnLoginHome.Name = "btnLoginHome";
            this.btnLoginHome.Size = new System.Drawing.Size(94, 23);
            this.btnLoginHome.TabIndex = 16;
            this.btnLoginHome.Text = "Return to login";
            this.btnLoginHome.UseVisualStyleBackColor = true;
            this.btnLoginHome.Click += new System.EventHandler(this.btnLoginHome_Click);
            // 
            // lblAddImage
            // 
            this.lblAddImage.AutoSize = true;
            this.lblAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.93194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddImage.Location = new System.Drawing.Point(11, 17);
            this.lblAddImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddImage.Name = "lblAddImage";
            this.lblAddImage.Size = new System.Drawing.Size(143, 18);
            this.lblAddImage.TabIndex = 18;
            this.lblAddImage.Text = "Image Moderation";
            // 
            // imagesearch
            // 
            this.imagesearch.FormattingEnabled = true;
            this.imagesearch.Location = new System.Drawing.Point(160, 90);
            this.imagesearch.MaxDropDownItems = 50;
            this.imagesearch.Name = "imagesearch";
            this.imagesearch.Size = new System.Drawing.Size(190, 21);
            this.imagesearch.TabIndex = 19;
            this.imagesearch.SelectedIndexChanged += new System.EventHandler(this.imagesearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Unmoderated Images:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 366);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Approve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Reject";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageBaseDataBaseDataSet
            // 
            this.imageBaseDataBaseDataSet.DataSetName = "ImageBaseDataBaseDataSet";
            this.imageBaseDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblImageTagsBindingSource
            // 
            this.tblImageTagsBindingSource.DataMember = "tblImageTags";
            this.tblImageTagsBindingSource.DataSource = this.imageBaseDataBaseDataSet;
            // 
            // tblImageTagsTableAdapter
            // 
            this.tblImageTagsTableAdapter.ClearBeforeFill = true;
            // 
            // tagslist
            // 
            this.tagslist.FormattingEnabled = true;
            this.tagslist.Location = new System.Drawing.Point(373, 142);
            this.tagslist.Name = "tagslist";
            this.tagslist.Size = new System.Drawing.Size(121, 303);
            this.tagslist.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Add tag to image:";
            // 
            // addtagcombo
            // 
            this.addtagcombo.FormattingEnabled = true;
            this.addtagcombo.Location = new System.Drawing.Point(611, 156);
            this.addtagcombo.Name = "addtagcombo";
            this.addtagcombo.Size = new System.Drawing.Size(155, 21);
            this.addtagcombo.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Image Name: ";
            // 
            // imgname
            // 
            this.imgname.Location = new System.Drawing.Point(160, 118);
            this.imgname.Name = "imgname";
            this.imgname.ReadOnly = true;
            this.imgname.Size = new System.Drawing.Size(190, 20);
            this.imgname.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(630, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Add New Tag to image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // existingtags
            // 
            this.existingtags.FormattingEnabled = true;
            this.existingtags.Location = new System.Drawing.Point(611, 249);
            this.existingtags.Name = "existingtags";
            this.existingtags.Size = new System.Drawing.Size(155, 21);
            this.existingtags.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Delete existing tag:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(630, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "Delete Selected Tag";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ModerateImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.existingtags);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.imgname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addtagcombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tagslist);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagesearch);
            this.Controls.Add(this.lblAddImage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoginHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModerateImages";
            this.Text = "ModerateImages";
            this.Load += new System.EventHandler(this.ModerateImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBaseDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblImageTagsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoginHome;
        private System.Windows.Forms.Label lblAddImage;
        private System.Windows.Forms.ComboBox imagesearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ImageBaseDataBaseDataSet imageBaseDataBaseDataSet;
        private System.Windows.Forms.BindingSource tblImageTagsBindingSource;
        private ImageBaseDataBaseDataSetTableAdapters.tblImageTagsTableAdapter tblImageTagsTableAdapter;
        private System.Windows.Forms.ListBox tagslist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox addtagcombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imgname;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox existingtags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
    }
}