using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Hotel_Registration_Application
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0KI0O9G\\SQLEXPRESS;Initial Catalog=AydınHotel;Integrated Security=True");

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminLogin where Username=@Useername AND Password=@Paassword";
                SqlParameter prm1 = new SqlParameter("Useername", txtUsername.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Paassword", txtPassword.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    FrmMainPage fr = new FrmMainPage();
                    this.Hide();
                    fr.Show();
                }

               
            }

            catch(Exception)
            {
                MessageBox.Show("Username or password is wrong !");
            }
            
        }

    }
}
