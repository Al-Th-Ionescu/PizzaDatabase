
namespace BazeDeDate
{
    partial class Client_prev
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
            this.label3 = new System.Windows.Forms.Label();
            this.ClientCheck = new System.Windows.Forms.CheckBox();
            this.ClientBox = new System.Windows.Forms.TextBox();
            this.TelefonBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TestClient = new System.Windows.Forms.TextBox();
            this.TestTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IDSHOW = new System.Windows.Forms.Label();
            this.ClientTest = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 106);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Faceti o comanda!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Txt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1203, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1179, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Daca ati mai comandat de la noi, va rugam sa introduceti codul primit la efectuar" +
    "ea primei comenzi si numarul de telefon!";
            // 
            // ClientCheck
            // 
            this.ClientCheck.AutoSize = true;
            this.ClientCheck.Location = new System.Drawing.Point(64, 201);
            this.ClientCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientCheck.Name = "ClientCheck";
            this.ClientCheck.Size = new System.Drawing.Size(145, 21);
            this.ClientCheck.TabIndex = 2;
            this.ClientCheck.Text = "Am mai comandat!";
            this.ClientCheck.UseVisualStyleBackColor = true;
            this.ClientCheck.CheckedChanged += new System.EventHandler(this.ClientCheck_CheckedChanged);
            // 
            // ClientBox
            // 
            this.ClientBox.Location = new System.Drawing.Point(64, 279);
            this.ClientBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.ReadOnly = true;
            this.ClientBox.Size = new System.Drawing.Size(220, 22);
            this.ClientBox.TabIndex = 3;
            // 
            // TelefonBox
            // 
            this.TelefonBox.Location = new System.Drawing.Point(64, 353);
            this.TelefonBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TelefonBox.Name = "TelefonBox";
            this.TelefonBox.ReadOnly = true;
            this.TelefonBox.Size = new System.Drawing.Size(220, 22);
            this.TelefonBox.TabIndex = 3;
            this.TelefonBox.TextChanged += new System.EventHandler(this.TelefonBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(180, 578);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(815, 68);
            this.label6.TabIndex = 5;
            this.label6.Text = "CONTINUA SPRE COMANDA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TestClient
            // 
            this.TestClient.Location = new System.Drawing.Point(491, 279);
            this.TestClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TestClient.Name = "TestClient";
            this.TestClient.ReadOnly = true;
            this.TestClient.Size = new System.Drawing.Size(168, 22);
            this.TestClient.TabIndex = 3;
            this.TestClient.Visible = false;
            // 
            // TestTelefon
            // 
            this.TestTelefon.Location = new System.Drawing.Point(491, 353);
            this.TestTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TestTelefon.Name = "TestTelefon";
            this.TestTelefon.ReadOnly = true;
            this.TestTelefon.Size = new System.Drawing.Size(133, 22);
            this.TestTelefon.TabIndex = 3;
            this.TestTelefon.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(59, 400);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Am uitat codul!";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 423);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(429, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "(pentru a recupera codul trebuie sa introduceti numarul de telefon)";
            // 
            // IDSHOW
            // 
            this.IDSHOW.AutoSize = true;
            this.IDSHOW.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDSHOW.Location = new System.Drawing.Point(485, 249);
            this.IDSHOW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDSHOW.Name = "IDSHOW";
            this.IDSHOW.Size = new System.Drawing.Size(170, 31);
            this.IDSHOW.TabIndex = 8;
            this.IDSHOW.Text = "ID-ul dvs este:";
            this.IDSHOW.Visible = false;
            // 
            // ClientTest
            // 
            this.ClientTest.AutoSize = true;
            this.ClientTest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientTest.Location = new System.Drawing.Point(655, 249);
            this.ClientTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientTest.Name = "ClientTest";
            this.ClientTest.Size = new System.Drawing.Size(23, 31);
            this.ClientTest.TabIndex = 9;
            this.ClientTest.Text = "-";
            this.ClientTest.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 27);
            this.label9.TabIndex = 10;
            this.label9.Text = "Inapoi";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Client_prev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 720);
            this.Controls.Add(this.ClientTest);
            this.Controls.Add(this.IDSHOW);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TestTelefon);
            this.Controls.Add(this.TelefonBox);
            this.Controls.Add(this.TestClient);
            this.Controls.Add(this.ClientBox);
            this.Controls.Add(this.ClientCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Client_prev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client_prev";
            this.Load += new System.EventHandler(this.Client_prev_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ClientCheck;
        private System.Windows.Forms.TextBox ClientBox;
        private System.Windows.Forms.TextBox TelefonBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TestClient;
        private System.Windows.Forms.TextBox TestTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label IDSHOW;
        private System.Windows.Forms.Label ClientTest;
        private System.Windows.Forms.Label label9;
    }
}