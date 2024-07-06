using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_sys
{
    public partial class emp_menu : Form
    {
        public emp_menu()
        {
            InitializeComponent();
        }

        private void box2_Click(object sender, EventArgs e)
        {
            add_cus frm = new add_cus();
            frm.Show();
            this.Hide();
        }

        private void box3_Click(object sender, EventArgs e)
        {
            show_cus frm = new show_cus();
            frm.Show();
            this.Hide();
        }

        private void box4_Click(object sender, EventArgs e)
        {
            show_loan frm = new show_loan();
            frm.Show();
            this.Hide();
        }
        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void box1_Click(object sender, EventArgs e)
        {
            add_acc frm = new add_acc();
            frm.Show();
            this.Hide();
        }

        private void box5_Click(object sender, EventArgs e)
        {
            mange_loans frm = new mange_loans();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            login frm5 = new login();
            frm5.Show();
            this.Hide();
        }
    }
}
