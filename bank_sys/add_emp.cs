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
    public partial class add_emp : Form
    {
        public add_emp()
        {
            InitializeComponent();
            DisplayEMP();
            Reset();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-Q93NFMPQ;Initial Catalog=Bank;Integrated Security=True");
        private void DisplayEMP()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employee", Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EMPDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            salary.Text = "";
            Frist.Text = "";
            Last.Text = "";
            Addr.Text = "";
            id.Text = "";
            Gender.SelectedIndex = -1;
            bid.Text = "";
            birth.Text = "";
        }
        private void Submitbtn5_Click(object sender, EventArgs e)
        {

            if (Frist.Text == "" || Last.Text == "" || salary.Text == "" || Addr.Text == "" || id.Text == "" || Gender.SelectedIndex == -1 || bid.Text == "" || birth.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Employee values('" + Frist.Text + "','" + Last.Text + "','" + salary.Text + "','" + birth.Text + "','" + id.Text + "','" + Gender.SelectedItem.ToString() + "','" +Addr.Text + "','" + bid.Text + "')", Con);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added Successfully!!");
                    Con.Close();
                    Reset();
                    DisplayEMP();
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
