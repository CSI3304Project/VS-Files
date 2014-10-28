using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSI3304Project1
{
    public partial class Login : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Assign text box fields
            string enteredUsername = txtUserName.Text;
            string enteredPassword = txtPassword.Text;
            //Connect to database
            try
            {
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                con.Open();
                //Check username
                cmd = new SqlCommand("SELECT * FROM tblUser WHERE userUsername='" + enteredUsername + "' AND userPassword='" + enteredPassword + "'");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                int count = 0;
                string type = "";
                while (dr.Read())
                {
                    count = count + 1;
                    type = dr.GetString(5);

                }
                if (count == 1)
                {

                    if (type == "admin")
                    {
                        MessageBox.Show("Welcome - Logged in as Admin");
                        HomeAdmin Check = new HomeAdmin();
                        Check.Show();
                        Hide();
                    }
                    else if (type == "moderator")
                    {
                        MessageBox.Show("Welcome - Logged in as Moderator");
                        HomeModerator Check = new HomeModerator();
                        Check.Show();
                        Hide();
                    }
                    else if (type == "consumer")
                    {
                        MessageBox.Show("Welcome - Logged in as Consumer");
                        HomeConsumer Check = new HomeConsumer();
                        Check.Show();
                        Hide();
                    }
                    else if (type == "provider")
                    {
                        MessageBox.Show("Welcome - Logged in as Provider");
                        HomeProvider Check = new HomeProvider();
                        Check.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Type.. Please speak to an admin");

                    }
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and/or password.. Access Denied");
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.. Please try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Close();
        }
    }

}
