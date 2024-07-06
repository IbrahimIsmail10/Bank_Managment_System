
namespace bank_sys
{
    partial class mange_loans
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LAMT = new System.Windows.Forms.Label();
            this.BID = new System.Windows.Forms.TextBox();
            this.LNUM = new System.Windows.Forms.Label();
            this.EMP_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LOAN_NUM = new System.Windows.Forms.TextBox();
            this.LOANDGV = new System.Windows.Forms.DataGridView();
            this.aCCNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new bank_sys.BankDataSet();
            this.loanTableAdapter = new bank_sys.BankDataSetTableAdapters.LoanTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.acceptbtn = new System.Windows.Forms.Button();
            this.rejectbtn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOANDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bank_sys.Properties.Resources.setting;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LAMT
            // 
            this.LAMT.AutoSize = true;
            this.LAMT.Font = new System.Drawing.Font("Arial", 12F);
            this.LAMT.ForeColor = System.Drawing.Color.White;
            this.LAMT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LAMT.Location = new System.Drawing.Point(378, 201);
            this.LAMT.Margin = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.LAMT.Name = "LAMT";
            this.LAMT.Size = new System.Drawing.Size(97, 23);
            this.LAMT.TabIndex = 70;
            this.LAMT.Text = "Branch ID";
            // 
            // BID
            // 
            this.BID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BID.Font = new System.Drawing.Font("Arial", 13.2F);
            this.BID.Location = new System.Drawing.Point(382, 230);
            this.BID.Margin = new System.Windows.Forms.Padding(4);
            this.BID.Name = "BID";
            this.BID.Size = new System.Drawing.Size(242, 26);
            this.BID.TabIndex = 69;
            // 
            // LNUM
            // 
            this.LNUM.AutoSize = true;
            this.LNUM.Font = new System.Drawing.Font("Arial", 12F);
            this.LNUM.ForeColor = System.Drawing.Color.White;
            this.LNUM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LNUM.Location = new System.Drawing.Point(69, 244);
            this.LNUM.Margin = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.LNUM.Name = "LNUM";
            this.LNUM.Size = new System.Drawing.Size(123, 23);
            this.LNUM.TabIndex = 68;
            this.LNUM.Text = "Employee ID";
            // 
            // EMP_ID
            // 
            this.EMP_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EMP_ID.Font = new System.Drawing.Font("Arial", 13.2F);
            this.EMP_ID.Location = new System.Drawing.Point(73, 273);
            this.EMP_ID.Margin = new System.Windows.Forms.Padding(4);
            this.EMP_ID.Name = "EMP_ID";
            this.EMP_ID.Size = new System.Drawing.Size(242, 26);
            this.EMP_ID.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(232, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 33);
            this.label6.TabIndex = 75;
            this.label6.Text = "Manage Loans";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(69, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 77;
            this.label1.Text = "Loan Number";
            // 
            // LOAN_NUM
            // 
            this.LOAN_NUM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LOAN_NUM.Font = new System.Drawing.Font("Arial", 13.2F);
            this.LOAN_NUM.Location = new System.Drawing.Point(73, 177);
            this.LOAN_NUM.Margin = new System.Windows.Forms.Padding(4);
            this.LOAN_NUM.Name = "LOAN_NUM";
            this.LOAN_NUM.Size = new System.Drawing.Size(242, 26);
            this.LOAN_NUM.TabIndex = 76;
            // 
            // LOANDGV
            // 
            this.LOANDGV.AutoGenerateColumns = false;
            this.LOANDGV.BackgroundColor = System.Drawing.Color.Silver;
            this.LOANDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LOANDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aCCNUMDataGridViewTextBoxColumn,
            this.lnumberDataGridViewTextBoxColumn,
            this.lAmountDataGridViewTextBoxColumn,
            this.lTypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.LOANDGV.DataSource = this.loanBindingSource;
            this.LOANDGV.Location = new System.Drawing.Point(3, 464);
            this.LOANDGV.Name = "LOANDGV";
            this.LOANDGV.RowHeadersWidth = 51;
            this.LOANDGV.RowTemplate.Height = 24;
            this.LOANDGV.Size = new System.Drawing.Size(721, 208);
            this.LOANDGV.TabIndex = 78;
            this.LOANDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LOANDGV_CellContentClick);
            // 
            // aCCNUMDataGridViewTextBoxColumn
            // 
            this.aCCNUMDataGridViewTextBoxColumn.DataPropertyName = "ACC_NUM";
            this.aCCNUMDataGridViewTextBoxColumn.HeaderText = "ACCOUNT_NUMBER";
            this.aCCNUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCNUMDataGridViewTextBoxColumn.Name = "aCCNUMDataGridViewTextBoxColumn";
            this.aCCNUMDataGridViewTextBoxColumn.Width = 125;
            // 
            // lnumberDataGridViewTextBoxColumn
            // 
            this.lnumberDataGridViewTextBoxColumn.DataPropertyName = "L_number";
            this.lnumberDataGridViewTextBoxColumn.HeaderText = "L_number";
            this.lnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnumberDataGridViewTextBoxColumn.Name = "lnumberDataGridViewTextBoxColumn";
            this.lnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // lAmountDataGridViewTextBoxColumn
            // 
            this.lAmountDataGridViewTextBoxColumn.DataPropertyName = "L_Amount";
            this.lAmountDataGridViewTextBoxColumn.HeaderText = "LOAN_Amount";
            this.lAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lAmountDataGridViewTextBoxColumn.Name = "lAmountDataGridViewTextBoxColumn";
            this.lAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // lTypeDataGridViewTextBoxColumn
            // 
            this.lTypeDataGridViewTextBoxColumn.DataPropertyName = "L_Type";
            this.lTypeDataGridViewTextBoxColumn.HeaderText = "LOAN_Type";
            this.lTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lTypeDataGridViewTextBoxColumn.Name = "lTypeDataGridViewTextBoxColumn";
            this.lTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "Loan";
            this.loanBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::bank_sys.Properties.Resources.bank_icon;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(314, 68);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // acceptbtn
            // 
            this.acceptbtn.BackColor = System.Drawing.Color.DarkGreen;
            this.acceptbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.acceptbtn.FlatAppearance.BorderSize = 0;
            this.acceptbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.acceptbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptbtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptbtn.ForeColor = System.Drawing.Color.White;
            this.acceptbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.acceptbtn.Location = new System.Drawing.Point(80, 359);
            this.acceptbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.acceptbtn.Name = "acceptbtn";
            this.acceptbtn.Size = new System.Drawing.Size(240, 45);
            this.acceptbtn.TabIndex = 81;
            this.acceptbtn.Text = "Accept";
            this.acceptbtn.UseVisualStyleBackColor = false;
            this.acceptbtn.Click += new System.EventHandler(this.acceptbtn_Click);
            // 
            // rejectbtn
            // 
            this.rejectbtn.BackColor = System.Drawing.Color.Maroon;
            this.rejectbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rejectbtn.FlatAppearance.BorderSize = 0;
            this.rejectbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rejectbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rejectbtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectbtn.ForeColor = System.Drawing.Color.White;
            this.rejectbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rejectbtn.Location = new System.Drawing.Point(367, 359);
            this.rejectbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rejectbtn.Name = "rejectbtn";
            this.rejectbtn.Size = new System.Drawing.Size(240, 45);
            this.rejectbtn.TabIndex = 82;
            this.rejectbtn.Text = "Reject";
            this.rejectbtn.UseVisualStyleBackColor = false;
            this.rejectbtn.Click += new System.EventHandler(this.rejectbtn_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = global::bank_sys.Properties.Resources.exit1;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(700, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(24, 26);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 83;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mange_loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(723, 675);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rejectbtn);
            this.Controls.Add(this.acceptbtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LOANDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LOAN_NUM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LAMT);
            this.Controls.Add(this.BID);
            this.Controls.Add(this.LNUM);
            this.Controls.Add(this.EMP_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mange_loans";
            this.Text = "mange_loans";
            this.Load += new System.EventHandler(this.mange_loans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOANDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LAMT;
        private System.Windows.Forms.TextBox BID;
        private System.Windows.Forms.Label LNUM;
        private System.Windows.Forms.TextBox EMP_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LOAN_NUM;
        private System.Windows.Forms.DataGridView LOANDGV;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private BankDataSetTableAdapters.LoanTableAdapter loanTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button acceptbtn;
        private System.Windows.Forms.Button rejectbtn;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}