﻿using System;
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
    public partial class FrmRooms : Form
    {
        public FrmRooms()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0KI0O9G\\SQLEXPRESS;Initial Catalog=AydınHotel;Integrated Security=True");


        private void FrmRooms_Load(object sender, EventArgs e)
        {
            //Room1

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Room101", baglanti);
            SqlDataReader read1 = komut1.ExecuteReader();
            

            while(read1.Read())
            {
                btnOda101.Text = read1["Name"].ToString() + " " + read1["Surname"].ToString();

            }
            baglanti.Close();
            if (btnOda101.Text != "101")
            {
                btnOda101.BackColor= Color.Red;
            }

            //Room2

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Room102", baglanti);
            SqlDataReader read2 = komut2.ExecuteReader();


            while (read2.Read())
            {
                btnOda102.Text = read2["Name"].ToString() + " " + read2["Surname"].ToString();

            }
            baglanti.Close();
            if (btnOda102.Text != "102")
            {
                btnOda102.BackColor = Color.Red;
            }

            //Room3

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Room103", baglanti);
            SqlDataReader read3 = komut3.ExecuteReader();


            while (read3.Read())
            {
                btnOda103.Text = read3["Name"].ToString() + " " + read3["Surname"].ToString();

            }
            baglanti.Close();
            if (btnOda103.Text != "103")
            {
                btnOda103.BackColor = Color.Red;
            }

            //Room4

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Room104", baglanti);
            SqlDataReader read4 = komut4.ExecuteReader();


            while (read4.Read())
            {
                btnOda104.Text = read4["Name"].ToString() + " " + read4["Surname"].ToString();

            }
            baglanti.Close();
            if (btnOda104.Text != "104")
            {
                btnOda104.BackColor = Color.Red;
            }

            //Room 5
            baglanti.Open();
            SqlCommand komut5= new SqlCommand("select * from Room105", baglanti);
            SqlDataReader read5 = komut5.ExecuteReader();


            while (read5.Read())
            {
                btnOda105.Text = read5["Name"].ToString() + " " + read5["Surname"].ToString();

            }
            baglanti.Close();
            if (btnOda105.Text != "105")
            {
                btnOda105.BackColor = Color.Red;
            }

            //Room 106

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Room106", baglanti);
            SqlDataReader read6 = komut6.ExecuteReader();


            while (read6.Read())
            {
                btnOda106.Text = read6["Name"].ToString() + " " + read6["Surname"].ToString();

            }
            baglanti.Close();
            if (btnOda106.Text != "106")
            {
                btnOda106.BackColor = Color.Red;
            }

            //Room107

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Room107", baglanti);
            SqlDataReader read7 = komut7.ExecuteReader();


            while (read7.Read())
            {
                btnOda107.Text = read7["Name"].ToString() + " " + read7["Surname"].ToString();

            }
            baglanti.Close();
            if (btnOda107.Text != "107")
            {
                btnOda107.BackColor = Color.Red;
            }

            //Room 108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Room108", baglanti);
            SqlDataReader read8 = komut8.ExecuteReader();


            while (read8.Read())
            {
                btnOda108.Text = read8["Name"].ToString() + " " + read8["Surname"].ToString();

            }
            baglanti.Close();
            if (btnOda108.Text != "108")
            {
                btnOda108.BackColor = Color.Red;
            }

            //Room 109

            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Room109", baglanti);
            SqlDataReader read9 = komut9.ExecuteReader();


            while (read9.Read())
            {
                btnOda109.Text = read9["Name"].ToString() + " " + read9["Surname"].ToString();

            }
            baglanti.Close();
            if (btnOda109.Text != "109")
            {
                btnOda109.BackColor = Color.Red;
            }


        }



        private void btnOda101_Click(object sender, EventArgs e)
        {

        }

        private void btnOda108_Click(object sender, EventArgs e)
        {

        }
    }
}
