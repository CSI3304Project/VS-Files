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
    public partial class HomeConsumer : Form
    {
        private int countTags = 0;
        private List<string> listTags = new List<string>();
        public HomeConsumer()
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

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            countTags = 0;
            foreach (object itemChecked in chkboxlistTags.CheckedItems)
            {
                
                countTags++;
            }
            

            try
            {
                string sqlSearchImages = "SELECT * FROM tblImageTags";
                SqlCommand tagCommand = new SqlCommand(sqlSearchImages);
                SqlConnection conn = new SqlConnection(@"Server=(local)\;Integrated Security=True;MultipleActiveResultSets=true;Database=ImageBaseDataBase");
                conn.Open();
                tagCommand.Connection = conn;
                SqlDataReader dataTags = tagCommand.ExecuteReader();
                Dictionary<int, int> imageTagCount = new Dictionary<int,int>();

                foreach (string tag in listTags)
                {
                    tagCommand = new SqlCommand("SELECT * FROM tblImageTags WHERE imgtagTagName='" + tag + "'");
                    tagCommand.Connection = conn;
                    dataTags = tagCommand.ExecuteReader();


                    imageTagCount = new Dictionary<int, int>();
                    while (dataTags.Read())
                    {
                        
                        if (imageTagCount.ContainsKey(dataTags.GetInt32(0)) == true)
                        {
                            imageTagCount[dataTags.GetInt32(0)]++;
                        }
                        else
                        {
                            imageTagCount.Add(dataTags.GetInt32(0), 1);
                        }
                    }
                }


                SqlCommand imageCommand = new SqlCommand("SELECT * FROM tblImage WHERE imgImageID = " + 0001);
                imageCommand.Connection = conn;
                SqlDataReader dataResult = imageCommand.ExecuteReader();

                comboBox1.Items.Clear();

                foreach (KeyValuePair<int, int> entry in imageTagCount)
                {
                    if (entry.Value == countTags)
                    {
                        imageCommand = new SqlCommand("SELECT * FROM tblImage WHERE imgImageID = '" + entry.Key + "'");
                        imageCommand.Connection = conn;
                        dataResult = imageCommand.ExecuteReader();
                        while (dataResult.Read())
                        {
                            comboBox1.Items.Add(dataResult.GetString(1));
                        }
                    }
                }


                

                comboBox1.Refresh();

                foreach (int i in chkboxlistTags.CheckedIndices)
                {
                    chkboxlistTags.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
        }

        private void chkboxlistTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            countTags++;
            listTags.Add(chkboxlistTags.SelectedItem.ToString());
        }
    }
}
