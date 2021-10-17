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
    public partial class Comenzi : Form
    {
        public Comenzi()
        {
            InitializeComponent();
            items.SelectedIndex = 0;
            ord.SelectedIndex = 0;
            populate();
            
        }
        OracleConnection Con = new OracleConnection("DATA SOURCE = localhost:1521 / xe; PERSIST SECURITY INFO=True;USER ID = ADMINPIZZA;password=password2;");
        private void Comenzi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.COMANDA' table. You can move, or remove it, as needed.
            try
            {
                this.cOMANDATableAdapter.Fill(this.dataSet2.COMANDA);
            }
            catch
            {

            }
        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from comanda order by "+items.Text+" "+ord.Text;
                OracleDataAdapter da = new OracleDataAdapter(Myquery, Con);
                OracleCommandBuilder builder = new OracleCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ComandaGridView.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                Con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery;
                myquery = "insert into comanda values(cod_comanda_pk_seq.NEXTVAL," + ID_CLIENT.Text + ",to_date('" + TIMP_SOLICITARE.Text + "', 'MM/DD/YYYY HH12:MI:SS AM'))";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Comanda a fost adaugata!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Adaugarea comenzii a esuat!");
                Con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "delete from comanda where cod_comanda='" + COD_COMANDA.Text + "'";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Comanda a fost stearsa cu succes!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Nu a fost nicio comanda selectata!");
                Con.Close();
            }
        }

        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            COD_COMANDA.Text = ComandaGridView.SelectedRows[0].Cells[0].Value.ToString();
            ID_CLIENT.Text = ComandaGridView.SelectedRows[0].Cells[1].Value.ToString();
            TIMP_SOLICITARE.Text = ComandaGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                OracleCommand cmd = new OracleCommand("update comanda set id_client='" + ID_CLIENT.Text + "', timpul_solicitarii= to_date('" + TIMP_SOLICITARE.Text + "', 'MM/DD/YYYY HH12:MI:SS AM') where cod_comanda=" + COD_COMANDA.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Comanda a fost updatata!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Editarea comenzii a esuat!");
                Con.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Meniu men = new Meniu();
            men.Show();
            this.Hide();
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
            COD_COMANDA.Clear();
            ID_CLIENT.Clear();
            TIMP_SOLICITARE.Clear();
        }

        private void TIMP_SOLICITARE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
