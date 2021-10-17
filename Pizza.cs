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
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
            items.SelectedIndex = 0;
            ord.SelectedIndex = 0;
            populate();
        }

        OracleConnection Con = new OracleConnection("DATA SOURCE = localhost:1521 / xe; PERSIST SECURITY INFO=True;USER ID = ADMINPIZZA;password=password2;");

        private void Pizza_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.PIZZA' table. You can move, or remove it, as needed.
            this.pIZZATableAdapter.Fill(this.dataSet3.PIZZA);

        }
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from pizza order by "+items.Text+" "+ord.Text;
                OracleDataAdapter da = new OracleDataAdapter(Myquery, Con);
                OracleCommandBuilder builder = new OracleCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                PizzaGridView.DataSource = ds.Tables[0];
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
                string myquery;
                myquery = "insert into pizza values(id_pizza_pk_seq.NEXTVAL,'" + NUME.Text + "'," + PRET.Text + ",'"+BLAT.Text+"')";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pizza a fost adaugata!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Adaugarea unei noi pizza a esuat!");
                Con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "delete from pizza where id_pizza='" + ID_PIZZA.Text + "'";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pizza a fost stearsa cu succes!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Nu a fost nicio pizza selectata!");
                Con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                OracleCommand cmd = new OracleCommand("update pizza set nume='" + NUME.Text + "',pret=" + PRET.Text + ",blat='"+BLAT.Text+"' where id_pizza=" + ID_PIZZA.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pizza a fost updatata!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Editarea unei pizza a esuat!");
                Con.Close();
            }
        }

        private void ComandaGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_PIZZA.Text = PizzaGridView.SelectedRows[0].Cells[0].Value.ToString();
            NUME.Text = PizzaGridView.SelectedRows[0].Cells[1].Value.ToString();
            PRET.Text = PizzaGridView.SelectedRows[0].Cells[2].Value.ToString();
            BLAT.Text = PizzaGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void ID_PIZZA_TextChanged(object sender, EventArgs e)
        {

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
            ID_PIZZA.Clear();
            NUME.Clear();
            PRET.Clear();
            BLAT.Clear();
        }
    }
}
