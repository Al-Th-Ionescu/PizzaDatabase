
namespace BazeDeDate
{
    partial class Venit_mediu
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
            this.VMediu = new System.Windows.Forms.DataGridView();
            this.jud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_oras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sal_med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalMedMIN = new System.Windows.Forms.TextBox();
            this.JudBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrasBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMediu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENIT MEDIU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Txt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(745, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // VMediu
            // 
            this.VMediu.AllowUserToAddRows = false;
            this.VMediu.AllowUserToDeleteRows = false;
            this.VMediu.AllowUserToResizeColumns = false;
            this.VMediu.AllowUserToResizeRows = false;
            this.VMediu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VMediu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jud,
            this.num_oras,
            this.sal_med});
            this.VMediu.Location = new System.Drawing.Point(423, 138);
            this.VMediu.Name = "VMediu";
            this.VMediu.ReadOnly = true;
            this.VMediu.RowHeadersVisible = false;
            this.VMediu.Size = new System.Drawing.Size(307, 330);
            this.VMediu.TabIndex = 1;
            // 
            // jud
            // 
            this.jud.HeaderText = "Judet";
            this.jud.Name = "jud";
            this.jud.ReadOnly = true;
            // 
            // num_oras
            // 
            this.num_oras.HeaderText = "Oras";
            this.num_oras.Name = "num_oras";
            this.num_oras.ReadOnly = true;
            // 
            // sal_med
            // 
            this.sal_med.HeaderText = "Salariu Mediu";
            this.sal_med.Name = "sal_med";
            this.sal_med.ReadOnly = true;
            // 
            // SalMedMIN
            // 
            this.SalMedMIN.Location = new System.Drawing.Point(48, 317);
            this.SalMedMIN.Name = "SalMedMIN";
            this.SalMedMIN.Size = new System.Drawing.Size(190, 20);
            this.SalMedMIN.TabIndex = 2;
            // 
            // JudBox
            // 
            this.JudBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JudBox.FormattingEnabled = true;
            this.JudBox.Location = new System.Drawing.Point(48, 205);
            this.JudBox.Name = "JudBox";
            this.JudBox.Size = new System.Drawing.Size(190, 21);
            this.JudBox.TabIndex = 3;
            this.JudBox.SelectedIndexChanged += new System.EventHandler(this.JudBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Judet";
            // 
            // OrasBox
            // 
            this.OrasBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrasBox.FormattingEnabled = true;
            this.OrasBox.Location = new System.Drawing.Point(48, 263);
            this.OrasBox.Name = "OrasBox";
            this.OrasBox.Size = new System.Drawing.Size(190, 21);
            this.OrasBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Oras";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salariu mediu minim";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(270, 280);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 48);
            this.button2.TabIndex = 40;
            this.button2.Text = "Curata ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(88, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(274, 66);
            this.button4.TabIndex = 39;
            this.button4.Text = "INAPOI LA MENIU";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(270, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 48);
            this.button1.TabIndex = 38;
            this.button1.Text = "Afiseaza";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Venit_mediu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 585);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrasBox);
            this.Controls.Add(this.JudBox);
            this.Controls.Add(this.SalMedMIN);
            this.Controls.Add(this.VMediu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venit_mediu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venit_mediu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VMediu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView VMediu;
        private System.Windows.Forms.DataGridViewTextBoxColumn jud;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_oras;
        private System.Windows.Forms.DataGridViewTextBoxColumn sal_med;
        private System.Windows.Forms.TextBox SalMedMIN;
        private System.Windows.Forms.ComboBox JudBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OrasBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}