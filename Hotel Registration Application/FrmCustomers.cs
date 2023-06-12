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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0KI0O9G\\SQLEXPRESS;Initial Catalog=AydınHotel;Integrated Security=True");


        private void showdata()
        {
            
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from NewCustomer", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
              ListViewItem add = new ListViewItem();
                add.Text = read["CustomerID"].ToString();
                add.SubItems.Add(read["Name"].ToString());
                add.SubItems.Add(read["Surname"].ToString());
                add.SubItems.Add(read["Gender"].ToString());
                add.SubItems.Add(read["Phone"].ToString());
                add.SubItems.Add(read["Email"].ToString());
                add.SubItems.Add(read["ID"].ToString());
                add.SubItems.Add(read["RoomNo"].ToString());
                add.SubItems.Add(read["Price"].ToString());
                add.SubItems.Add(read["Entry"].ToString());
                add.SubItems.Add(read["Release"].ToString());

                listView1.Items.Add(add);

            }

            baglanti.Close();

        }
        

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[3].Text;
            msktxtPhone.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtId.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtRoomNumber.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtPrice.Text = listView1.SelectedItems[0].SubItems[8].Text;
            datetimeEntry.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dateTimeRelease.Text = listView1.SelectedItems[0].SubItems[10].Text;



        }   

        private void button1_Click(object sender, EventArgs e)
        {
             showdata(); 
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtRoomNumber.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Room101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                showdata();
            }

            if (txtRoomNumber.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Room102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                showdata();
            }

            if (txtRoomNumber.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Room103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                showdata();
            }

            if (txtRoomNumber.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Room104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                showdata();
            }

            if (txtRoomNumber.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Room105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                showdata();
            }

            if (txtRoomNumber.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Room106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                showdata();
            }

            if (txtRoomNumber.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Room107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                showdata();
            }

            if (txtRoomNumber.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Room108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                showdata();
            }

            if (txtRoomNumber.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Room109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                showdata();
            }
            MessageBox.Show("The customer was checked out of the hotel.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update NewCustomer set Name ='" + txtName.Text + "',Surname='" + txtSurname.Text + "',Gender='" + comboBox2.Text + "',Phone='" + msktxtPhone.Text +"',Email='" +txtMail.Text + "',ID='" +txtId.Text+ "',RoomNo='"+txtRoomNumber.Text+"',Price='"+txtPrice.Text+"',Entry='"+ datetimeEntry.Value.ToString("yyy-MM-dd")+ "',Release='" + dateTimeRelease.Value.ToString("yyy-MM-dd")  + "'where CustomerID = " + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Customer information has been successfully updated.");

        }

        private void datetimeEntry_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from NewCustomer where Name like '%" + textBox1.Text+ "%'" , baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["CustomerID"].ToString();
                add.SubItems.Add(read["Name"].ToString());
                add.SubItems.Add(read["Surname"].ToString());
                add.SubItems.Add(read["Gender"].ToString());
                add.SubItems.Add(read["Phone"].ToString());
                add.SubItems.Add(read["Email"].ToString());
                add.SubItems.Add(read["ID"].ToString());
                add.SubItems.Add(read["RoomNo"].ToString());
                add.SubItems.Add(read["Price"].ToString());
                add.SubItems.Add(read["Entry"].ToString());
                add.SubItems.Add(read["Release"].ToString());

                listView1.Items.Add(add);

            }

            baglanti.Close();
        }
    }
}
