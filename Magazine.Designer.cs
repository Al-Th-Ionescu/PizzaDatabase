
namespace BazeDeDate
{
    partial class Magazine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.id_mag = new System.Windows.Forms.TextBox();
            this.NumeBox = new System.Windows.Forms.TextBox();
            this.NumarStradaBox = new System.Windows.Forms.TextBox();
            this.StradaBox = new System.Windows.Forms.TextBox();
            this.OrasBox = new System.Windows.Forms.ComboBox();
            this.Deschidere = new System.Windows.Forms.DateTimePicker();
            this.MagaGrid = new System.Windows.Forms.DataGridView();
            this.iDMAGAZINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDORASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADESCHIDEREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRSTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAGAZINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new BazeDeDate.DataSet6();
            this.mAGAZINTableAdapter = new BazeDeDate.DataSet6TableAdapters.MAGAZINTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SecretBox = new System.Windows.Forms.TextBox();
            this.ord = new System.Windows.Forms.ComboBox();
            this.items = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MagaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGAZINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 81);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Txt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(939, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magazine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID Magazin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nume Magazin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data Deschiere";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Strada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Numar Strada";
            // 
            // id_mag
            // 
            this.id_mag.Location = new System.Drawing.Point(44, 155);
            this.id_mag.Name = "id_mag";
            this.id_mag.ReadOnly = true;
            this.id_mag.Size = new System.Drawing.Size(206, 20);
            this.id_mag.TabIndex = 3;
            // 
            // NumeBox
            // 
            this.NumeBox.Location = new System.Drawing.Point(43, 270);
            this.NumeBox.Name = "NumeBox";
            this.NumeBox.Size = new System.Drawing.Size(207, 20);
            this.NumeBox.TabIndex = 3;
            // 
            // NumarStradaBox
            // 
            this.NumarStradaBox.Location = new System.Drawing.Point(44, 453);
            this.NumarStradaBox.Name = "NumarStradaBox";
            this.NumarStradaBox.Size = new System.Drawing.Size(206, 20);
            this.NumarStradaBox.TabIndex = 3;
            // 
            // StradaBox
            // 
            this.StradaBox.Location = new System.Drawing.Point(43, 394);
            this.StradaBox.Name = "StradaBox";
            this.StradaBox.Size = new System.Drawing.Size(206, 20);
            this.StradaBox.TabIndex = 3;
            // 
            // OrasBox
            // 
            this.OrasBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrasBox.FormattingEnabled = true;
            this.OrasBox.Location = new System.Drawing.Point(44, 217);
            this.OrasBox.Name = "OrasBox";
            this.OrasBox.Size = new System.Drawing.Size(206, 21);
            this.OrasBox.TabIndex = 6;
            this.OrasBox.SelectedIndexChanged += new System.EventHandler(this.OrasBox_SelectedIndexChanged);
            // 
            // Deschidere
            // 
            this.Deschidere.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Deschidere.Location = new System.Drawing.Point(44, 331);
            this.Deschidere.Name = "Deschidere";
            this.Deschidere.Size = new System.Drawing.Size(207, 20);
            this.Deschidere.TabIndex = 7;
            this.Deschidere.Value = new System.DateTime(2020, 12, 30, 14, 44, 29, 0);
            this.Deschidere.ValueChanged += new System.EventHandler(this.Deschidere_ValueChanged);
            // 
            // MagaGrid
            // 
            this.MagaGrid.AllowUserToAddRows = false;
            this.MagaGrid.AllowUserToDeleteRows = false;
            this.MagaGrid.AllowUserToResizeColumns = false;
            this.MagaGrid.AllowUserToResizeRows = false;
            this.MagaGrid.AutoGenerateColumns = false;
            this.MagaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MagaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMAGAZINDataGridViewTextBoxColumn,
            this.iDORASDataGridViewTextBoxColumn,
            this.nUMEDataGridViewTextBoxColumn,
            this.dATADESCHIDEREDataGridViewTextBoxColumn,
            this.sTRADADataGridViewTextBoxColumn,
            this.nRSTRADADataGridViewTextBoxColumn});
            this.MagaGrid.DataSource = this.mAGAZINBindingSource;
            this.MagaGrid.Location = new System.Drawing.Point(301, 129);
            this.MagaGrid.Name = "MagaGrid";
            this.MagaGrid.ReadOnly = true;
            this.MagaGrid.RowHeadersVisible = false;
            this.MagaGrid.RowHeadersWidth = 51;
            this.MagaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MagaGrid.Size = new System.Drawing.Size(670, 353);
            this.MagaGrid.TabIndex = 8;
            this.MagaGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDMAGAZINDataGridViewTextBoxColumn
            // 
            this.iDMAGAZINDataGridViewTextBoxColumn.DataPropertyName = "ID_MAGAZIN";
            this.iDMAGAZINDataGridViewTextBoxColumn.HeaderText = "ID_MAGAZIN";
            this.iDMAGAZINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDMAGAZINDataGridViewTextBoxColumn.Name = "iDMAGAZINDataGridViewTextBoxColumn";
            this.iDMAGAZINDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDMAGAZINDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDORASDataGridViewTextBoxColumn
            // 
            this.iDORASDataGridViewTextBoxColumn.DataPropertyName = "ID_ORAS";
            this.iDORASDataGridViewTextBoxColumn.HeaderText = "ID_ORAS";
            this.iDORASDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDORASDataGridViewTextBoxColumn.Name = "iDORASDataGridViewTextBoxColumn";
            this.iDORASDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDORASDataGridViewTextBoxColumn.Width = 125;
            // 
            // nUMEDataGridViewTextBoxColumn
            // 
            this.nUMEDataGridViewTextBoxColumn.DataPropertyName = "NUME";
            this.nUMEDataGridViewTextBoxColumn.HeaderText = "NUME";
            this.nUMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nUMEDataGridViewTextBoxColumn.Name = "nUMEDataGridViewTextBoxColumn";
            this.nUMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dATADESCHIDEREDataGridViewTextBoxColumn
            // 
            this.dATADESCHIDEREDataGridViewTextBoxColumn.DataPropertyName = "DATA_DESCHIDERE";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.dATADESCHIDEREDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dATADESCHIDEREDataGridViewTextBoxColumn.HeaderText = "DATA_DESCHIDERE";
            this.dATADESCHIDEREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dATADESCHIDEREDataGridViewTextBoxColumn.Name = "dATADESCHIDEREDataGridViewTextBoxColumn";
            this.dATADESCHIDEREDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATADESCHIDEREDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTRADADataGridViewTextBoxColumn
            // 
            this.sTRADADataGridViewTextBoxColumn.DataPropertyName = "STRADA";
            this.sTRADADataGridViewTextBoxColumn.HeaderText = "STRADA";
            this.sTRADADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTRADADataGridViewTextBoxColumn.Name = "sTRADADataGridViewTextBoxColumn";
            this.sTRADADataGridViewTextBoxColumn.ReadOnly = true;
            this.sTRADADataGridViewTextBoxColumn.Width = 125;
            // 
            // nRSTRADADataGridViewTextBoxColumn
            // 
            this.nRSTRADADataGridViewTextBoxColumn.DataPropertyName = "NR_STRADA";
            this.nRSTRADADataGridViewTextBoxColumn.HeaderText = "NR_STRADA";
            this.nRSTRADADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nRSTRADADataGridViewTextBoxColumn.Name = "nRSTRADADataGridViewTextBoxColumn";
            this.nRSTRADADataGridViewTextBoxColumn.ReadOnly = true;
            this.nRSTRADADataGridViewTextBoxColumn.Width = 125;
            // 
            // mAGAZINBindingSource
            // 
            this.mAGAZINBindingSource.DataMember = "MAGAZIN";
            this.mAGAZINBindingSource.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAGAZINTableAdapter
            // 
            this.mAGAZINTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(43, 588);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(274, 66);
            this.button4.TabIndex = 26;
            this.button4.Text = "INAPOI LA MENIU";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(240, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 48);
            this.button3.TabIndex = 25;
            this.button3.Text = "STERGE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(134, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 48);
            this.button2.TabIndex = 24;
            this.button2.Text = "EDITEAZA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(43, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 48);
            this.button1.TabIndex = 23;
            this.button1.Text = "ADAUGA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(-3, 684);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 34);
            this.panel2.TabIndex = 27;
            // 
            // SecretBox
            // 
            this.SecretBox.Location = new System.Drawing.Point(864, 660);
            this.SecretBox.Name = "SecretBox";
            this.SecretBox.ReadOnly = true;
            this.SecretBox.Size = new System.Drawing.Size(85, 20);
            this.SecretBox.TabIndex = 3;
            this.SecretBox.Visible = false;
            // 
            // ord
            // 
            this.ord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ord.FormattingEnabled = true;
            this.ord.Items.AddRange(new object[] {
            "asc",
            "desc"});
            this.ord.Location = new System.Drawing.Point(705, 527);
            this.ord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ord.Name = "ord";
            this.ord.Size = new System.Drawing.Size(92, 21);
            this.ord.TabIndex = 33;
            this.ord.SelectedIndexChanged += new System.EventHandler(this.ord_SelectedIndexChanged);
            // 
            // items
            // 
            this.items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.items.FormattingEnabled = true;
            this.items.Items.AddRange(new object[] {
            "id_magazin",
            "id_oras",
            "nume",
            "data_deschidere",
            "strada",
            "nr_strada"});
            this.items.Location = new System.Drawing.Point(585, 527);
            this.items.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(92, 21);
            this.items.TabIndex = 32;
            this.items.SelectedIndexChanged += new System.EventHandler(this.items_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(478, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "Sortare dupa";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(320, 512);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 48);
            this.button5.TabIndex = 41;
            this.button5.Text = "CURATA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Magazine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 718);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ord);
            this.Controls.Add(this.items);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MagaGrid);
            this.Controls.Add(this.Deschidere);
            this.Controls.Add(this.OrasBox);
            this.Controls.Add(this.StradaBox);
            this.Controls.Add(this.NumarStradaBox);
            this.Controls.Add(this.SecretBox);
            this.Controls.Add(this.NumeBox);
            this.Controls.Add(this.id_mag);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Magazine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazine";
            this.Load += new System.EventHandler(this.Magazine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MagaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAGAZINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox id_mag;
        private System.Windows.Forms.TextBox NumeBox;
        private System.Windows.Forms.TextBox NumarStradaBox;
        private System.Windows.Forms.TextBox StradaBox;
        private System.Windows.Forms.ComboBox OrasBox;
        private System.Windows.Forms.DateTimePicker Deschidere;
        private System.Windows.Forms.DataGridView MagaGrid;
        private DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource mAGAZINBindingSource;
        private DataSet6TableAdapters.MAGAZINTableAdapter mAGAZINTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SecretBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMAGAZINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDORASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATADESCHIDEREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRSTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox ord;
        private System.Windows.Forms.ComboBox items;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
    }
}