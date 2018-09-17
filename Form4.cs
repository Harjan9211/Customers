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
    public partial class Form4 : Form
        
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A20D9TK;Initial Catalog=Customers;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void rentedMoviesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rentedMoviesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.RentedMovies' table. You can move, or remove it, as needed.
            this.rentedMoviesTableAdapter.Fill(this.customersDataSet.RentedMovies);

        }

        private void rentedMoviesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            cmd.CommandText = "select *from RentedMovies where RMID ='" + textBox1.Text + "'";//which cmd
            cmd.ExecuteNonQuery();//excecute
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            rentedMoviesDataGridView.DataSource = dt;
            connection.Close();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
