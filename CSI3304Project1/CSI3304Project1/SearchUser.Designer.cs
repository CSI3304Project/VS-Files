namespace CSI3304Project1
{
    partial class SearchUser
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
            this.usersearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UserType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usersearch
            // 
            this.usersearch.FormattingEnabled = true;
            this.usersearch.Location = new System.Drawing.Point(442, 173);
            this.usersearch.Name = "usersearch";
            this.usersearch.Size = new System.Drawing.Size(121, 21);
            this.usersearch.TabIndex = 0;
            this.usersearch.SelectedIndexChanged += new System.EventHandler(this.usersearch_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Username";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(442, 229);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surname";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(442, 268);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 7;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(442, 304);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(442, 344);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "User Type";
            // 
            // UserType
            // 
            this.UserType.Location = new System.Drawing.Point(442, 380);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(100, 20);
            this.UserType.TabIndex = 13;
            // 
            // SearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usersearch);
            this.Name = "SearchUser";
            this.Text = "SearchUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox usersearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserType;




    }
}