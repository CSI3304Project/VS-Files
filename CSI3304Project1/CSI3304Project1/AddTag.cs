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
    public partial class AddTag : Form
    {
        public AddTag()
        {
            InitializeComponent();
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnAddTag_Click(object sender, EventArgs e)
        {
            try
            {
                String inputTag = txtboxTag.Text;
                inputTag = inputTag.ToLower();

                string sqlSearchTags = "SELECT * FROM tblTags";
                SqlConnection conn = new SqlConnection(@"Server=(local);Integrated Security=True;MultipleActiveResultSets=true;Database=ImageBaseDataBase");
                conn.Open();
                SqlCommand command = new SqlCommand(sqlSearchTags);
                command.Connection = conn;

                SqlDataReader dataReader = command.ExecuteReader();

                bool duplicate = false;
                while (dataReader.Read())
                {
                    if (dataReader.GetString(0) == inputTag)
                    {
                        duplicate = true;
                    }
                }
                dataReader.Close();
                conn.Close();

                if (duplicate == true)
                {
                    MessageBox.Show("This tag already exists", "Error");
                }
                else
                {
                    String sqlInsertTag = "INSERT INTO tblTags VALUES ('" + inputTag + "')";
                    conn.Open();
                    command = new SqlCommand(sqlInsertTag);
                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Tag added");
                    AddImage newImage = new AddImage();
                    newImage.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Could not connect to database");
            }
        }
    }
}
