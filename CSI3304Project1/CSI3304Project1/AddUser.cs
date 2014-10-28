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
    public partial class AddUser : Form
    {
        private SqlConnection con;
        private SqlDataReader dr;
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoginHome_Click(object sender, EventArgs e)
        {
            Login Check = new Login();
            Check.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //connect to database
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                con.Open();
                //add user details
                string query="INSERT INTO tblUser (userUsername, userPassword, userFirstName, userLastName, userEmail, userType) VALUES ('"
                    + userUsername_txt.Text + "', '" + userPassword_txt.Text + "', '" + userFirstName_txt.Text + "', '" + userLastName_txt.Text + "', '"
                    + userEmail_txt.Text + "', '" + userType_txt.Text + "')";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
        }
    }
}
