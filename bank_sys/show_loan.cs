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
    public partial class show_loan : Form
    {
        public show_loan()
        {
            InitializeComponent();
        }
        string ConnectionString = @"Data Source=LAPTOP-Q93NFMPQ;Initial Catalog=Bank;Integrated Security=True";
        private void Displaybtn_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Loan", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DGV2.DataSource = dt;
                Con.Close();
            }
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
