
namespace BazeDeDate
{
    partial class Pizza
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
            this.ID_PIZZA = new System.Windows.Forms.TextBox();
            this.NUME = new System.Windows.Forms.TextBox();
            this.PRET = new System.Windows.Forms.TextBox();
            this.BLAT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PizzaGridView = new System.Windows.Forms.DataGridView();
            this.iDPIZZADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIZZABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new BazeDeDate.DataSet3();
            this.pIZZATableAdapter = new BazeDeDate.DataSet3TableAdapters.PIZZATableAdapter();
            this.ord = new System.Windows.Forms.ComboBox();
            this.items = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIZZABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 88);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Txt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(771, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIZZA";
            // 
            // ID_PIZZA
            // 
            this.ID_PIZZA.Enabled = false;
            this.ID_PIZZA.Location = new System.Drawing.Point(31, 161);
            this.ID_PIZZA.Name = "ID_PIZZA";
            this.ID_PIZZA.Size = new System.Drawing.Size(278, 20);
            this.ID_PIZZA.TabIndex = 2;
            this.ID_PIZZA.TextChanged += new System.EventHandler(this.ID_PIZZA_TextChanged);
            // 
            // NUME
            // 
            this.NUME.Location = new System.Drawing.Point(31, 223);
            this.NUME.Name = "NUME";
            this.NUME.Size = new System.Drawing.Size(278, 20);
            this.NUME.TabIndex = 3;
            // 
            // PRET
            // 
            this.PRET.Location = new System.Drawing.Point(31, 283);
            this.PRET.Name = "PRET";
            this.PRET.Size = new System.Drawing.Size(278, 20);
            this.PRET.TabIndex = 4;
            // 
            // BLAT
            // 
            this.BLAT.Location = new System.Drawing.Point(31, 339);
            this.BLAT.Name = "BLAT";
            this.BLAT.Size = new System.Drawing.Size(278, 20);
            this.BLAT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID PIZZA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "NUME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "PRET";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "BLAT";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(29, 506);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(274, 66);
            this.button4.TabIndex = 18;
            this.button4.Text = "INAPOI LA MENIU";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(228, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 48);
            this.button3.TabIndex = 17;
            this.button3.Text = "STERGE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(122, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 48);
            this.button2.TabIndex = 16;
            this.button2.Text = "EDITEAZA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(31, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "ADAUGA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Location = new System.Drawing.Point(-11, 619);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 48);
            this.panel2.TabIndex = 19;
            // 
            // PizzaGridView
            // 
            this.PizzaGridView.AllowUserToAddRows = false;
            this.PizzaGridView.AllowUserToDeleteRows = false;
            this.PizzaGridView.AllowUserToResizeColumns = false;
            this.PizzaGridView.AllowUserToResizeRows = false;
            this.PizzaGridView.AutoGenerateColumns = false;
            this.PizzaGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.PizzaGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.PizzaGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.PizzaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PizzaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPIZZADataGridViewTextBoxColumn,
            this.nUMEDataGridViewTextBoxColumn,
            this.pRETDataGridViewTextBoxColumn,
            this.bLATDataGridViewTextBoxColumn});
            this.PizzaGridView.DataSource = this.pIZZABindingSource;
            this.PizzaGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PizzaGridView.Location = new System.Drawing.Point(372, 139);
            this.PizzaGridView.MultiSelect = false;
            this.PizzaGridView.Name = "PizzaGridView";
            this.PizzaGridView.RowHeadersVisible = false;
            this.PizzaGridView.RowHeadersWidth = 51;
            this.PizzaGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PizzaGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PizzaGridView.Size = new System.Drawing.Size(402, 295);
            this.PizzaGridView.TabIndex = 20;
            this.PizzaGridView.VirtualMode = true;
            this.PizzaGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComandaGridView_CellContentClick);
            // 
            // iDPIZZADataGridViewTextBoxColumn
            // 
            this.iDPIZZADataGridViewTextBoxColumn.DataPropertyName = "ID_PIZZA";
            this.iDPIZZADataGridViewTextBoxColumn.HeaderText = "ID_PIZZA";
            this.iDPIZZADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPIZZADataGridViewTextBoxColumn.Name = "iDPIZZADataGridViewTextBoxColumn";
            this.iDPIZZADataGridViewTextBoxColumn.Width = 125;
            // 
            // nUMEDataGridViewTextBoxColumn
            // 
            this.nUMEDataGridViewTextBoxColumn.DataPropertyName = "NUME";
            this.nUMEDataGridViewTextBoxColumn.HeaderText = "NUME";
            this.nUMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nUMEDataGridViewTextBoxColumn.Name = "nUMEDataGridViewTextBoxColumn";
            this.nUMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRETDataGridViewTextBoxColumn
            // 
            this.pRETDataGridViewTextBoxColumn.DataPropertyName = "PRET";
            this.pRETDataGridViewTextBoxColumn.HeaderText = "PRET";
            this.pRETDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRETDataGridViewTextBoxColumn.Name = "pRETDataGridViewTextBoxColumn";
            this.pRETDataGridViewTextBoxColumn.Width = 125;
            // 
            // bLATDataGridViewTextBoxColumn
            // 
            this.bLATDataGridViewTextBoxColumn.DataPropertyName = "BLAT";
            this.bLATDataGridViewTextBoxColumn.HeaderText = "BLAT";
            this.bLATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bLATDataGridViewTextBoxColumn.Name = "bLATDataGridViewTextBoxColumn";
            this.bLATDataGridViewTextBoxColumn.Width = 125;
            // 
            // pIZZABindingSource
            // 
            this.pIZZABindingSource.DataMember = "PIZZA";
            this.pIZZABindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pIZZATableAdapter
            // 
            this.pIZZATableAdapter.ClearBeforeFill = true;
            // 
            // ord
            // 
            this.ord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ord.FormattingEnabled = true;
            this.ord.Items.AddRange(new object[] {
            "asc",
            "desc"});
            this.ord.Location = new System.Drawing.Point(621, 469);
            this.ord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ord.Name = "ord";
            this.ord.Size = new System.Drawing.Size(92, 21);
            this.ord.TabIndex = 30;
            this.ord.SelectedIndexChanged += new System.EventHandler(this.ord_SelectedIndexChanged);
            // 
            // items
            // 
            this.items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.items.FormattingEnabled = true;
            this.items.Items.AddRange(new object[] {
            "id_pizza",
            "nume",
            "pret",
            "blat"});
            this.items.Location = new System.Drawing.Point(501, 469);
            this.items.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(92, 21);
            this.items.TabIndex = 29;
            this.items.SelectedIndexChanged += new System.EventHandler(this.items_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sortare dupa";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(122, 453);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 48);
            this.button5.TabIndex = 41;
            this.button5.Text = "CURATA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 656);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ord);
            this.Controls.Add(this.items);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PizzaGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BLAT);
            this.Controls.Add(this.PRET);
            this.Controls.Add(this.NUME);
            this.Controls.Add(this.ID_PIZZA);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Pizza_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PizzaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIZZABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_PIZZA;
        private System.Windows.Forms.TextBox NUME;
        private System.Windows.Forms.TextBox PRET;
        private System.Windows.Forms.TextBox BLAT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView PizzaGridView;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource pIZZABindingSource;
        private DataSet3TableAdapters.PIZZATableAdapter pIZZATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPIZZADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLATDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox ord;
        private System.Windows.Forms.ComboBox items;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
    }
}