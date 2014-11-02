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
    public partial class EditUser : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public EditUser()
        {
            InitializeComponent();
            FillCombo();
        }
        void FillCombo()
        {
            try
            {
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                con.Open();
                //Check username
                cmd = new SqlCommand("SELECT * FROM tblUser ;");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string username = dr["userUserName"].ToString();
                    usersearch.Items.Add(username);
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
        }

        private void btnLoginHome_Click_1(object sender, EventArgs e)
        {
            Login Check = new Login();
            Check.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usersearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                con.Open();
                //Check username
                cmd = new SqlCommand("SELECT * FROM tblUser WHERE userUsername='" + usersearch.Text + "';");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string firstname = dr["userFirstName"].ToString();
                    string lastname = dr["userLastName"].ToString();
                    string password = dr["userPassword"].ToString();
                    string email = dr["userEmail"].ToString();
                    string usertype = dr["userType"].ToString();
                    FirstName.Text = firstname;
                    LastName.Text = lastname;
                    Password.Text = password;
                    Email.Text = email;
                    UserType.Text = usertype;
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                con.Open();
                //Check username
                cmd = new SqlCommand("UPDATE tblUser SET userFirstName='" + FirstName.Text + "', userLastName='" + LastName.Text +
                    "', userPassword='" + Password.Text + "', userEmail='" + Email.Text + "', userType='" + UserType.Text + "' WHERE userUsername='" + usersearch.Text + "';");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
            MessageBox.Show("Success... User was updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                con.Open();
                //Check username
                cmd = new SqlCommand("DELETE FROM tblUser WHERE userUsername='" + usersearch.Text + "';");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
            MessageBox.Show("Success... User was updated");
        }
    }
}
