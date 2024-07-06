
namespace bank_sys
{
    partial class show_loan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Displaybtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EXIT = new System.Windows.Forms.PictureBox();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.boxx = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxx)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 425);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bank_sys.Properties.Resources.setting;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(24, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Displaybtn
            // 
            this.Displaybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Displaybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Displaybtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Displaybtn.FlatAppearance.BorderSize = 0;
            this.Displaybtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Displaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Displaybtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Displaybtn.ForeColor = System.Drawing.Color.White;
            this.Displaybtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Displaybtn.Location = new System.Drawing.Point(268, 360);
            this.Displaybtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Displaybtn.Name = "Displaybtn";
            this.Displaybtn.Size = new System.Drawing.Size(410, 52);
            this.Displaybtn.TabIndex = 35;
            this.Displaybtn.Text = "Diplay";
            this.Displaybtn.UseVisualStyleBackColor = false;
            this.Displaybtn.Click += new System.EventHandler(this.Displaybtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(382, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Show Loan list";
            // 
            // EXIT
            // 
            this.EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXIT.Image = global::bank_sys.Properties.Resources.exit1;
            this.EXIT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EXIT.Location = new System.Drawing.Point(894, 0);
            this.EXIT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(24, 26);
            this.EXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EXIT.TabIndex = 37;
            this.EXIT.TabStop = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // DGV2
            // 
            this.DGV2.BackgroundColor = System.Drawing.Color.Silver;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Location = new System.Drawing.Point(98, 105);
            this.DGV2.Name = "DGV2";
            this.DGV2.RowHeadersWidth = 51;
            this.DGV2.RowTemplate.Height = 24;
            this.DGV2.Size = new System.Drawing.Size(820, 230);
            this.DGV2.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(110, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 2, 3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 65;
            this.label9.Text = "Setting";
            // 
            // boxx
            // 
            this.boxx.BackColor = System.Drawing.SystemColors.MenuBar;
            this.boxx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxx.Image = global::bank_sys.Properties.Resources.ddd;
            this.boxx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boxx.Location = new System.Drawing.Point(123, 30);
            this.boxx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxx.Name = "boxx";
            this.boxx.Size = new System.Drawing.Size(28, 33);
            this.boxx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxx.TabIndex = 64;
            this.boxx.TabStop = false;
            this.boxx.Click += new System.EventHandler(this.boxx_Click);
            // 
            // show_loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(919, 425);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxx);
            this.Controls.Add(this.DGV2);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Displaybtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "show_loan";
            this.Text = "show_loan";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Displaybtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox EXIT;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox boxx;
    }
}