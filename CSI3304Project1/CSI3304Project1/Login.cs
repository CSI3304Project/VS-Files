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
        private SqlDataAdapter da;
        private DataTable dt;
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
            //Connect to database. Need to test
            try
            {
                con = new SqlConnection(@"Data Source=.;Initial Catalog=ImageBaseDatabase;Persist Security Info=True;User ID=sa;Password=pw2server1;");
                con.Open();
                cmd = new SqlCommand("SELECT * FROM tblUser WHERE userUsername='" + enteredUsername + "'");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Username is correct");
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username.. Access Denied");
                }
                else
                {
                    MessageBox.Show("Username is incorrect.. Please try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("didnt connect");
            }
        }
    }

}
