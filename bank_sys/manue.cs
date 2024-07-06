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
    public partial class manue : Form
    {
        public manue()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void box1_Click(object sender, EventArgs e)
        {
            Add_branch frm = new Add_branch();
            frm.Show();
            this.Hide();
        }

        private void box2_Click(object sender, EventArgs e)
        {
            add_bank frm = new add_bank();
            frm.Show();
            this.Hide();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void box3_Click(object sender, EventArgs e)
        {
            add_emp frm = new add_emp();
            frm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void box4_Click(object sender, EventArgs e)
        {
            new_signup frm4 = new new_signup();
            frm4.Show();
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
