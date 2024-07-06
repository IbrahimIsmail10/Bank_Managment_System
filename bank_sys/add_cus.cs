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
    public partial class add_cus : Form
    {
        public add_cus()
        {
            InitializeComponent();
            DisplayCust();
            Reset();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-Q93NFMPQ;Initial Catalog=Bank;Integrated Security=True");

        
        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_cus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.bankDataSet.Customer);

        }

        private void DisplayCust()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer", Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CUSTDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            SSn.Text = "";
            Frist.Text = "";
            Last.Text = "";
            Addr.Text = "";
            phone.Text = "";
            Gender.SelectedIndex = -1;
            bid.Text = "";
            birth.Text = "";
        }
        private void Submitbtn_Click(object sender, EventArgs e)
        {
            if(Frist.Text=="" || Last.Text == "" || phone.Text =="" || Addr.Text =="" || SSn.Text == "" || Gender.SelectedIndex == -1 || bid.Text == "" || birth.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    
                    SqlCommand cmd = new SqlCommand("INSERT INTO Customer values('"+ SSn.Text + "','" + Frist.Text + "','"+Last.Text+"','"+phone.Text+"','"+Addr.Text+"','"+Gender.SelectedItem.ToString()+"','"+birth.Text+"','"+bid.Text+"')",Con);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Successfully!!");
                    Con.Close();
                    Reset();
                    DisplayCust();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            if (Frist.Text == "" || Last.Text == "" || phone.Text == "" || Addr.Text == "" || SSn.Text == "" || Gender.SelectedIndex == -1 || bid.Text == "" || birth.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else { 
                string query = "Delete from Customer where SSN= '" + SSn.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                try
                {
                    Con.Open();
                    cmd.ExecuteReader();
                    MessageBox.Show("successfully Customer Deleted", "user information");
                    Con.Close();
                    Reset();
                    DisplayCust();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
            
        }
       

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Frist.Text == "" || Last.Text == "" || phone.Text == "" || Addr.Text == "" || SSn.Text == "" || Gender.SelectedIndex == -1 || bid.Text == "" || birth.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand ("UPDATE Customer set Fname=@AF ,Lname=@AL ,phone=@AP ,Address= @AD ,sex= @AG ,Bdate=@AB,B_ID=@AI where SSN = @AS",Con);
                    cmd.Parameters.AddWithValue("@AS", SSn.Text);
                    cmd.Parameters.AddWithValue("@AF", Frist.Text);
                    cmd.Parameters.AddWithValue("@AL", Last.Text);
                    cmd.Parameters.AddWithValue("@AP", phone.Text);
                    cmd.Parameters.AddWithValue("@AD", Addr.Text);
                    cmd.Parameters.AddWithValue("@AG", Gender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AB", birth.Text);
                    cmd.Parameters.AddWithValue("@AI", bid.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated Successfully!!");
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

        private void birth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void boxx_Click(object sender, EventArgs e)
        {
            emp_menu frm = new emp_menu();
            frm.Show();
            this.Hide();
        }

        

        private void CUSTDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CUSTDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                CUSTDGV.CurrentRow.Selected = true;
                SSn.Text = CUSTDGV.Rows[e.RowIndex].Cells["SSN"].FormattedValue.ToString();
                Frist.Text = CUSTDGV.Rows[e.RowIndex].Cells["Fname"].FormattedValue.ToString();
                Last.Text = CUSTDGV.Rows[e.RowIndex].Cells["Lname"].FormattedValue.ToString();
                Addr.Text = CUSTDGV.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                bid.Text = CUSTDGV.Rows[e.RowIndex].Cells["B_ID"].FormattedValue.ToString();
                birth.Text = CUSTDGV.Rows[e.RowIndex].Cells["Bdate"].FormattedValue.ToString();
                phone.Text = CUSTDGV.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString();
                Gender.SelectedItem = CUSTDGV.Rows[e.RowIndex].Cells["sex"].FormattedValue.ToString();

            }
        }
    }
}
