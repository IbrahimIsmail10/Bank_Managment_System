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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-Q93NFMPQ;Initial Catalog=Bank;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Rolecb.SelectedIndex == -1)
            {
                MessageBox.Show("Select the Role");
            }
            else if (Rolecb.SelectedIndex == 0)
            {
                if (UnameTb.Text == "" || passwordTb.Text == "")
                {
                    MessageBox.Show("Enter username and password of admin");
                }

                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (*)  FROM Admin_ where UserName='" + UnameTb.Text + "' and password = '" + passwordTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1" )
                    {
                        MessageBox.Show("Login successfully!!");
                        manue frm1 = new manue();
                        frm1.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Information");
                        UnameTb.Text = "";
                        passwordTb.Text = "";
                        Rolecb.SelectedIndex = -1;
                    }
                    Con.Close();
                }
            }
            else if (Rolecb.SelectedIndex == 1)
            {
                if (UnameTb.Text == "" || passwordTb.Text == "")
                {
                    MessageBox.Show("Enter username and password of Employee");
                }

                else
                {
                    Con.Open();
                    SqlDataAdapter sda1 = new SqlDataAdapter("SELECT COUNT (*)  FROM  Emp_Login where username='" + UnameTb.Text + "' and pass = '" + passwordTb.Text + "'", Con);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    if (dt1.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("Login successfully!!");
                        emp_menu frm2 = new emp_menu();
                        frm2.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Information");
                        UnameTb.Text = "";
                        passwordTb.Text = "";
                        Rolecb.SelectedIndex = -1;
                    }
                    Con.Close();
                }
            }
            else
            {
                if (UnameTb.Text == "" || passwordTb.Text == "")
                {
                    MessageBox.Show("Enter username and password of Customer");
                }

                else
                {
                    Con.Open();
                    SqlDataAdapter sda2 = new SqlDataAdapter("SELECT COUNT (*)  FROM  Account where Account_number='" + UnameTb.Text + "' and SSN = '" + passwordTb.Text + "'", Con);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    if (dt2.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("Login successfully!!");
                        cust_loans frm3 = new cust_loans();
                        frm3.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Information");
                        UnameTb.Text = "";
                        passwordTb.Text = "";
                        Rolecb.SelectedIndex = -1;
                    }
                    Con.Close();
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void label6_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            passwordTb.Text = "";
            Rolecb.SelectedIndex = -1;
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
