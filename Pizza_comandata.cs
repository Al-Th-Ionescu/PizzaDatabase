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
    public partial class Pizza_comandata : Form
    {
        public Pizza_comandata()
        {
            InitializeComponent();
            popOras();
            PopPizza();
            items.SelectedIndex = 0;
            ord.SelectedIndex = 0;
            populate();
        }

        OracleConnection Con = new OracleConnection("DATA SOURCE = localhost:1521 / xe; PERSIST SECURITY INFO=True;USER ID = ADMINPIZZA;password=password2;");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from pizza_comandata order by "+items.Text+" "+ord.Text;
                OracleDataAdapter da = new OracleDataAdapter(Myquery, Con);
                OracleCommandBuilder builder = new OracleCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                PizzaComandataGrid.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                Con.Close();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pizza_comandata_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet8.PIZZA_COMANDATA' table. You can move, or remove it, as needed.
            this.pIZZA_COMANDATATableAdapter.Fill(this.dataSet8.PIZZA_COMANDATA);

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

        void GetIdMag()
        {
            try
            {
                Con.Open();
                string myquery = "select id_magazin from magazin where nume='" + MagazinBox1.Text + "'";
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

        void GetMagazin()
        {
            try
            {
                Con.Open();
                string myquery = "select nume from magazin where id_magazin=" + PizzaComandataGrid.SelectedRows[0].Cells[0].Value.ToString();
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

        void GetPizza()
        {
            Con.Open();
            string myquery = "select nume from pizza where id_pizza=" + PizzaComandataGrid.SelectedRows[0].Cells[1].Value.ToString();
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            r.Read();
            PizzaBox.SelectedItem = r["nume"].ToString();
            Con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PregOras();
            GetMagazin();
            GetPizza();
            CodComanda.Text = PizzaComandataGrid.SelectedRows[0].Cells[2].Value.ToString();
            Cantitate.Text = PizzaComandataGrid.SelectedRows[0].Cells[3].Value.ToString();
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

        void PopPizza()
        {
            Con.Open();
            string myquery = "select nume from pizza";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
                PizzaBox.Items.Add(r["nume"].ToString());
            Con.Close();
        }

        void PregOras()
        {
            try
            {
                Con.Open();
                string myquery = "select o.nume_oras from oras o join magazin m on m.id_oras = o.id_oras where m.id_magazin=" + PizzaComandataGrid.SelectedRows[0].Cells[0].Value.ToString();
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

        void GetPizzaId()
        {
            Con.Close();
            Con.Open();
            if (OrasBox.SelectedIndex != -1)
            {
                string myquery = "select id_pizza from pizza where nume='" + PizzaBox.Text + "'";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                OracleDataReader r = cmd.ExecuteReader();
                r.Read();
                SecretPizza.Text = r["id_pizza"].ToString();
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            Meniu men = new Meniu();
            men.Show();
            this.Hide();
        }

        private void PizzaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPizzaId();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "insert into pizza_comandata values("+SecretBox.Text+"," +SecretPizza.Text+ "," + CodComanda.Text + "," + Cantitate.Text + ")";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Ati adaugat pizza comandata!");
                populate();
            }
            catch
            {
                MessageBox.Show("Adaugarea a esuat!");
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
                string myquery = "delete from pizza_comandata where id_magazin=" + SecretBox.Text + " and id_pizza = "+SecretPizza.Text+" and cod_comanda="+CodComanda.Text;
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pizza comandata a fost stearsa cu succes!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Nu a fost nimic selectat!");
                Con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "update pizza_comandata set cantitate=" + Cantitate.Text + " where id_magazin=" + SecretBox.Text+"and cod_comanda="+CodComanda.Text+ "and id_pizza=" + SecretPizza.Text;
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Pizza comandata a fost updatata!");
                populate();
            }
            catch
            {
                MessageBox.Show("Updatarea a esuat!");
                Con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrasBox.SelectedIndex = -1;
            PizzaBox.SelectedIndex = -1;
            CodComanda.Clear();
            Cantitate.Clear();
        }

        private void items_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();
        }

        private void ord_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();
        }
    }
}
