
namespace BazeDeDate
{
    partial class Orase
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id_oras_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nume_oras_box = new System.Windows.Forms.TextBox();
            this.judet_box = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataSet4 = new BazeDeDate.DataSet4();
            this.oRASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRASTableAdapter = new BazeDeDate.DataSet4TableAdapters.ORASTableAdapter();
            this.OraseGrid = new System.Windows.Forms.DataGridView();
            this.iDORASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEORASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jUDETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet5 = new BazeDeDate.DataSet5();
            this.oRASTableAdapter1 = new BazeDeDate.DataSet5TableAdapters.ORASTableAdapter();
            this.ord = new System.Windows.Forms.ComboBox();
            this.items = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OraseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRASBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 95);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Txt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(786, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nume Oras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Judet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID Oras";
            // 
            // id_oras_box
            // 
            this.id_oras_box.Location = new System.Drawing.Point(34, 207);
            this.id_oras_box.Name = "id_oras_box";
            this.id_oras_box.ReadOnly = true;
            this.id_oras_box.Size = new System.Drawing.Size(146, 20);
            this.id_oras_box.TabIndex = 2;
            this.id_oras_box.TextChanged += new System.EventHandler(this.id_oras_box_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nume Oras";
            // 
            // nume_oras_box
            // 
            this.nume_oras_box.Location = new System.Drawing.Point(34, 280);
            this.nume_oras_box.Name = "nume_oras_box";
            this.nume_oras_box.Size = new System.Drawing.Size(146, 20);
            this.nume_oras_box.TabIndex = 2;
            // 
            // judet_box
            // 
            this.judet_box.Location = new System.Drawing.Point(34, 351);
            this.judet_box.Name = "judet_box";
            this.judet_box.Size = new System.Drawing.Size(146, 20);
            this.judet_box.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(34, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(274, 66);
            this.button4.TabIndex = 22;
            this.button4.Text = "INAPOI LA MENIU";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(233, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 48);
            this.button3.TabIndex = 21;
            this.button3.Text = "STERGE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(127, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 48);
            this.button2.TabIndex = 20;
            this.button2.Text = "EDITEAZA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(36, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 48);
            this.button1.TabIndex = 19;
            this.button1.Text = "ADAUGA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(0, 606);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 37);
            this.panel2.TabIndex = 23;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRASBindingSource
            // 
            this.oRASBindingSource.DataMember = "ORAS";
            this.oRASBindingSource.DataSource = this.dataSet4;
            // 
            // oRASTableAdapter
            // 
            this.oRASTableAdapter.ClearBeforeFill = true;
            // 
            // OraseGrid
            // 
            this.OraseGrid.AllowUserToAddRows = false;
            this.OraseGrid.AllowUserToDeleteRows = false;
            this.OraseGrid.AllowUserToResizeColumns = false;
            this.OraseGrid.AllowUserToResizeRows = false;
            this.OraseGrid.AutoGenerateColumns = false;
            this.OraseGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.OraseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OraseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDORASDataGridViewTextBoxColumn,
            this.nUMEORASDataGridViewTextBoxColumn,
            this.jUDETDataGridViewTextBoxColumn});
            this.OraseGrid.DataSource = this.oRASBindingSource1;
            this.OraseGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OraseGrid.Location = new System.Drawing.Point(416, 148);
            this.OraseGrid.Name = "OraseGrid";
            this.OraseGrid.ReadOnly = true;
            this.OraseGrid.RowHeadersVisible = false;
            this.OraseGrid.RowHeadersWidth = 51;
            this.OraseGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OraseGrid.Size = new System.Drawing.Size(348, 326);
            this.OraseGrid.TabIndex = 24;
            this.OraseGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OraseGrid_CellContentClick_1);
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
            // nUMEORASDataGridViewTextBoxColumn
            // 
            this.nUMEORASDataGridViewTextBoxColumn.DataPropertyName = "NUME_ORAS";
            this.nUMEORASDataGridViewTextBoxColumn.HeaderText = "NUME_ORAS";
            this.nUMEORASDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nUMEORASDataGridViewTextBoxColumn.Name = "nUMEORASDataGridViewTextBoxColumn";
            this.nUMEORASDataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMEORASDataGridViewTextBoxColumn.Width = 125;
            // 
            // jUDETDataGridViewTextBoxColumn
            // 
            this.jUDETDataGridViewTextBoxColumn.DataPropertyName = "JUDET";
            this.jUDETDataGridViewTextBoxColumn.HeaderText = "JUDET";
            this.jUDETDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jUDETDataGridViewTextBoxColumn.Name = "jUDETDataGridViewTextBoxColumn";
            this.jUDETDataGridViewTextBoxColumn.ReadOnly = true;
            this.jUDETDataGridViewTextBoxColumn.Width = 125;
            // 
            // oRASBindingSource1
            // 
            this.oRASBindingSource1.DataMember = "ORAS";
            this.oRASBindingSource1.DataSource = this.dataSet5;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRASTableAdapter1
            // 
            this.oRASTableAdapter1.ClearBeforeFill = true;
            // 
            // ord
            // 
            this.ord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ord.FormattingEnabled = true;
            this.ord.Items.AddRange(new object[] {
            "asc",
            "desc"});
            this.ord.Location = new System.Drawing.Point(640, 502);
            this.ord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ord.Name = "ord";
            this.ord.Size = new System.Drawing.Size(92, 21);
            this.ord.TabIndex = 27;
            this.ord.SelectedIndexChanged += new System.EventHandler(this.ord_SelectedIndexChanged);
            // 
            // items
            // 
            this.items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.items.FormattingEnabled = true;
            this.items.Items.AddRange(new object[] {
            "id_oras",
            "nume_oras",
            "judet"});
            this.items.Location = new System.Drawing.Point(520, 502);
            this.items.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(92, 21);
            this.items.TabIndex = 26;
            this.items.SelectedIndexChanged += new System.EventHandler(this.items_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Sortare dupa";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(250, 254);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 48);
            this.button5.TabIndex = 41;
            this.button5.Text = "CURATA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Orase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 636);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ord);
            this.Controls.Add(this.items);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OraseGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.judet_box);
            this.Controls.Add(this.nume_oras_box);
            this.Controls.Add(this.id_oras_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orase";
            this.Load += new System.EventHandler(this.Orase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OraseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRASBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_oras_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nume_oras_box;
        private System.Windows.Forms.TextBox judet_box;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource oRASBindingSource;
        private DataSet4TableAdapters.ORASTableAdapter oRASTableAdapter;
        private System.Windows.Forms.DataGridView OraseGrid;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource oRASBindingSource1;
        private DataSet5TableAdapters.ORASTableAdapter oRASTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDORASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEORASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jUDETDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox ord;
        private System.Windows.Forms.ComboBox items;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
    }
}