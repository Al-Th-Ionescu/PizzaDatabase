
namespace BazeDeDate
{
    partial class Comenzi
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
            this.COD_COMANDA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_CLIENT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TIMP_SOLICITARE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ComandaGridView = new System.Windows.Forms.DataGridView();
            this.cOMANDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new BazeDeDate.DataSet2();
            this.cOMANDATableAdapter = new BazeDeDate.DataSet2TableAdapters.COMANDATableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.items = new System.Windows.Forms.ComboBox();
            this.ord = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.cODCOMANDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMPULSOLICITARIIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComandaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMANDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 108);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Txt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1000, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 59);
            this.label2.TabIndex = 0;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMENZI";
            // 
            // COD_COMANDA
            // 
            this.COD_COMANDA.Enabled = false;
            this.COD_COMANDA.Location = new System.Drawing.Point(35, 206);
            this.COD_COMANDA.Margin = new System.Windows.Forms.Padding(4);
            this.COD_COMANDA.Name = "COD_COMANDA";
            this.COD_COMANDA.ReadOnly = true;
            this.COD_COMANDA.Size = new System.Drawing.Size(369, 22);
            this.COD_COMANDA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "COD COMANDA";
            // 
            // ID_CLIENT
            // 
            this.ID_CLIENT.Location = new System.Drawing.Point(35, 284);
            this.ID_CLIENT.Margin = new System.Windows.Forms.Padding(4);
            this.ID_CLIENT.Name = "ID_CLIENT";
            this.ID_CLIENT.Size = new System.Drawing.Size(369, 22);
            this.ID_CLIENT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID CLIENT";
            // 
            // TIMP_SOLICITARE
            // 
            this.TIMP_SOLICITARE.Location = new System.Drawing.Point(35, 356);
            this.TIMP_SOLICITARE.Margin = new System.Windows.Forms.Padding(4);
            this.TIMP_SOLICITARE.Name = "TIMP_SOLICITARE";
            this.TIMP_SOLICITARE.Size = new System.Drawing.Size(369, 22);
            this.TIMP_SOLICITARE.TabIndex = 9;
            this.TIMP_SOLICITARE.TextChanged += new System.EventHandler(this.TIMP_SOLICITARE_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "TIMPUL SOLICITARII";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(35, 482);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "ADAUGA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(156, 482);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 59);
            this.button2.TabIndex = 12;
            this.button2.Text = "EDITEAZA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(297, 482);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 59);
            this.button3.TabIndex = 13;
            this.button3.Text = "STERGE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(32, 574);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(365, 81);
            this.button4.TabIndex = 14;
            this.button4.Text = "INAPOI LA MENIU";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ComandaGridView
            // 
            this.ComandaGridView.AllowUserToAddRows = false;
            this.ComandaGridView.AllowUserToDeleteRows = false;
            this.ComandaGridView.AllowUserToResizeColumns = false;
            this.ComandaGridView.AllowUserToResizeRows = false;
            this.ComandaGridView.AutoGenerateColumns = false;
            this.ComandaGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ComandaGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ComandaGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ComandaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComandaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCOMANDADataGridViewTextBoxColumn,
            this.iDCLIENTDataGridViewTextBoxColumn,
            this.tIMPULSOLICITARIIDataGridViewTextBoxColumn});
            this.ComandaGridView.DataSource = this.cOMANDABindingSource;
            this.ComandaGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ComandaGridView.Location = new System.Drawing.Point(439, 178);
            this.ComandaGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ComandaGridView.MultiSelect = false;
            this.ComandaGridView.Name = "ComandaGridView";
            this.ComandaGridView.ReadOnly = true;
            this.ComandaGridView.RowHeadersVisible = false;
            this.ComandaGridView.RowHeadersWidth = 51;
            this.ComandaGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ComandaGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComandaGridView.ShowCellErrors = false;
            this.ComandaGridView.Size = new System.Drawing.Size(604, 363);
            this.ComandaGridView.TabIndex = 15;
            this.ComandaGridView.VirtualMode = true;
            this.ComandaGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridView_CellContentClick);
            // 
            // cOMANDABindingSource
            // 
            this.cOMANDABindingSource.DataMember = "COMANDA";
            this.cOMANDABindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMANDATableAdapter
            // 
            this.cOMANDATableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(0, 788);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 58);
            this.panel2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(523, 564);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sortare dupa";
            // 
            // items
            // 
            this.items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.items.FormattingEnabled = true;
            this.items.Items.AddRange(new object[] {
            "cod_comanda",
            "id_client",
            "timpul_solicitarii"});
            this.items.Location = new System.Drawing.Point(667, 566);
            this.items.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(121, 24);
            this.items.TabIndex = 17;
            this.items.SelectedIndexChanged += new System.EventHandler(this.items_SelectedIndexChanged);
            // 
            // ord
            // 
            this.ord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ord.FormattingEnabled = true;
            this.ord.Items.AddRange(new object[] {
            "asc",
            "desc"});
            this.ord.Location = new System.Drawing.Point(827, 566);
            this.ord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ord.Name = "ord";
            this.ord.Size = new System.Drawing.Size(121, 24);
            this.ord.TabIndex = 17;
            this.ord.SelectedIndexChanged += new System.EventHandler(this.ord_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(156, 417);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 59);
            this.button5.TabIndex = 41;
            this.button5.Text = "CURATA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cODCOMANDADataGridViewTextBoxColumn
            // 
            this.cODCOMANDADataGridViewTextBoxColumn.DataPropertyName = "COD_COMANDA";
            this.cODCOMANDADataGridViewTextBoxColumn.HeaderText = "COD_COMANDA";
            this.cODCOMANDADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODCOMANDADataGridViewTextBoxColumn.Name = "cODCOMANDADataGridViewTextBoxColumn";
            this.cODCOMANDADataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCLIENTDataGridViewTextBoxColumn
            // 
            this.iDCLIENTDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENT";
            this.iDCLIENTDataGridViewTextBoxColumn.HeaderText = "ID_CLIENT";
            this.iDCLIENTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCLIENTDataGridViewTextBoxColumn.Name = "iDCLIENTDataGridViewTextBoxColumn";
            this.iDCLIENTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tIMPULSOLICITARIIDataGridViewTextBoxColumn
            // 
            this.tIMPULSOLICITARIIDataGridViewTextBoxColumn.DataPropertyName = "TIMPUL_SOLICITARII";
            dataGridViewCellStyle2.Format = "HH:mm:ss dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.tIMPULSOLICITARIIDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tIMPULSOLICITARIIDataGridViewTextBoxColumn.HeaderText = "TIMPUL_SOLICITARII";
            this.tIMPULSOLICITARIIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tIMPULSOLICITARIIDataGridViewTextBoxColumn.Name = "tIMPULSOLICITARIIDataGridViewTextBoxColumn";
            this.tIMPULSOLICITARIIDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIMPULSOLICITARIIDataGridViewTextBoxColumn.Width = 250;
            // 
            // Comenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 843);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ord);
            this.Controls.Add(this.items);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ComandaGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TIMP_SOLICITARE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID_CLIENT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.COD_COMANDA);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Comenzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CA";
            this.Load += new System.EventHandler(this.Comenzi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComandaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMANDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox COD_COMANDA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID_CLIENT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TIMP_SOLICITARE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView ComandaGridView;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource cOMANDABindingSource;
        private DataSet2TableAdapters.COMANDATableAdapter cOMANDATableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox items;
        private System.Windows.Forms.ComboBox ord;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCOMANDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMPULSOLICITARIIDataGridViewTextBoxColumn;
    }
}