
namespace BazeDeDate
{
    partial class Tot_incasari
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotIncasari = new System.Windows.Forms.DataGridView();
            this.oras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tot_incas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.magazinbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrasBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tot_Min = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotIncasari)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 95);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 68);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Incasari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Txt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1024, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 59);
            this.label2.TabIndex = 9;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TotIncasari
            // 
            this.TotIncasari.AllowUserToAddRows = false;
            this.TotIncasari.AllowUserToDeleteRows = false;
            this.TotIncasari.AllowUserToResizeColumns = false;
            this.TotIncasari.AllowUserToResizeRows = false;
            this.TotIncasari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotIncasari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oras,
            this.magazin,
            this.tot_incas});
            this.TotIncasari.Location = new System.Drawing.Point(456, 170);
            this.TotIncasari.Name = "TotIncasari";
            this.TotIncasari.ReadOnly = true;
            this.TotIncasari.RowHeadersVisible = false;
            this.TotIncasari.RowHeadersWidth = 51;
            this.TotIncasari.RowTemplate.Height = 24;
            this.TotIncasari.Size = new System.Drawing.Size(513, 440);
            this.TotIncasari.TabIndex = 1;
            this.TotIncasari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // oras
            // 
            this.oras.HeaderText = "Oras";
            this.oras.MinimumWidth = 6;
            this.oras.Name = "oras";
            this.oras.ReadOnly = true;
            this.oras.Width = 125;
            // 
            // magazin
            // 
            this.magazin.HeaderText = "Magazin";
            this.magazin.MinimumWidth = 6;
            this.magazin.Name = "magazin";
            this.magazin.ReadOnly = true;
            this.magazin.Width = 125;
            // 
            // tot_incas
            // 
            this.tot_incas.HeaderText = "Total Incasari";
            this.tot_incas.MinimumWidth = 6;
            this.tot_incas.Name = "tot_incas";
            this.tot_incas.ReadOnly = true;
            this.tot_incas.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Magazin";
            // 
            // magazinbox
            // 
            this.magazinbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.magazinbox.FormattingEnabled = true;
            this.magazinbox.Location = new System.Drawing.Point(55, 288);
            this.magazinbox.Name = "magazinbox";
            this.magazinbox.Size = new System.Drawing.Size(159, 24);
            this.magazinbox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Oras";
            // 
            // OrasBox
            // 
            this.OrasBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrasBox.FormattingEnabled = true;
            this.OrasBox.Location = new System.Drawing.Point(55, 204);
            this.OrasBox.Name = "OrasBox";
            this.OrasBox.Size = new System.Drawing.Size(159, 24);
            this.OrasBox.TabIndex = 12;
            this.OrasBox.SelectedIndexChanged += new System.EventHandler(this.OrasBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(295, 226);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 59);
            this.button1.TabIndex = 33;
            this.button1.Text = "Afiseaza";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(52, 420);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(365, 81);
            this.button4.TabIndex = 35;
            this.button4.Text = "INAPOI LA MENIU";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(-2, 674);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 36);
            this.panel2.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(295, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 59);
            this.button2.TabIndex = 37;
            this.button2.Text = "Curata ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tot_Min
            // 
            this.tot_Min.Location = new System.Drawing.Point(55, 369);
            this.tot_Min.Name = "tot_Min";
            this.tot_Min.Size = new System.Drawing.Size(159, 22);
            this.tot_Min.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total minim";
            // 
            // Tot_incasari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 707);
            this.Controls.Add(this.tot_Min);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrasBox);
            this.Controls.Add(this.magazinbox);
            this.Controls.Add(this.TotIncasari);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tot_incasari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tot_incasari";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotIncasari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TotIncasari;
        private System.Windows.Forms.DataGridViewTextBoxColumn oras;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot_incas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox magazinbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OrasBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tot_Min;
        private System.Windows.Forms.Label label4;
    }
}