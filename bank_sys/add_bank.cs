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
using System.Diagnostics;

namespace bank_sys
{
    public partial class add_bank : Form
    {
        public add_bank()
        {
            InitializeComponent();
            Reset();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-Q93NFMPQ;Initial Catalog=Bank;Integrated Security=True");
        private void Reset()
        {
            BA.Text = "";
            BC.Text = "";
            BN.Text = "";
        }

        private void Applybtn3_Click(object sender, EventArgs e)
        {
            if (BA.Text == "" || BC.Text == "" || BN.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Bank Values ('" + BN.Text + "','" + BC.Text + "','" + BA.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bank Added Successfully!!");
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boxx_Click(object sender, EventArgs e)
        {
            manue frm = new manue();
            frm.Show();
            this.Hide();
        }
    }
}

  
    



