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
    public partial class Angajati : Form
    {
        public Angajati()
        {
            InitializeComponent();
            popOras();
            items.SelectedIndex = 0;
            ord.SelectedIndex = 0;
            populate();
        }

        OracleConnection Con = new OracleConnection("DATA SOURCE = localhost:1521 / xe; PERSIST SECURITY INFO=True;USER ID = ADMINPIZZA;password=password2;");

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from angajat order by "+items.Text+" "+ord.Text;
                OracleDataAdapter da = new OracleDataAdapter(Myquery, Con);
                OracleCommandBuilder builder = new OracleCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                AngajatiGrid.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                Con.Close();
            }

        }



        void popOras()
        {
            Con.Open();
            string myquery = "select nume_oras from oras";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
                OrasBox.Items.Add(r["nume_oras"].ToString());
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Angajati_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet7.ANGAJAT' table. You can move, or remove it, as needed.
            this.aNGAJATTableAdapter.Fill(this.dataSet7.ANGAJAT);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cod_angajat.Text = AngajatiGrid.SelectedRows[0].Cells[0].Value.ToString();
            PregOras();
            GetMagazin();
            NumeBox.Text = AngajatiGrid.SelectedRows[0].Cells[2].Value.ToString();
            PrenumeBox.Text = AngajatiGrid.SelectedRows[0].Cells[3].Value.ToString();
            SalariuBox.Text = AngajatiGrid.SelectedRows[0].Cells[4].Value.ToString();
            TelefonBox.Text = AngajatiGrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Meniu men = new Meniu();
            men.Show();
            this.Hide();
        }

        void GetMagazin()
        {
            try
            {
                Con.Open();
                string myquery = "select nume from magazin where id_magazin="+AngajatiGrid.SelectedRows[0].Cells[1].Value.ToString();
                OracleCommand cmd = new OracleCommand(myquery, Con);
                OracleDataReader r = cmd.ExecuteReader();
                r.Read();
                MagazinBox1.SelectedItem = r["nume"].ToString();
                Con.Close();
                GetIdMag();
            }
            catch
            {
                Con.Close();
            }
        }
        
        void PregOras()
        {
            try
            {
                Con.Open();
                string myquery= "select o.nume_oras from oras o join magazin m on m.id_oras = o.id_oras where m.id_magazin="+AngajatiGrid.SelectedRows[0].Cells[1].Value.ToString();
                OracleCommand cmd = new OracleCommand(myquery, Con);
                OracleDataReader r = cmd.ExecuteReader();
                r.Read();
                OrasBox.SelectedItem = r["nume_oras"].ToString();
                Con.Close();
                PopuleazaMagazin();
            }
            catch
            {
                Con.Close();
            }
        }

        void PopuleazaMagazin()
        {
            Con.Open();
            string myquery = "select m.nume from magazin m join oras o on o.id_oras=m.id_oras where o.nume_oras='" + OrasBox.Text + "'";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
                MagazinBox1.Items.Add(r["nume"].ToString());
            Con.Close();
        }

        private void OrasBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MagazinBox1.Items.Clear();
            try
            {
                PopuleazaMagazin();
            }
            catch
            {
               

            }
        }

        void GetIdMag()
        {
            try
            {
                Con.Open();
                string myquery="select id_magazin from magazin where nume='"+MagazinBox1.Text+"'";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                OracleDataReader r = cmd.ExecuteReader();
                r.Read();
                SecretBox.Text = r["id_magazin"].ToString();
                Con.Close();
            }
            catch
            {
                Con.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "insert into angajat values (cod_angajat_pk_seq.NEXTVAL,"+SecretBox.Text+",'"+NumeBox.Text+"','"+PrenumeBox.Text+"',"+SalariuBox.Text+",'"+TelefonBox.Text+"')"; 
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Un angajat nou a fost adaugat cu succes!");
                populate();
            }
            catch
            {
                MessageBox.Show("Adaugarea angajatului a esuat!");
                Con.Close();
            }
        }

        private void MagazinBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetIdMag();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "delete from angajat where cod_angajat=" + Cod_angajat.Text + "";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Angajatul a fost sters cu succes!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Nu a fost niciun angajat selectat!");
                Con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "update angajat set id_magazin=" + SecretBox.Text + ",nume='" + NumeBox.Text + "',prenume='" + PrenumeBox.Text + "',salariu=" + SalariuBox.Text + ",telefon='" + TelefonBox.Text + "' where cod_angajat="+Cod_angajat.Text;
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Angajatul a fost updatat!");
                populate();
            }
            catch
            {
                MessageBox.Show("Updatarea angajatului a esuat!");
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
            Cod_angajat.Clear();
            OrasBox.SelectedIndex = -1;
            NumeBox.Clear();
            PrenumeBox.Clear();
            SalariuBox.Clear();
            TelefonBox.Clear();
        }
    }
}
