using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customers
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.FormClosed += (s, args) => this.Close();
            fr.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.FormClosed += (s, args) => this.Close();
            fr.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.FormClosed += (s, args) => this.Close();
            fr.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 fr = new Form6();
            fr.FormClosed += (s, args) => this.Close();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
