using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BazeDeDate
{
    public partial class Magazine : Form
    {
        public Magazine()
        {
            InitializeComponent();
            PopOras();
            Deschidere.CustomFormat = "dd/MM/yyyy";
            items.SelectedIndex = 0;
            ord.SelectedIndex = 0;
            populate();
        }

        OracleConnection Con = new OracleConnection("DATA SOURCE = localhost:1521 / xe; PERSIST SECURITY INFO=True;USER ID = ADMINPIZZA;password=password2;");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Magazine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet6.MAGAZIN' table. You can move, or remove it, as needed.
            this.mAGAZINTableAdapter.Fill(this.dataSet6.MAGAZIN);

        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery;
                if (items.Text != "data_deschierii")
                {
                     Myquery = "select * from magazin order by " + items.Text + " " + ord.Text;
                }
                else
                     Myquery = "select * from magazin order by to_date('" + items.Text + "') " + ord.Text;
                OracleDataAdapter da = new OracleDataAdapter(Myquery, Con);
                OracleCommandBuilder builder = new OracleCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                MagaGrid.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                Con.Close();
            }

        }

        void GetOras()
        {
            Con.Open();
            string myquery = "select o.nume_oras from oras o join magazin m on o.id_oras=m.id_oras where m.id_oras=" + MagaGrid.SelectedRows[0].Cells[1].Value.ToString()+"";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            r.Read();
            OrasBox.SelectedItem = r["nume_oras"].ToString();
            Con.Close();
        }

        void PopOras()
        {
            Con.Open();
            string myquery = "select nume_oras from oras";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
                OrasBox.Items.Add(r["nume_oras"].ToString());
            Con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_mag.Text = MagaGrid.SelectedRows[0].Cells[0].Value.ToString();
            GetOras();
            NumeBox.Text = MagaGrid.SelectedRows[0].Cells[2].Value.ToString();
            Deschidere.Value = Convert.ToDateTime(MagaGrid.SelectedRows[0].Cells[3].Value.ToString());
            StradaBox.Text = MagaGrid.SelectedRows[0].Cells[4].Value.ToString();
            NumarStradaBox.Text = MagaGrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Meniu men = new Meniu();
            men.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "insert into magazin values (id_magazin_pk_seq.NEXTVAL," + SecretBox.Text + ",'" + NumeBox.Text + "',to_date('" + Deschidere.Value.ToString() + "','mm/dd/YYYY hh12:MI:ss AM'),'" + StradaBox.Text + "'," + NumarStradaBox.Text + ")";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Un magazin nou a fost adaugat cu succes!");
                populate();
            }
            catch
            {
                MessageBox.Show("Adaugarea magazinului a esuat!");
                Con.Close();
            }
        }

        private void OrasBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Close();
            Con.Open();
            if (OrasBox.SelectedIndex != -1)
            {
                string myquery = "select id_oras from oras where nume_oras='" + OrasBox.Text + "'";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                OracleDataReader r = cmd.ExecuteReader();
                r.Read();
                SecretBox.Text = r["id_oras"].ToString();
            }
            Con.Close();
        }

        private void Deschidere_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "delete from magazin where id_magazin=" + id_mag.Text + "";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Magazinul a fost sters cu succes!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Nu a fost niciun magazin selectat!");
                Con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                OracleCommand cmd = new OracleCommand("update magazin set id_oras=" + SecretBox.Text + ", nume='" + NumeBox.Text + "',data_deschidere=to_date('" + Deschidere.Value.ToString() + "','mm/dd/YYYY hh12:MI:ss AM'), strada='"+StradaBox.Text+"',nr_strada="+NumarStradaBox.Text+"  where id_magazin=" + id_mag.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Magazinul a fost updatat!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Editarea unui magazin a esuat!");
                Con.Close();
            }
        }

        private void items_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();
        }

        private void ord_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            id_mag.Clear();
            OrasBox.SelectedIndex = -1;
            NumeBox.Clear();
            Deschidere.Value = DateTime.Now;
            StradaBox.Clear();
            NumarStradaBox.Clear();
        }
    }
}
