namespace CSI3304Project1
{
    partial class AddUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userLastName_txt = new System.Windows.Forms.TextBox();
            this.userFirstName_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userUsername_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLoginHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userPassword_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userEmail_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.userType_txt = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add User";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userLastName_txt);
            this.groupBox1.Controls.Add(this.userFirstName_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(341, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // userLastName_txt
            // 
            this.userLastName_txt.Location = new System.Drawing.Point(80, 53);
            this.userLastName_txt.Name = "userLastName_txt";
            this.userLastName_txt.Size = new System.Drawing.Size(100, 20);
            this.userLastName_txt.TabIndex = 5;
            // 
            // userFirstName_txt
            // 
            this.userFirstName_txt.Location = new System.Drawing.Point(80, 24);
            this.userFirstName_txt.Name = "userFirstName_txt";
            this.userFirstName_txt.Size = new System.Drawing.Size(100, 20);
            this.userFirstName_txt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "First Name";
            // 
            // userUsername_txt
            // 
            this.userUsername_txt.Location = new System.Drawing.Point(421, 145);
            this.userUsername_txt.Name = "userUsername_txt";
            this.userUsername_txt.Size = new System.Drawing.Size(100, 20);
            this.userUsername_txt.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userType_txt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.userEmail_txt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(341, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 199);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Information";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(508, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLoginHome
            // 
            this.btnLoginHome.Location = new System.Drawing.Point(797, 12);
            this.btnLoginHome.Name = "btnLoginHome";
            this.btnLoginHome.Size = new System.Drawing.Size(94, 23);
            this.btnLoginHome.TabIndex = 15;
            this.btnLoginHome.Text = "Return to login";
            this.btnLoginHome.UseVisualStyleBackColor = true;
            this.btnLoginHome.Click += new System.EventHandler(this.btnLoginHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(897, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password";
            // 
            // userPassword_txt
            // 
            this.userPassword_txt.Location = new System.Drawing.Point(421, 178);
            this.userPassword_txt.Name = "userPassword_txt";
            this.userPassword_txt.Size = new System.Drawing.Size(100, 20);
            this.userPassword_txt.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email Address";
            // 
            // userEmail_txt
            // 
            this.userEmail_txt.Location = new System.Drawing.Point(14, 48);
            this.userEmail_txt.Name = "userEmail_txt";
            this.userEmail_txt.Size = new System.Drawing.Size(268, 20);
            this.userEmail_txt.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "User Type";
            // 
            // userType_txt
            // 
            this.userType_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userType_txt.FormattingEnabled = true;
            this.userType_txt.Items.AddRange(new object[] {
            "admin",
            "moderator",
            "consumer",
            "provider"});
            this.userType_txt.Location = new System.Drawing.Point(14, 110);
            this.userType_txt.Name = "userType_txt";
            this.userType_txt.Size = new System.Drawing.Size(121, 21);
            this.userType_txt.TabIndex = 3;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.userPassword_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoginHome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.userUsername_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "AddUser";
            this.Text = "Add User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox userLastName_txt;
        private System.Windows.Forms.TextBox userFirstName_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userUsername_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLoginHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userPassword_txt;
        private System.Windows.Forms.ComboBox userType_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userEmail_txt;
        private System.Windows.Forms.Label label6;
    }
}