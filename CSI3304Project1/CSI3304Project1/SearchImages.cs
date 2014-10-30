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
    public partial class SearchImages : Form
    {
        public SearchImages()
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

        private void bttnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
