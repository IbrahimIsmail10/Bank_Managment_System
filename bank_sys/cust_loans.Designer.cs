
namespace bank_sys
{
    partial class cust_loans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.LTYP = new System.Windows.Forms.TextBox();
            this.LAMT = new System.Windows.Forms.Label();
            this.Loan_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ACNUM = new System.Windows.Forms.TextBox();
            this.LNUM = new System.Windows.Forms.Label();
            this.Loan_num = new System.Windows.Forms.TextBox();
            this.Submitbtn1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bankDataSet = new bank_sys.BankDataSet();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanTableAdapter = new bank_sys.BankDataSetTableAdapters.LoanTableAdapter();
            this.bankDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.EXIT = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.takeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(347, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "Loan Type";
            // 
            // LTYP
            // 
            this.LTYP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LTYP.Font = new System.Drawing.Font("Arial", 13.2F);
            this.LTYP.Location = new System.Drawing.Point(351, 189);
            this.LTYP.Margin = new System.Windows.Forms.Padding(4);
            this.LTYP.Name = "LTYP";
            this.LTYP.Size = new System.Drawing.Size(242, 26);
            this.LTYP.TabIndex = 67;
            // 
            // LAMT
            // 
            this.LAMT.AutoSize = true;
            this.LAMT.Font = new System.Drawing.Font("Arial", 12F);
            this.LAMT.ForeColor = System.Drawing.Color.White;
            this.LAMT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LAMT.Location = new System.Drawing.Point(35, 252);
            this.LAMT.Margin = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.LAMT.Name = "LAMT";
            this.LAMT.Size = new System.Drawing.Size(124, 23);
            this.LAMT.TabIndex = 66;
            this.LAMT.Text = "Loan Amount";
            // 
            // Loan_amount
            // 
            this.Loan_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Loan_amount.Font = new System.Drawing.Font("Arial", 13.2F);
            this.Loan_amount.Location = new System.Drawing.Point(39, 281);
            this.Loan_amount.Margin = new System.Windows.Forms.Padding(4);
            this.Loan_amount.Name = "Loan_amount";
            this.Loan_amount.Size = new System.Drawing.Size(242, 26);
            this.Loan_amount.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(347, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 64;
            this.label2.Text = "Account Number";
            // 
            // ACNUM
            // 
            this.ACNUM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ACNUM.Font = new System.Drawing.Font("Arial", 13.2F);
            this.ACNUM.Location = new System.Drawing.Point(351, 281);
            this.ACNUM.Margin = new System.Windows.Forms.Padding(4);
            this.ACNUM.Name = "ACNUM";
            this.ACNUM.Size = new System.Drawing.Size(242, 26);
            this.ACNUM.TabIndex = 63;
            // 
            // LNUM
            // 
            this.LNUM.AutoSize = true;
            this.LNUM.Font = new System.Drawing.Font("Arial", 12F);
            this.LNUM.ForeColor = System.Drawing.Color.White;
            this.LNUM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LNUM.Location = new System.Drawing.Point(35, 151);
            this.LNUM.Margin = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.LNUM.Name = "LNUM";
            this.LNUM.Size = new System.Drawing.Size(127, 23);
            this.LNUM.TabIndex = 62;
            this.LNUM.Text = "Loan Number";
            // 
            // Loan_num
            // 
            this.Loan_num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Loan_num.Font = new System.Drawing.Font("Arial", 13.2F);
            this.Loan_num.Location = new System.Drawing.Point(39, 180);
            this.Loan_num.Margin = new System.Windows.Forms.Padding(4);
            this.Loan_num.Name = "Loan_num";
            this.Loan_num.Size = new System.Drawing.Size(242, 26);
            this.Loan_num.TabIndex = 61;
            // 
            // Submitbtn1
            // 
            this.Submitbtn1.BackColor = System.Drawing.Color.White;
            this.Submitbtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submitbtn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Submitbtn1.FlatAppearance.BorderSize = 0;
            this.Submitbtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Submitbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submitbtn1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submitbtn1.ForeColor = System.Drawing.Color.Black;
            this.Submitbtn1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Submitbtn1.Location = new System.Drawing.Point(150, 388);
            this.Submitbtn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Submitbtn1.Name = "Submitbtn1";
            this.Submitbtn1.Size = new System.Drawing.Size(326, 49);
            this.Submitbtn1.TabIndex = 71;
            this.Submitbtn1.Text = "Request";
            this.Submitbtn1.UseVisualStyleBackColor = false;
            this.Submitbtn1.Click += new System.EventHandler(this.Submitbtn1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(224, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 33);
            this.label6.TabIndex = 73;
            this.label6.Text = "Request Loan";
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "Loan";
            this.loanBindingSource.DataSource = this.bankDataSet;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // bankDataSetBindingSource
            // 
            this.bankDataSetBindingSource.DataSource = this.bankDataSet;
            this.bankDataSetBindingSource.Position = 0;
            // 
            // bankDataSetBindingSource1
            // 
            this.bankDataSetBindingSource1.DataSource = this.bankDataSet;
            this.bankDataSetBindingSource1.Position = 0;
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.White;
            this.EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXIT.Image = global::bank_sys.Properties.Resources.exit1;
            this.EXIT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EXIT.Location = new System.Drawing.Point(639, 4);
            this.EXIT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(20, 23);
            this.EXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EXIT.TabIndex = 74;
            this.EXIT.TabStop = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bank_sys.Properties.Resources.bank_icon;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(295, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cust_loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(661, 507);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Submitbtn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LTYP);
            this.Controls.Add(this.LAMT);
            this.Controls.Add(this.Loan_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ACNUM);
            this.Controls.Add(this.LNUM);
            this.Controls.Add(this.Loan_num);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cust_loans";
            this.Text = "cust_loans";
            this.Load += new System.EventHandler(this.cust_loans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LTYP;
        private System.Windows.Forms.Label LAMT;
        private System.Windows.Forms.TextBox Loan_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ACNUM;
        private System.Windows.Forms.Label LNUM;
        private System.Windows.Forms.TextBox Loan_num;
        private System.Windows.Forms.Button Submitbtn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox EXIT;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private BankDataSetTableAdapters.LoanTableAdapter loanTableAdapter;
        private System.Windows.Forms.BindingSource bankDataSetBindingSource1;
        private System.Windows.Forms.BindingSource bankDataSetBindingSource;
        private System.Windows.Forms.BindingSource takeBindingSource;
    }
}