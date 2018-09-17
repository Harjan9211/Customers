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
    public partial class Form2 : Form
         
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A20D9TK;Initial Catalog=Customers;Integrated Security=True");
        private int b;

        public Form2()
        {
            InitializeComponent();
        }

        private void moviesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moviesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.customersDataSet.Movies);

        }

        private void button2_home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from Movies where MovieID ='" + textBox1.Text + "'";//which cmd
            cmd.ExecuteNonQuery();//excecute
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            moviesDataGridView.DataSource = dt;
            connection.Close();
        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (yearTextBox.Text !="")
            {
                DateTime dateNow = DateTime.Now;
                string cast = dateNow.ToString("yyyy");
                int a = Convert.ToInt32(yearTextBox.Text);
                int sum = a - b;
                if (a - b > 1)
                {
                    rental_CostTextBox.Text = "2.0000";

                }
                else
                {
                    rental_CostTextBox.Text = "5.0000";
                }
            
            }
        }
    }
}
