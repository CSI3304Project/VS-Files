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
    public partial class ModerateImages : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public ModerateImages()
        {
            InitializeComponent();
            FillCombo();
            FillTags();
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

        void FillList()
        {
            tagslist.Items.Clear();
            existingtags.Items.Clear();
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
                    existingtags.Items.Add(tags);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
        }

        void FillTags()
        {
            try
            {
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                con.Open();
                //Search Image ID
                cmd = new SqlCommand("SELECT * FROM tblTags;");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string tags = dr["tagTagName"].ToString();
                    addtagcombo.Items.Add(tags);
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
                //Search Image ID
                cmd = new SqlCommand("UPDATE tblImage SET imgStatus= 'approved' WHERE imgImageID ='" + imagesearch.Text + "';");
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
            MessageBox.Show("Image Approved");
        }

        private void imagesearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                con.Open();
                //Search Image ID
                cmd = new SqlCommand("SELECT * FROM tblImage WHERE imgImageID ='" + imagesearch.Text + "';");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string image = dr["imgImageName"].ToString();
                    imgname.Text = image;
                    //byte[] visual =(byte[])(dr["imgImageFile"]
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
            FillList();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
            MessageBox.Show("Image rejected");
        }

        private void ModerateImages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imageBaseDataBaseDataSet.tblImageTags' table. You can move, or remove it, as needed.
            this.tblImageTagsTableAdapter.Fill(this.imageBaseDataBaseDataSet.tblImageTags);

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

        private void button3_Click(object sender, EventArgs e)
        {
                int counter = 0;
                try
                {
                    con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                    con.Open();
                    //Search Image ID
                    cmd = new SqlCommand("SELECT * FROM tblImageTags WHERE imgtagImageID='" + imagesearch.Text + "' AND imgtagTagName='" +
                        addtagcombo.Text + "';");
                    cmd.Connection = con;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        counter = counter + 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Could not connect to database");
                }
                if (counter == 0)
                {
                    try
                    {
                        con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                        con.Open();
                        //Search Image ID
                        cmd = new SqlCommand("INSERT INTO tblImageTags (imgtagImageID, imgtagTagName) VALUES ('" + imagesearch.Text + "', '" +
                            addtagcombo.Text + "');");
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
                    MessageBox.Show("Tag has been added to image");
                    FillList();
                }
                else
                {
                    MessageBox.Show("Sorry, that tag already exists");
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                con.Open();
                //Search Image ID
                cmd = new SqlCommand("DELETE FROM tblImageTags WHERE imgtagImageID ='" + imagesearch.Text +
                    "' AND imgtagTagName='" + existingtags.Text + "';");
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
            MessageBox.Show("Tag has been deleted from image");
            FillList();
        }
    }
}
