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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Registration_Application
{
    public partial class FrmBills : Form
    {
        public FrmBills()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0KI0O9G\\SQLEXPRESS;Initial Catalog=AydınHotel;Integrated Security=True");

        private void data2()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Bills", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["Electricity"].ToString();
                add.SubItems.Add(read["Water"].ToString());
                add.SubItems.Add(read["Internet"].ToString());
                add.SubItems.Add(read["Gas"].ToString());
               

                listView1.Items.Add(add);

            }

            baglanti.Close();
        }
            private void btnSaveBills_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Bills(Electricity,Water,Internet,Gas) values('" + txtElectric.Text + "','" + txtWater.Text + "','" + txtInternet.Text + "','" + txtGas.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            data2();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmBills_Load(object sender, EventArgs e)
        {
            data2();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Foods_Click(object sender, EventArgs e)
        {

        }
    }
}
