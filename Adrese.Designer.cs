
namespace BazeDeDate
{
    partial class Adrese
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
            this.ClientBox = new System.Windows.Forms.ComboBox();
            this.id_adresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LocalitateBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stradabox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nr_strada = new System.Windows.Forms.TextBox();
            this.Bloc = new System.Windows.Forms.Label();
            this.blocbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ScaraBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.etaj_box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Apartament_Box = new System.Windows.Forms.TextBox();
            this.AdresaGrid = new System.Windows.Forms.DataGridView();
            this.iDADRESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCALITATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMARSTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTAJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPARTAMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet9 = new BazeDeDate.DataSet9();
            this.aDRESATableAdapter = new BazeDeDate.DataSet9TableAdapters.ADRESATableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SecretBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.ord = new System.Windows.Forms.ComboBox();
            this.items = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdresaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDRESABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 68);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Txt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1338, 0);
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
            this.label1.Location = new System.Drawing.Point(537, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADRESE CLIENTI";
            // 
            // ClientBox
            // 
            this.ClientBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientBox.FormattingEnabled = true;
            this.ClientBox.Location = new System.Drawing.Point(48, 216);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(174, 21);
            this.ClientBox.TabIndex = 3;
            this.ClientBox.SelectedIndexChanged += new System.EventHandler(this.ClientBox_SelectedIndexChanged);
            // 
            // id_adresa
            // 
            this.id_adresa.Location = new System.Drawing.Point(48, 158);
            this.id_adresa.Name = "id_adresa";
            this.id_adresa.ReadOnly = true;
            this.id_adresa.Size = new System.Drawing.Size(174, 20);
            this.id_adresa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Localitate";
            // 
            // LocalitateBox
            // 
            this.LocalitateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalitateBox.FormattingEnabled = true;
            this.LocalitateBox.Location = new System.Drawing.Point(48, 273);
            this.LocalitateBox.Name = "LocalitateBox";
            this.LocalitateBox.Size = new System.Drawing.Size(174, 21);
            this.LocalitateBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Strada";
            // 
            // stradabox
            // 
            this.stradabox.Location = new System.Drawing.Point(48, 331);
            this.stradabox.Name = "stradabox";
            this.stradabox.Size = new System.Drawing.Size(174, 20);
            this.stradabox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Numar Strada";
            // 
            // nr_strada
            // 
            this.nr_strada.Location = new System.Drawing.Point(48, 388);
            this.nr_strada.Name = "nr_strada";
            this.nr_strada.Size = new System.Drawing.Size(174, 20);
            this.nr_strada.TabIndex = 6;
            // 
            // Bloc
            // 
            this.Bloc.AutoSize = true;
            this.Bloc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bloc.Location = new System.Drawing.Point(44, 420);
            this.Bloc.Name = "Bloc";
            this.Bloc.Size = new System.Drawing.Size(37, 19);
            this.Bloc.TabIndex = 5;
            this.Bloc.Text = "Bloc";
            this.Bloc.Click += new System.EventHandler(this.Bloc_Click);
            // 
            // blocbox
            // 
            this.blocbox.Location = new System.Drawing.Point(48, 442);
            this.blocbox.Name = "blocbox";
            this.blocbox.Size = new System.Drawing.Size(174, 20);
            this.blocbox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Scara";
            this.label8.Click += new System.EventHandler(this.Bloc_Click);
            // 
            // ScaraBox
            // 
            this.ScaraBox.Location = new System.Drawing.Point(48, 497);
            this.ScaraBox.Name = "ScaraBox";
            this.ScaraBox.Size = new System.Drawing.Size(174, 20);
            this.ScaraBox.TabIndex = 6;
            this.ScaraBox.TextChanged += new System.EventHandler(this.ScaraBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 531);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Etaj";
            this.label9.Click += new System.EventHandler(this.Bloc_Click);
            // 
            // etaj_box
            // 
            this.etaj_box.Location = new System.Drawing.Point(48, 553);
            this.etaj_box.Name = "etaj_box";
            this.etaj_box.Size = new System.Drawing.Size(174, 20);
            this.etaj_box.TabIndex = 6;
            this.etaj_box.TextChanged += new System.EventHandler(this.ScaraBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 595);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Apartament";
            this.label10.Click += new System.EventHandler(this.Bloc_Click);
            // 
            // Apartament_Box
            // 
            this.Apartament_Box.Location = new System.Drawing.Point(48, 617);
            this.Apartament_Box.Name = "Apartament_Box";
            this.Apartament_Box.Size = new System.Drawing.Size(174, 20);
            this.Apartament_Box.TabIndex = 6;
            this.Apartament_Box.TextChanged += new System.EventHandler(this.ScaraBox_TextChanged);
            // 
            // AdresaGrid
            // 
            this.AdresaGrid.AllowUserToAddRows = false;
            this.AdresaGrid.AllowUserToDeleteRows = false;
            this.AdresaGrid.AllowUserToResizeColumns = false;
            this.AdresaGrid.AllowUserToResizeRows = false;
            this.AdresaGrid.AutoGenerateColumns = false;
            this.AdresaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdresaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDADRESADataGridViewTextBoxColumn,
            this.iDCLIENTDataGridViewTextBoxColumn,
            this.lOCALITATEDataGridViewTextBoxColumn,
            this.sTRADADataGridViewTextBoxColumn,
            this.nUMARSTRADADataGridViewTextBoxColumn,
            this.bLOCDataGridViewTextBoxColumn,
            this.sCARADataGridViewTextBoxColumn,
            this.eTAJDataGridViewTextBoxColumn,
            this.aPARTAMENTDataGridViewTextBoxColumn});
            this.AdresaGrid.DataSource = this.aDRESABindingSource;
            this.AdresaGrid.Location = new System.Drawing.Point(423, 101);
            this.AdresaGrid.MultiSelect = false;
            this.AdresaGrid.Name = "AdresaGrid";
            this.AdresaGrid.ReadOnly = true;
            this.AdresaGrid.RowHeadersVisible = false;
            this.AdresaGrid.RowHeadersWidth = 51;
            this.AdresaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdresaGrid.Size = new System.Drawing.Size(944, 437);
            this.AdresaGrid.TabIndex = 7;
            this.AdresaGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDADRESADataGridViewTextBoxColumn
            // 
            this.iDADRESADataGridViewTextBoxColumn.DataPropertyName = "ID_ADRESA";
            this.iDADRESADataGridViewTextBoxColumn.HeaderText = "ID_ADRESA";
            this.iDADRESADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDADRESADataGridViewTextBoxColumn.Name = "iDADRESADataGridViewTextBoxColumn";
            this.iDADRESADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDADRESADataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCLIENTDataGridViewTextBoxColumn
            // 
            this.iDCLIENTDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENT";
            this.iDCLIENTDataGridViewTextBoxColumn.HeaderText = "ID_CLIENT";
            this.iDCLIENTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCLIENTDataGridViewTextBoxColumn.Name = "iDCLIENTDataGridViewTextBoxColumn";
            this.iDCLIENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCLIENTDataGridViewTextBoxColumn.Width = 125;
            // 
            // lOCALITATEDataGridViewTextBoxColumn
            // 
            this.lOCALITATEDataGridViewTextBoxColumn.DataPropertyName = "LOCALITATE";
            this.lOCALITATEDataGridViewTextBoxColumn.HeaderText = "LOCALITATE";
            this.lOCALITATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOCALITATEDataGridViewTextBoxColumn.Name = "lOCALITATEDataGridViewTextBoxColumn";
            this.lOCALITATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOCALITATEDataGridViewTextBoxColumn.Width = 125;
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
            // nUMARSTRADADataGridViewTextBoxColumn
            // 
            this.nUMARSTRADADataGridViewTextBoxColumn.DataPropertyName = "NUMAR_STRADA";
            this.nUMARSTRADADataGridViewTextBoxColumn.HeaderText = "NUMAR_STRADA";
            this.nUMARSTRADADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nUMARSTRADADataGridViewTextBoxColumn.Name = "nUMARSTRADADataGridViewTextBoxColumn";
            this.nUMARSTRADADataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMARSTRADADataGridViewTextBoxColumn.Width = 125;
            // 
            // bLOCDataGridViewTextBoxColumn
            // 
            this.bLOCDataGridViewTextBoxColumn.DataPropertyName = "BLOC";
            this.bLOCDataGridViewTextBoxColumn.HeaderText = "BLOC";
            this.bLOCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bLOCDataGridViewTextBoxColumn.Name = "bLOCDataGridViewTextBoxColumn";
            this.bLOCDataGridViewTextBoxColumn.ReadOnly = true;
            this.bLOCDataGridViewTextBoxColumn.Width = 125;
            // 
            // sCARADataGridViewTextBoxColumn
            // 
            this.sCARADataGridViewTextBoxColumn.DataPropertyName = "SCARA";
            this.sCARADataGridViewTextBoxColumn.HeaderText = "SCARA";
            this.sCARADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sCARADataGridViewTextBoxColumn.Name = "sCARADataGridViewTextBoxColumn";
            this.sCARADataGridViewTextBoxColumn.ReadOnly = true;
            this.sCARADataGridViewTextBoxColumn.Width = 125;
            // 
            // eTAJDataGridViewTextBoxColumn
            // 
            this.eTAJDataGridViewTextBoxColumn.DataPropertyName = "ETAJ";
            this.eTAJDataGridViewTextBoxColumn.HeaderText = "ETAJ";
            this.eTAJDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eTAJDataGridViewTextBoxColumn.Name = "eTAJDataGridViewTextBoxColumn";
            this.eTAJDataGridViewTextBoxColumn.ReadOnly = true;
            this.eTAJDataGridViewTextBoxColumn.Width = 125;
            // 
            // aPARTAMENTDataGridViewTextBoxColumn
            // 
            this.aPARTAMENTDataGridViewTextBoxColumn.DataPropertyName = "APARTAMENT";
            this.aPARTAMENTDataGridViewTextBoxColumn.HeaderText = "APARTAMENT";
            this.aPARTAMENTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aPARTAMENTDataGridViewTextBoxColumn.Name = "aPARTAMENTDataGridViewTextBoxColumn";
            this.aPARTAMENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aPARTAMENTDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDRESABindingSource
            // 
            this.aDRESABindingSource.DataMember = "ADRESA";
            this.aDRESABindingSource.DataSource = this.dataSet9;
            // 
            // dataSet9
            // 
            this.dataSet9.DataSetName = "DataSet9";
            this.dataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDRESATableAdapter
            // 
            this.aDRESATableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(300, 310);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 48);
            this.button5.TabIndex = 46;
            this.button5.Text = "CURATA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(300, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 66);
            this.button4.TabIndex = 45;
            this.button4.Text = "INAPOI SPRE CLIENTI";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(300, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 48);
            this.button3.TabIndex = 44;
            this.button3.Text = "STERGE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(300, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 48);
            this.button2.TabIndex = 43;
            this.button2.Text = "EDITEAZA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(300, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 48);
            this.button1.TabIndex = 42;
            this.button1.Text = "ADAUGA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecretBox
            // 
            this.SecretBox.Location = new System.Drawing.Point(177, 74);
            this.SecretBox.Name = "SecretBox";
            this.SecretBox.ReadOnly = true;
            this.SecretBox.Size = new System.Drawing.Size(100, 20);
            this.SecretBox.TabIndex = 47;
            this.SecretBox.Visible = false;
            this.SecretBox.TextChanged += new System.EventHandler(this.SecretBox_TextChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightCoral;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(288, 445);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 78);
            this.button6.TabIndex = 48;
            this.button6.Text = "Sterge Adresele Suplimentare";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ord
            // 
            this.ord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ord.FormattingEnabled = true;
            this.ord.Items.AddRange(new object[] {
            "asc",
            "desc"});
            this.ord.Location = new System.Drawing.Point(550, 583);
            this.ord.Margin = new System.Windows.Forms.Padding(2);
            this.ord.Name = "ord";
            this.ord.Size = new System.Drawing.Size(92, 21);
            this.ord.TabIndex = 51;
            this.ord.SelectedIndexChanged += new System.EventHandler(this.ord_SelectedIndexChanged);
            // 
            // items
            // 
            this.items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.items.FormattingEnabled = true;
            this.items.Items.AddRange(new object[] {
            "id_adresa",
            "id_client",
            "localitate",
            "strada",
            "numar_strada",
            "bloc",
            "scara",
            "etaj",
            "apartament"});
            this.items.Location = new System.Drawing.Point(430, 583);
            this.items.Margin = new System.Windows.Forms.Padding(2);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(92, 21);
            this.items.TabIndex = 50;
            this.items.SelectedIndexChanged += new System.EventHandler(this.items_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(322, 585);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 19);
            this.label11.TabIndex = 49;
            this.label11.Text = "Sortare dupa";
            // 
            // Adrese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 683);
            this.Controls.Add(this.ord);
            this.Controls.Add(this.items);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.SecretBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdresaGrid);
            this.Controls.Add(this.Apartament_Box);
            this.Controls.Add(this.etaj_box);
            this.Controls.Add(this.ScaraBox);
            this.Controls.Add(this.blocbox);
            this.Controls.Add(this.nr_strada);
            this.Controls.Add(this.stradabox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Bloc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_adresa);
            this.Controls.Add(this.LocalitateBox);
            this.Controls.Add(this.ClientBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adrese";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adrese";
            this.Load += new System.EventHandler(this.Adrese_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdresaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDRESABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ClientBox;
        private System.Windows.Forms.TextBox id_adresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LocalitateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stradabox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nr_strada;
        private System.Windows.Forms.Label Bloc;
        private System.Windows.Forms.TextBox blocbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ScaraBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox etaj_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Apartament_Box;
        private System.Windows.Forms.DataGridView AdresaGrid;
        private DataSet9 dataSet9;
        private System.Windows.Forms.BindingSource aDRESABindingSource;
        private DataSet9TableAdapters.ADRESATableAdapter aDRESATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDADRESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCALITATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMARSTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCARADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTAJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPARTAMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SecretBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox ord;
        private System.Windows.Forms.ComboBox items;
        private System.Windows.Forms.Label label11;
    }
}