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
    public partial class Add_branch : Form
    {
        public Add_branch()
        {
            InitializeComponent();
            Reset();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-Q93NFMPQ;Initial Catalog=Bank;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_branch_Load(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            b_id.Text = "";
            Bcode.Text = "";
            BAddres.Text = "";
      
        }
        private void Applybtn_Click(object sender, EventArgs e)
        {
            if (b_id.Text == "" ||Bcode.Text =="" || BAddres.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Branch Values ('" + BAddres.Text + "','" + b_id.Text + "','" + Bcode.Text + "')",Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Branch Added Successfully!!");
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
    }
}
