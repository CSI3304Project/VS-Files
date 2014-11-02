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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditUser Check = new EditUser();
            Check.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddUser().Show();
            this.Hide();
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


        private void button5_Click(object sender, EventArgs e)
        {
            SearchUser Check = new SearchUser();
            Check.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddImage newImage = new AddImage();
            newImage.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModerateImages moderateimg = new ModerateImages();
            moderateimg.Show();
            this.Hide();
        }
    }
}
