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
    public partial class mange_loans : Form
    {
        public mange_loans()
        {
            InitializeComponent();
            Reset();
            
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-Q93NFMPQ;Initial Catalog=Bank;Integrated Security=True");


        private void mange_loans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet.Loan' table. You can move, or remove it, as needed.
            this.loanTableAdapter.Fill(this.bankDataSet.Loan);

        }

        private void LOANDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (LOANDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                LOANDGV.CurrentRow.Selected = true;
                LOAN_NUM.Text = LOANDGV.Rows[e.RowIndex].Cells["L_number"].FormattedValue.ToString();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset()
        {
            LOAN_NUM.Text = "";
            EMP_ID.Text = "";
            BID.Text = "";

        }
      
        private void acceptbtn_Click(object sender, EventArgs e)
        {
            if (LOAN_NUM.Text == "" || EMP_ID.Text == ""  || BID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Loan set EMP_ID = @AE ,B_ID = @AB ,status = 'Accepted' where L_number ='"+LOAN_NUM.Text+"'", Con);
                    cmd.Parameters.AddWithValue("@AE", EMP_ID.Text);
                    cmd.Parameters.AddWithValue("@AB", BID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accepted!!");
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void rejectbtn_Click(object sender, EventArgs e)
        {
            if (LOAN_NUM.Text == "" || EMP_ID.Text == "" || BID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Loan set EMP_ID = @AE ,B_ID = @AB ,status = 'Rejected' where L_number ='" + LOAN_NUM.Text + "'", Con);
                    cmd.Parameters.AddWithValue("@AE", EMP_ID.Text);
                    cmd.Parameters.AddWithValue("@AB", BID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rejected!!");
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            emp_menu frm = new emp_menu();
            frm.Show();
            this.Hide();
        }
    }
}
