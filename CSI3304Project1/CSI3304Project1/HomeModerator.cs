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
    public partial class HomeModerator : Form
    {
        Dictionary<int, UploadedImage> images;

        public HomeModerator()
        {
            InitializeComponent();

            images = selectMoreImages();
            MemoryStream ms = new MemoryStream(images[0].getImageFile());
            //pictureBox1.Image = Image.FromStream(ms);
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
            SqlConnection conn = new SqlConnection();
            conn.Open();
            //SqlCommand approveCommand = new SqlCommand("UPDATE 
        }

        private Dictionary<int, UploadedImage> selectMoreImages()
        {
            try
            {
                
                SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=ImageBaseDatabase;Integrated Security=True");
                conn.Open();
                SqlCommand selectCommand = new SqlCommand("SELECT * FROM tblImage WHERE imgStatus='unmoderated'");
                selectCommand.Connection = conn;
                SqlDataReader dataReader = selectCommand.ExecuteReader();

                int i = 0;
                images = new Dictionary<int,UploadedImage>();
                Byte[] b = null;
                while (dataReader.Read())
                {
                    images[i] = new UploadedImage();
                    MessageBox.Show(dataReader.GetString(1));
                    images[i].setImageID(dataReader.GetInt32(0));
                    images[i].setImageName(dataReader.GetString(1));
                    images[i].setUploadDate(dataReader.GetString(2));
                    images[i].setProvider(dataReader.GetString(3));
                    images[i].setStatus(dataReader.GetString(4));
                    b = (byte[])dataReader.GetValue(5);
                    images[i].setImageFile(b);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
            return images;
        }
    }
}
