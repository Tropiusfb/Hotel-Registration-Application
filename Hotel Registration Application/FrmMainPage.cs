using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Registration_Application
{
    public partial class FrmMainPage : Form
    {
        public FrmMainPage()
        {
            InitializeComponent();
        }

        

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            FrmNewCustomer frm = new FrmNewCustomer();
            frm.ShowDialog();
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            FrmCustomers frm = new FrmCustomers();
            frm.ShowDialog();
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            FrmRooms frm = new FrmRooms();
            frm.ShowDialog();
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            FrmStock frm = new FrmStock();
            frm.ShowDialog();
        }

        private void ıconButton6_Click(object sender, EventArgs e)
        {
            FrmIncomeExpenditure frm = new FrmIncomeExpenditure();
            frm.ShowDialog();
        }

        private void ıconButton7_Click(object sender, EventArgs e)
        {
            FrmBills frm = new FrmBills();
            frm.ShowDialog();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
