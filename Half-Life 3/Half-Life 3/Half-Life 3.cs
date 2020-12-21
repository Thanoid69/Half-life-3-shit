using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Half_Life_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lol = new lol();
            lol.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // dialog request
            DialogResult result = MessageBox.Show("Are you sure?", "Quit", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var lol = new Options();
            lol.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
