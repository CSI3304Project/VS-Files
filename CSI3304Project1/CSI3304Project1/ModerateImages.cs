using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSI3304Project1
{
    public partial class ModerateImages : Form
    {
        public ModerateImages()
        {
            InitializeComponent();
<<<<<<< HEAD
=======
            FillCombo();
        }

        //unmoderated images combo box
        void FillCombo()
        {
            int count = 0;
            try
            {
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                con.Open();
                //Search Image ID
                cmd = new SqlCommand("SELECT * FROM tblImage WHERE imgStatus= 'unmoderated';");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    count = count + 1;
                    string image = dr["imgImageID"].ToString();
                    imagesearch.Items.Add(image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
            if (count == 0)
            {
                MessageBox.Show("Sorry, there are not images to moderate at the moment");
            }

        }


        private void btnLoginHome_Click(object sender, EventArgs e)
        {
            Login Check = new Login();
            Check.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                con.Open();
                //Search Image ID
                cmd = new SqlCommand("UPDATE tblImage SET imgStatus= 'approved' WHERE imgImageID ='" + imagesearch.Text + "';");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string image = dr["imgImageName"].ToString();
                    imagesearch.Items.Add(image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
            MessageBox.Show("Image Approved");
        }

        private void imagesearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                con.Open();
                //Search Image ID
                cmd = new SqlCommand("SELECT * FROM tblImageTags WHERE imgtagImageID='" + imagesearch.Text + "';");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string tags = dr["imgtagTagName"].ToString();
                    tagslist.Items.Add(tags);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                con.Open();
                //Search Image ID
                cmd = new SqlCommand("UPDATE tblImage SET imgStatus= 'rejected' WHERE imgImageID ='" + imagesearch.Text + "';");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string image = dr["imgImageName"].ToString();
                    imagesearch.Items.Add(image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
            MessageBox.Show("Image rejected");
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> origin/master
=======
>>>>>>> parent of 5d79f46... Moderate Image. Added tag functions
=======
>>>>>>> parent of 5d79f46... Moderate Image. Added tag functions
        }
    }
}
