
namespace BazeDeDate
{
    partial class Pizza_comandata
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MagazinBox1 = new System.Windows.Forms.ComboBox();
            this.OrasBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PizzaBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CodComanda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cantitate = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PizzaComandataGrid = new System.Windows.Forms.DataGridView();
            this.iDMAGAZINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPIZZADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCOMANDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTITATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIZZACOMANDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet8 = new BazeDeDate.DataSet8();
            this.pIZZA_COMANDATATableAdapter = new BazeDeDate.DataSet8TableAdapters.PIZZA_COMANDATATableAdapter();
            this.SecretBox = new System.Windows.Forms.TextBox();
            this.SecretPizza = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.ord = new System.Windows.Forms.ComboBox();
            this.items = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaComandataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIZZACOMANDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 79);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Txt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(807, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 47);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pizza Comandata";
            // 
            // MagazinBox1
            // 
            this.MagazinBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MagazinBox1.FormattingEnabled = true;
            this.MagazinBox1.Location = new System.Drawing.Point(31, 201);
            this.MagazinBox1.Name = "MagazinBox1";
            this.MagazinBox1.Size = new System.Drawing.Size(206, 21);
            this.MagazinBox1.TabIndex = 12;
            this.MagazinBox1.SelectedIndexChanged += new System.EventHandler(this.MagazinBox1_SelectedIndexChanged);
            // 
            // OrasBox
            // 
            this.OrasBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrasBox.FormattingEnabled = true;
            this.OrasBox.Location = new System.Drawing.Point(31, 137);
            this.OrasBox.Name = "OrasBox";
            this.OrasBox.Size = new System.Drawing.Size(206, 21);
            this.OrasBox.TabIndex = 13;
            this.OrasBox.SelectedIndexChanged += new System.EventHandler(this.OrasBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Magazin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Oras";
            // 
            // PizzaBox
            // 
            this.PizzaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PizzaBox.FormattingEnabled = true;
            this.PizzaBox.Location = new System.Drawing.Point(31, 267);
            this.PizzaBox.Name = "PizzaBox";
            this.PizzaBox.Size = new System.Drawing.Size(206, 21);
            this.PizzaBox.TabIndex = 12;
            this.PizzaBox.SelectedIndexChanged += new System.EventHandler(this.PizzaBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Magazin";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pizza";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cod Comanda";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // CodComanda
            // 
            this.CodComanda.Location = new System.Drawing.Point(31, 328);
            this.CodComanda.Name = "CodComanda";
            this.CodComanda.Size = new System.Drawing.Size(206, 20);
            this.CodComanda.TabIndex = 14;
            this.CodComanda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cantitate";
            this.label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // Cantitate
            // 
            this.Cantitate.Location = new System.Drawing.Point(31, 391);
            this.Cantitate.Name = "Cantitate";
            this.Cantitate.Size = new System.Drawing.Size(206, 20);
            this.Cantitate.TabIndex = 14;
            this.Cantitate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(23, 502);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(274, 66);
            this.button4.TabIndex = 34;
            this.button4.Text = "INAPOI LA MENIU";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(220, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 48);
            this.button3.TabIndex = 33;
            this.button3.Text = "STERGE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(114, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 48);
            this.button2.TabIndex = 32;
            this.button2.Text = "EDITEAZA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(23, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 48);
            this.button1.TabIndex = 31;
            this.button1.Text = "ADAUGA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(-1, 607);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 36);
            this.panel2.TabIndex = 35;
            // 
            // PizzaComandataGrid
            // 
            this.PizzaComandataGrid.AllowUserToAddRows = false;
            this.PizzaComandataGrid.AllowUserToDeleteRows = false;
            this.PizzaComandataGrid.AllowUserToResizeColumns = false;
            this.PizzaComandataGrid.AllowUserToResizeRows = false;
            this.PizzaComandataGrid.AutoGenerateColumns = false;
            this.PizzaComandataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PizzaComandataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMAGAZINDataGridViewTextBoxColumn,
            this.iDPIZZADataGridViewTextBoxColumn,
            this.cODCOMANDADataGridViewTextBoxColumn,
            this.cANTITATEDataGridViewTextBoxColumn});
            this.PizzaComandataGrid.DataSource = this.pIZZACOMANDATABindingSource;
            this.PizzaComandataGrid.Location = new System.Drawing.Point(372, 111);
            this.PizzaComandataGrid.Name = "PizzaComandataGrid";
            this.PizzaComandataGrid.ReadOnly = true;
            this.PizzaComandataGrid.RowHeadersVisible = false;
            this.PizzaComandataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PizzaComandataGrid.Size = new System.Drawing.Size(406, 337);
            this.PizzaComandataGrid.TabIndex = 36;
            this.PizzaComandataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDMAGAZINDataGridViewTextBoxColumn
            // 
            this.iDMAGAZINDataGridViewTextBoxColumn.DataPropertyName = "ID_MAGAZIN";
            this.iDMAGAZINDataGridViewTextBoxColumn.HeaderText = "ID_MAGAZIN";
            this.iDMAGAZINDataGridViewTextBoxColumn.Name = "iDMAGAZINDataGridViewTextBoxColumn";
            this.iDMAGAZINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDPIZZADataGridViewTextBoxColumn
            // 
            this.iDPIZZADataGridViewTextBoxColumn.DataPropertyName = "ID_PIZZA";
            this.iDPIZZADataGridViewTextBoxColumn.HeaderText = "ID_PIZZA";
            this.iDPIZZADataGridViewTextBoxColumn.Name = "iDPIZZADataGridViewTextBoxColumn";
            this.iDPIZZADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODCOMANDADataGridViewTextBoxColumn
            // 
            this.cODCOMANDADataGridViewTextBoxColumn.DataPropertyName = "COD_COMANDA";
            this.cODCOMANDADataGridViewTextBoxColumn.HeaderText = "COD_COMANDA";
            this.cODCOMANDADataGridViewTextBoxColumn.Name = "cODCOMANDADataGridViewTextBoxColumn";
            this.cODCOMANDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cANTITATEDataGridViewTextBoxColumn
            // 
            this.cANTITATEDataGridViewTextBoxColumn.DataPropertyName = "CANTITATE";
            this.cANTITATEDataGridViewTextBoxColumn.HeaderText = "CANTITATE";
            this.cANTITATEDataGridViewTextBoxColumn.Name = "cANTITATEDataGridViewTextBoxColumn";
            this.cANTITATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pIZZACOMANDATABindingSource
            // 
            this.pIZZACOMANDATABindingSource.DataMember = "PIZZA_COMANDATA";
            this.pIZZACOMANDATABindingSource.DataSource = this.dataSet8;
            // 
            // dataSet8
            // 
            this.dataSet8.DataSetName = "DataSet8";
            this.dataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pIZZA_COMANDATATableAdapter
            // 
            this.pIZZA_COMANDATATableAdapter.ClearBeforeFill = true;
            // 
            // SecretBox
            // 
            this.SecretBox.Location = new System.Drawing.Point(517, 566);
            this.SecretBox.Name = "SecretBox";
            this.SecretBox.ReadOnly = true;
            this.SecretBox.Size = new System.Drawing.Size(100, 20);
            this.SecretBox.TabIndex = 37;
            this.SecretBox.Visible = false;
            // 
            // SecretPizza
            // 
            this.SecretPizza.Location = new System.Drawing.Point(516, 527);
            this.SecretPizza.Name = "SecretPizza";
            this.SecretPizza.ReadOnly = true;
            this.SecretPizza.Size = new System.Drawing.Size(100, 20);
            this.SecretPizza.TabIndex = 37;
            this.SecretPizza.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(272, 229);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 48);
            this.button5.TabIndex = 38;
            this.button5.Text = "CURATA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ord
            // 
            this.ord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ord.FormattingEnabled = true;
            this.ord.Items.AddRange(new object[] {
            "asc",
            "desc"});
            this.ord.Location = new System.Drawing.Point(652, 473);
            this.ord.Margin = new System.Windows.Forms.Padding(2);
            this.ord.Name = "ord";
            this.ord.Size = new System.Drawing.Size(92, 21);
            this.ord.TabIndex = 41;
            this.ord.SelectedIndexChanged += new System.EventHandler(this.ord_SelectedIndexChanged);
            // 
            // items
            // 
            this.items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.items.FormattingEnabled = true;
            this.items.Items.AddRange(new object[] {
            "id_magazin",
            "id_pizza",
            "cod_comanda",
            "cantitate"});
            this.items.Location = new System.Drawing.Point(532, 473);
            this.items.Margin = new System.Windows.Forms.Padding(2);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(92, 21);
            this.items.TabIndex = 40;
            this.items.SelectedIndexChanged += new System.EventHandler(this.items_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(424, 471);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Sortare dupa";
            // 
            // Pizza_comandata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 643);
            this.Controls.Add(this.ord);
            this.Controls.Add(this.items);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.SecretPizza);
            this.Controls.Add(this.SecretBox);
            this.Controls.Add(this.PizzaComandataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cantitate);
            this.Controls.Add(this.CodComanda);
            this.Controls.Add(this.PizzaBox);
            this.Controls.Add(this.MagazinBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrasBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pizza_comandata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza_comandata";
            this.Load += new System.EventHandler(this.Pizza_comandata_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaComandataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIZZACOMANDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MagazinBox1;
        private System.Windows.Forms.ComboBox OrasBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PizzaBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CodComanda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Cantitate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView PizzaComandataGrid;
        private DataSet8 dataSet8;
        private System.Windows.Forms.BindingSource pIZZACOMANDATABindingSource;
        private DataSet8TableAdapters.PIZZA_COMANDATATableAdapter pIZZA_COMANDATATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMAGAZINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPIZZADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCOMANDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTITATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox SecretBox;
        private System.Windows.Forms.TextBox SecretPizza;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox ord;
        private System.Windows.Forms.ComboBox items;
        private System.Windows.Forms.Label label9;
    }
}