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
using System.IO;

namespace CSI3304Project1
{
    public partial class AddImage : Form
    {
        private string imgLoc;
        public AddImage()
        {
            InitializeComponent();

            try
            {
                string sqlCheckBoxQuery = "SELECT * FROM tblTags";
                SqlConnection conn = new SqlConnection(@"Server=(local)\;Integrated Security=True;MultipleActiveResultSets=true;Database=ImageBaseDataBase");
                conn.Open();
                SqlCommand command = new SqlCommand(sqlCheckBoxQuery);
                command.Connection = conn;

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    chkboxlistTags.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddImage_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void bttnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagePath = new OpenFileDialog();
            DialogResult result = imagePath.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                imgLoc = imagePath.FileName.ToString();
                txtboxImageFIleAddress.Text = imagePath.FileName.ToString();
                pictureBox1.ImageLocation = txtboxImageFIleAddress.Text;
            }
        }
          
        private void bttnAddImage_Click(object sender, EventArgs e)
        {
            int checkedItems = 0;
            foreach (object itemChecked in chkboxlistTags.CheckedItems)
            {
                checkedItems++; 
            }
            checkedItems++;
            

            if (txtboxImageFIleAddress.Text == "" || txtboxName.Text == "")
            {
                MessageBox.Show("Please ensure that you have entered a name and selected an image to upload", "Error");
            }
            else if (checkedItems == 0)
            {
                MessageBox.Show("At least one tag must be selected", "Error");
            }
            else
            {
                try
                {
                    string sqlImageSelectQuery = "SELECT imgImageID FROM tblImage ";
                    SqlConnection conn = new SqlConnection(@"Server=(local);Integrated Security=True;MultipleActiveResultSets=true;Database=ImageBaseDataBase");
                    conn.Open();
                    SqlCommand selectCommand = new SqlCommand(sqlImageSelectQuery);
                    selectCommand.Connection = conn;

                    SqlDataReader result = selectCommand.ExecuteReader();

                    int nextImageID = 0;

                    while (result.Read())
                    {
                        nextImageID = result.GetInt32(0);
                    }

                    nextImageID++;

                    string[] imageTags = new string[checkedItems];
                    int i = 0;

                    foreach (object itemChecked in chkboxlistTags.CheckedItems)
                    {
                        imageTags[i] = itemChecked.ToString();
                        i++;
                    }

                    string sqlInsertTagsQuery = "INSERT INTO tblImageTags VALUES ('" + nextImageID + "', '" + imageTags[i] + "')";
                    SqlCommand insertTagsCommand = new SqlCommand();
                    insertTagsCommand.Connection = conn;
                    
                    for (i = 0; i < imageTags.Length; i++)
                    {
                        sqlInsertTagsQuery = sqlInsertTagsQuery = "INSERT INTO tblImageTags VALUES ('" + nextImageID + "', '" + imageTags[i] + "')";
                        insertTagsCommand = new SqlCommand(sqlInsertTagsQuery);
                        insertTagsCommand.Connection = conn;
                        insertTagsCommand.ExecuteNonQuery();
                    }

                    string date = DateTime.Now.ToString("dd/mm/yyyy");

                    byte[] img = null;
                    FileStream fs = new FileStream(txtboxImageFIleAddress.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    string sqlInsertImageQuery = "INSERT INTO tblImage VALUES ('" + nextImageID + "', '" + txtboxName.Text + "', '" + date + "', '" + Login.getUser() + "', 'unmoderated', @imgImageFile)";
                    SqlCommand insertCommand = new SqlCommand(sqlInsertImageQuery);
                    insertCommand.Connection = conn;
                    insertCommand.Parameters.Add(new SqlParameter("imgImageFile",img));
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("UploadedImage added successfully!", "Success");
                    AddImage newWindow = new AddImage();
                    newWindow.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Could not connect to database");
                }
            }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            switch (Login.getUserType())
            {
                case "admin":
                    HomeAdmin homeAdmin = new HomeAdmin();
                    homeAdmin.Show();
                    this.Close();
                    break;
                case "moderator":
                    HomeModerator homeMod = new HomeModerator();
                    homeMod.Show();
                    this.Close();
                    break;
                case "consumer":
                    HomeConsumer homeConsumer = new HomeConsumer();
                    homeConsumer.Show();
                    this.Close();
                    break;
                case "provider":
                    HomeProvider homeProvider = new HomeProvider();
                    homeProvider.Show();
                    this.Close();
                    break;
            }
        }

        private void bttnAddTag_Click(object sender, EventArgs e)
        {
            AddTag newTag = new AddTag();
            newTag.Show();
            this.Close();
        }
    }
}
