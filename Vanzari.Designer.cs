
namespace BazeDeDate
{
    partial class Vanzari
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vnz_min = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrasBox = new System.Windows.Forms.ComboBox();
            this.magazinbox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.vanzarigrid = new System.Windows.Forms.DataGridView();
            this.oras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizza_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vanzarigrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-10, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 72);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Txt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(768, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 47);
            this.label2.TabIndex = 9;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vanzari";
            // 
            // vnz_min
            // 
            this.vnz_min.Location = new System.Drawing.Point(26, 295);
            this.vnz_min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vnz_min.Name = "vnz_min";
            this.vnz_min.Size = new System.Drawing.Size(120, 20);
            this.vnz_min.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Oras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Vanzari minim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Magazin";
            // 
            // OrasBox
            // 
            this.OrasBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrasBox.FormattingEnabled = true;
            this.OrasBox.Location = new System.Drawing.Point(26, 161);
            this.OrasBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrasBox.Name = "OrasBox";
            this.OrasBox.Size = new System.Drawing.Size(120, 21);
            this.OrasBox.TabIndex = 39;
            this.OrasBox.SelectedIndexChanged += new System.EventHandler(this.OrasBox_SelectedIndexChanged);
            // 
            // magazinbox
            // 
            this.magazinbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.magazinbox.FormattingEnabled = true;
            this.magazinbox.Location = new System.Drawing.Point(26, 229);
            this.magazinbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.magazinbox.Name = "magazinbox";
            this.magazinbox.Size = new System.Drawing.Size(120, 21);
            this.magazinbox.TabIndex = 40;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(200, 245);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 48);
            this.button2.TabIndex = 46;
            this.button2.Text = "Curata";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(200, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 48);
            this.button1.TabIndex = 45;
            this.button1.Text = "Afiseaza";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(26, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(274, 66);
            this.button4.TabIndex = 47;
            this.button4.Text = "INAPOI LA MENIU";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // vanzarigrid
            // 
            this.vanzarigrid.AllowUserToAddRows = false;
            this.vanzarigrid.AllowUserToDeleteRows = false;
            this.vanzarigrid.AllowUserToResizeColumns = false;
            this.vanzarigrid.AllowUserToResizeRows = false;
            this.vanzarigrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vanzarigrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oras,
            this.mgz,
            this.pizza_v});
            this.vanzarigrid.Location = new System.Drawing.Point(356, 133);
            this.vanzarigrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vanzarigrid.Name = "vanzarigrid";
            this.vanzarigrid.ReadOnly = true;
            this.vanzarigrid.RowHeadersVisible = false;
            this.vanzarigrid.RowHeadersWidth = 51;
            this.vanzarigrid.RowTemplate.Height = 24;
            this.vanzarigrid.Size = new System.Drawing.Size(380, 338);
            this.vanzarigrid.TabIndex = 48;
            this.vanzarigrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vanzarigrid_CellContentClick);
            // 
            // oras
            // 
            this.oras.HeaderText = "Oras";
            this.oras.MinimumWidth = 6;
            this.oras.Name = "oras";
            this.oras.ReadOnly = true;
            this.oras.Width = 125;
            // 
            // mgz
            // 
            this.mgz.HeaderText = "Magazin";
            this.mgz.MinimumWidth = 6;
            this.mgz.Name = "mgz";
            this.mgz.ReadOnly = true;
            this.mgz.Width = 125;
            // 
            // pizza_v
            // 
            this.pizza_v.HeaderText = "Pizza Vanduta";
            this.pizza_v.MinimumWidth = 6;
            this.pizza_v.Name = "pizza_v";
            this.pizza_v.ReadOnly = true;
            this.pizza_v.Width = 125;
            // 
            // Vanzari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 609);
            this.Controls.Add(this.vanzarigrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vnz_min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrasBox);
            this.Controls.Add(this.magazinbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Vanzari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vanzari";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vanzarigrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vnz_min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox OrasBox;
        private System.Windows.Forms.ComboBox magazinbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView vanzarigrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn oras;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgz;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizza_v;
    }
}