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
    public partial class cust_loans : Form
    {
        public cust_loans()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-Q93NFMPQ;Initial Catalog=Bank;Integrated Security=True");

        private void cust_loans_Load(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            Loan_num.Text = "";
            Loan_amount.Text = "";
            LTYP.Text = "";
            ACNUM.Text = "";
           
        }

        private void Submitbtn1_Click(object sender, EventArgs e)
        {
            if (Loan_amount.Text == "" || LTYP.Text == "" || Loan_num.Text == "" || ACNUM.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Loan(L_number,L_Amount,L_Type,ACC_NUM,status) Values ('" + Loan_num.Text + "','" + Loan_amount.Text + "','" + LTYP.Text + "','"+ACNUM.Text+"','Pending')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Request Done!!");
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
