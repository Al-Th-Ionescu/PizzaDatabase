
namespace BazeDeDate
{
    partial class Caut
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
            this.cmdbox = new System.Windows.Forms.ComboBox();
            this.clientbox = new System.Windows.Forms.ComboBox();
            this.pizzabox = new System.Windows.Forms.ComboBox();
            this.magazinbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CautareGrid = new System.Windows.Forms.DataGridView();
            this.oras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_comanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CautareGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 105);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Txt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1363, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 59);
            this.label2.TabIndex = 8;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cautare Avansata";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdbox
            // 
            this.cmdbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdbox.FormattingEnabled = true;
            this.cmdbox.Location = new System.Drawing.Point(52, 249);
            this.cmdbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdbox.Name = "cmdbox";
            this.cmdbox.Size = new System.Drawing.Size(159, 24);
            this.cmdbox.TabIndex = 1;
            this.cmdbox.SelectedIndexChanged += new System.EventHandler(this.cmdbox_SelectedIndexChanged);
            // 
            // clientbox
            // 
            this.clientbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientbox.FormattingEnabled = true;
            this.clientbox.Location = new System.Drawing.Point(52, 324);
            this.clientbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientbox.Name = "clientbox";
            this.clientbox.Size = new System.Drawing.Size(159, 24);
            this.clientbox.TabIndex = 1;
            // 
            // pizzabox
            // 
            this.pizzabox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pizzabox.FormattingEnabled = true;
            this.pizzabox.Location = new System.Drawing.Point(52, 469);
            this.pizzabox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pizzabox.Name = "pizzabox";
            this.pizzabox.Size = new System.Drawing.Size(159, 24);
            this.pizzabox.TabIndex = 1;
            // 
            // magazinbox
            // 
            this.magazinbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.magazinbox.FormattingEnabled = true;
            this.magazinbox.Location = new System.Drawing.Point(52, 399);
            this.magazinbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.magazinbox.Name = "magazinbox";
            this.magazinbox.Size = new System.Drawing.Size(159, 24);
            this.magazinbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cod comanda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Magazin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 434);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pizza";
            // 
            // CautareGrid
            // 
            this.CautareGrid.AllowUserToAddRows = false;
            this.CautareGrid.AllowUserToDeleteRows = false;
            this.CautareGrid.AllowUserToResizeColumns = false;
            this.CautareGrid.AllowUserToResizeRows = false;
            this.CautareGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CautareGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oras,
            this.maga,
            this.pizza,
            this.cod_comanda,
            this.id_client,
            this.nume,
            this.prenume});
            this.CautareGrid.Location = new System.Drawing.Point(275, 182);
            this.CautareGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CautareGrid.Name = "CautareGrid";
            this.CautareGrid.ReadOnly = true;
            this.CautareGrid.RowHeadersVisible = false;
            this.CautareGrid.RowHeadersWidth = 51;
            this.CautareGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CautareGrid.RowTemplate.Height = 24;
            this.CautareGrid.Size = new System.Drawing.Size(1120, 466);
            this.CautareGrid.TabIndex = 12;
            this.CautareGrid.Visible = false;
            this.CautareGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CautareGrid_CellContentClick);
            // 
            // oras
            // 
            this.oras.HeaderText = "Oras";
            this.oras.MinimumWidth = 6;
            this.oras.Name = "oras";
            this.oras.ReadOnly = true;
            this.oras.Width = 125;
            // 
            // maga
            // 
            this.maga.HeaderText = "Magazin";
            this.maga.MinimumWidth = 6;
            this.maga.Name = "maga";
            this.maga.ReadOnly = true;
            this.maga.Width = 125;
            // 
            // pizza
            // 
            this.pizza.HeaderText = "Pizza";
            this.pizza.MinimumWidth = 6;
            this.pizza.Name = "pizza";
            this.pizza.ReadOnly = true;
            this.pizza.Width = 125;
            // 
            // cod_comanda
            // 
            this.cod_comanda.HeaderText = "Cod Comanda";
            this.cod_comanda.MinimumWidth = 6;
            this.cod_comanda.Name = "cod_comanda";
            this.cod_comanda.ReadOnly = true;
            this.cod_comanda.Width = 125;
            // 
            // id_client
            // 
            this.id_client.HeaderText = "ID Client";
            this.id_client.MinimumWidth = 6;
            this.id_client.Name = "id_client";
            this.id_client.ReadOnly = true;
            this.id_client.Width = 125;
            // 
            // nume
            // 
            this.nume.HeaderText = "Nume";
            this.nume.MinimumWidth = 6;
            this.nume.Name = "nume";
            this.nume.ReadOnly = true;
            this.nume.Width = 125;
            // 
            // prenume
            // 
            this.prenume.HeaderText = "Prenume";
            this.prenume.MinimumWidth = 6;
            this.prenume.Name = "prenume";
            this.prenume.ReadOnly = true;
            this.prenume.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(72, 530);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 59);
            this.button1.TabIndex = 32;
            this.button1.Text = "CAUTA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(46, 613);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 59);
            this.button2.TabIndex = 33;
            this.button2.Text = "GOLITI CRITERIILE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(591, 656);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(365, 81);
            this.button4.TabIndex = 34;
            this.button4.Text = "INAPOI LA MENIU";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(-4, 782);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1436, 68);
            this.panel2.TabIndex = 35;
            // 
            // Caut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 815);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CautareGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.magazinbox);
            this.Controls.Add(this.pizzabox);
            this.Controls.Add(this.clientbox);
            this.Controls.Add(this.cmdbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Caut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caut";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CautareGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdbox;
        private System.Windows.Forms.ComboBox clientbox;
        private System.Windows.Forms.ComboBox pizzabox;
        private System.Windows.Forms.ComboBox magazinbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView CautareGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn oras;
        private System.Windows.Forms.DataGridViewTextBoxColumn maga;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_comanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
    }
}