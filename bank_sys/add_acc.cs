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
    public partial class add_acc : Form
    {
        public add_acc()
        {
            InitializeComponent();
            DisplayCust();
            Reset();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-Q93NFMPQ;Initial Catalog=Bank;Integrated Security=True");
        private void DisplayCust()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Account", Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ACCDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            ssn.Text = "";
            ACNUM.Text = "";
            ACB.Text = "";
            ACTYP.Text = "";
            BID.Text = "";
        }
        private void Submitbtn1_Click(object sender, EventArgs e)
        {

            if (ACNUM.Text == "" || BID.Text == "" || ACTYP.Text == "" || ACB.Text == "" || ssn.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Account values('" + ACNUM.Text + "','" + ACTYP.Text + "','" + ACB.Text + "','" + BID.Text + "','" + ssn.Text + "' )", Con);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Added Successfully!!");
                    Con.Close();
                    Reset();
                    DisplayCust();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void ACCDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boxx_Click(object sender, EventArgs e)
        {
            emp_menu frm = new emp_menu();
            frm.Show();
            this.Hide();
        }
    }
}
