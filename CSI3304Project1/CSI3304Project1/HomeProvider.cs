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
    public partial class HomeProvider : Form
    {
        public HomeProvider()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddImage newImage = new AddImage();
            newImage.Show();
            this.Hide();
        }
    }
}
