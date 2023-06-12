using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Hotel_Registration_Application
{
    public partial class FrmIncomeExpenditure : Form
    {
        public FrmIncomeExpenditure()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0KI0O9G\\SQLEXPRESS;Initial Catalog=AydınHotel;Integrated Security=True");


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FrmIncomeExpenditure_Load(object sender, EventArgs e)
        {


            //Total Money

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Price) as total from NewCustomer", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                lblTotalMoney.Text = read["total"].ToString();

            }
            baglanti.Close();

            //Foods

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Food) as total1 from Stock", baglanti);
            SqlDataReader read2 = komut2.ExecuteReader();
            while (read2.Read())
            {
                lblPricesProducts.Text = read2["total1"].ToString();

            }
            baglanti.Close();


            //Drinls

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(Drink) as total2 from Stock", baglanti);
            SqlDataReader read3 = komut3.ExecuteReader();
            while (read3.Read())
            {
                lblPricesProducts2.Text = read3["total2"].ToString();

            }
            baglanti.Close();

            //Electricity

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(Electricity) as total4 from Bills", baglanti);
            SqlDataReader read4 = komut4.ExecuteReader();
            while (read4.Read())
            {
                lblBills.Text = read4["total4"].ToString();

            }
            baglanti.Close();


            //Water

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Water) as total5 from Bills", baglanti);
            SqlDataReader read5 = komut5.ExecuteReader();
            while (read5.Read())
            {
                lblBills2.Text = read5["total5"].ToString();

            }
            baglanti.Close();

            //Internet

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select sum(Internet) as total6 from Bills", baglanti);
            SqlDataReader read6 = komut6.ExecuteReader();
            while (read6.Read())
            {
                lblBills3.Text = read6["total6"].ToString();

            }
            baglanti.Close();

            //Gas

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select sum(Gas) as total7 from Bills", baglanti);
            SqlDataReader read7 = komut7.ExecuteReader();
            while (read7.Read())
            {
                lblBills4.Text = read7["total7"].ToString();

            }
            baglanti.Close();


        }
        

       
        private void button1_Click(object sender, EventArgs e)
        {
            


            //Employee Salaries
            int employee;
            employee = Convert.ToInt16(textBox1.Text);
            lblSalaries.Text = (employee * 8500).ToString();

            int result;
            result = Convert.ToInt32(lblTotalMoney.Text) - Convert.ToInt32(lblSalaries.Text) - Convert.ToInt32(lblPricesProducts.Text) - Convert.ToInt32(lblPricesProducts2.Text) - Convert.ToInt32(lblBills.Text) - Convert.ToInt32(lblBills2.Text) - Convert.ToInt16(lblBills3.Text) - Convert.ToInt32(lblBills4.Text);
            lblResult.Text = result.ToString(); 



        }

        




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
