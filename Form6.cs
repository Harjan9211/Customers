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

namespace Customers
{
    public partial class Form6 : Form

    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A20D9TK;Initial Catalog=Customers;Integrated Security=True");
        


        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CustlDFK, COUNT(CustlDFK) AS CNT FROM RentedMovies GROUP BY CustlDFK HAVING COUNT(CustlDFK) >= 2";
            cmd.ExecuteNonQuery();
            count = (int)cmd.ExecuteScalar();
            textBox1.Text = count.ToString();
            con.Close();
        }

        private void button2_display_Click(object sender, EventArgs e)
        {
            int count;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MovielDFK, COUNT(MovielDFK) AS CNT FROM RentedMovies GROUP BY MovielDFK HAVING COUNT(MovielDFK) >= 2";
            cmd.ExecuteNonQuery();
            count = (int)cmd.ExecuteScalar();
            textBox2.Text = count.ToString();
            con.Close();
        }
    }
}
