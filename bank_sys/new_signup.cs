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

namespace bank_sys
{
    public partial class new_signup : Form
    {
        public new_signup()
        {
            InitializeComponent();
            Reset();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-Q93NFMPQ;Initial Catalog=Bank;Integrated Security=True");
        private void Reset()
        {
            username.Text = "";
            password.Text = "";
            EMP_ID.Text = "";
            
        }

        private void Submitbtn7_Click(object sender, EventArgs e)
        {
            if (EMP_ID.Text == "" || username.Text == "" || password.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Emp_Login values('" + username.Text + "','" + password.Text + "','" + EMP_ID.Text + "' )", Con);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Created Successfully!!");
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void boxx_Click(object sender, EventArgs e)
        {
            manue frm = new manue();
            frm.Show();
            this.Hide();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
