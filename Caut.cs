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
    public partial class Caut : Form
    {
        public Caut()
        {
            InitializeComponent();
            popCmd();
            popClient();
            PopPizza();
            PopMagazin();
        }

        OracleConnection Con = new OracleConnection("DATA SOURCE = localhost:1521 / xe; PERSIST SECURITY INFO=True;USER ID = ADMINPIZZA;password=password2;");



        void popCmd()
        {
            Con.Open();
            string myquery = "select cod_comanda from comanda where id_client is not null";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
                cmdbox.Items.Add(r["cod_comanda"].ToString());
            Con.Close();
        }

        void popClient()
        {
            if (cmdbox.SelectedItem == null)
            {
                Con.Close();
                Con.Open();
                string myquery = "select id_client from client";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                OracleDataReader r = cmd.ExecuteReader();
                while (r.Read())
                    clientbox.Items.Add(r["id_client"].ToString());
                Con.Close();
            }
            else
            {
                try
                {
                    Con.Open();
                    string myquery = "select cl.id_client from client cl join comanda c on c.id_client=cl.id_client where cod_comanda=" + cmdbox.Text;
                    OracleCommand cmd = new OracleCommand(myquery, Con);
                    OracleDataReader r = cmd.ExecuteReader();
                    r.Read();
                    clientbox.Items.Add(r["id_client"].ToString());
                    Con.Close();
                }
                catch
                {
                    Con.Close();
                }
            }
        }

        void PopPizza()
        {
            Con.Open();
            string myquery = "select nume from pizza";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
                pizzabox.Items.Add(r["nume"].ToString());
            Con.Close();
        }

        void PopMagazin()
        {
            Con.Open();
            string myquery = "select nume from magazin";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
                magazinbox.Items.Add(r["nume"].ToString());
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void cmdbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientbox.Items.Clear();
            popClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CautareGrid.Rows.Clear();
                string myquery = "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                        "from oras o join magazin m on o.id_oras = m.id_oras " +
                        "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                        "join pizza p on p.id_pizza = pc.id_pizza " +
                        "join comanda c on pc.cod_comanda = c.cod_comanda " +
                        "join client cl on c.id_client = cl.id_client ";
                if (cmdbox.SelectedIndex==-1 && clientbox.SelectedIndex==-1 && magazinbox.SelectedIndex==-1 && pizzabox.SelectedIndex==-1)
                {
                    MessageBox.Show("Nu ati selectat dupa ce criterii faceti cautarea!");
                }
                if (pizzabox.SelectedIndex == -1 && clientbox.SelectedIndex==-1 && magazinbox.SelectedIndex==-1 && cmdbox.SelectedIndex!=-1)
                {
                    myquery= "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                        "from oras o join magazin m on o.id_oras = m.id_oras " +
                        "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                        "join pizza p on p.id_pizza = pc.id_pizza " +
                        "join comanda c on pc.cod_comanda = c.cod_comanda " +
                        "join client cl on c.id_client = cl.id_client " +
                        "where c.cod_comanda=" + cmdbox.Text;
                }
                if (cmdbox.SelectedIndex==-1 && pizzabox.SelectedIndex==-1 && magazinbox.SelectedIndex==-1&& clientbox.SelectedIndex!=-1)
                {
                    myquery= "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                        "from oras o join magazin m on o.id_oras = m.id_oras " +
                        "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                        "join pizza p on p.id_pizza = pc.id_pizza " +
                        "join comanda c on pc.cod_comanda = c.cod_comanda " +
                        "join client cl on c.id_client = cl.id_client " +
                        "where cl.id_client=" + clientbox.Text;
                }
                if (cmdbox.SelectedIndex==-1 && clientbox.SelectedIndex==-1 && magazinbox.SelectedIndex==-1 && pizzabox.SelectedIndex!=-1)
                {
                    myquery = "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                        "from oras o join magazin m on o.id_oras = m.id_oras " +
                        "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                        "join pizza p on p.id_pizza = pc.id_pizza " +
                        "join comanda c on pc.cod_comanda = c.cod_comanda " +
                        "join client cl on c.id_client = cl.id_client " +
                        "where p.nume='" + pizzabox.Text+"'";
                }
                if (cmdbox.SelectedIndex==-1 && clientbox.SelectedIndex==-1 && pizzabox.SelectedIndex==-1&& magazinbox.SelectedIndex!=-1)
                {
                    myquery= "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                        "from oras o join magazin m on o.id_oras = m.id_oras " +
                        "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                        "join pizza p on p.id_pizza = pc.id_pizza " +
                        "join comanda c on pc.cod_comanda = c.cod_comanda " +
                        "join client cl on c.id_client = cl.id_client " +
                        "where m.nume='" + magazinbox.Text+"'";
                }
                if (magazinbox.SelectedIndex ==-1 && pizzabox.SelectedIndex==-1 && clientbox.SelectedIndex!=-1 && cmdbox.SelectedIndex!=-1)
                {
                    myquery = "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                       "from oras o join magazin m on o.id_oras = m.id_oras " +
                       "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                       "join pizza p on p.id_pizza = pc.id_pizza " +
                       "join comanda c on pc.cod_comanda = c.cod_comanda " +
                       "join client cl on c.id_client = cl.id_client " +
                       "where c.cod_comanda=" + cmdbox.Text + "and cl.id_client="+clientbox.Text;
                }
                if (clientbox.SelectedIndex ==-1 && pizzabox.SelectedIndex ==-1 && magazinbox.SelectedIndex!=-1 && cmdbox.SelectedIndex!=-1)
                {
                    myquery = "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                       "from oras o join magazin m on o.id_oras = m.id_oras " +
                       "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                       "join pizza p on p.id_pizza = pc.id_pizza " +
                       "join comanda c on pc.cod_comanda = c.cod_comanda " +
                       "join client cl on c.id_client = cl.id_client " +
                       "where c.cod_comanda=" + cmdbox.Text + "and m.nume='"+magazinbox.Text+"'";
                }
                if (clientbox.SelectedIndex==-1 && magazinbox.SelectedIndex==-1 && pizzabox.SelectedIndex!=-1 && cmdbox.SelectedIndex!=-1)
                {
                    myquery = "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                       "from oras o join magazin m on o.id_oras = m.id_oras " +
                       "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                       "join pizza p on p.id_pizza = pc.id_pizza " +
                       "join comanda c on pc.cod_comanda = c.cod_comanda " +
                       "join client cl on c.id_client = cl.id_client " +
                       "where c.cod_comanda=" + cmdbox.Text + "and p.nume='"+pizzabox.Text+"'";
                }
                if (cmdbox.SelectedIndex==-1 && pizzabox.SelectedIndex==-1 && magazinbox.SelectedIndex!=-1 && clientbox.SelectedIndex!=-1)
                {
                    myquery = "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                       "from oras o join magazin m on o.id_oras = m.id_oras " +
                       "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                       "join pizza p on p.id_pizza = pc.id_pizza " +
                       "join comanda c on pc.cod_comanda = c.cod_comanda " +
                       "join client cl on c.id_client = cl.id_client " +
                       "where cl.id_client=" + clientbox.Text + "and m.nume='"+magazinbox.Text+"'";
                }
                if (cmdbox.SelectedIndex==-1 && magazinbox.SelectedIndex==-1 && pizzabox.SelectedIndex!=-1 && clientbox.SelectedIndex!=-1)
                {
                    myquery = "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                       "from oras o join magazin m on o.id_oras = m.id_oras " +
                       "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                       "join pizza p on p.id_pizza = pc.id_pizza " +
                       "join comanda c on pc.cod_comanda = c.cod_comanda " +
                       "join client cl on c.id_client = cl.id_client " +
                       "where cl.id_client=" + clientbox.Text + " and p.nume='"+pizzabox.Text+"'";
                }
                if (cmdbox.SelectedIndex==-1 && clientbox.SelectedIndex==-1 && pizzabox.SelectedIndex!=-1 && magazinbox.SelectedIndex!=-1)
                {
                    myquery = "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                       "from oras o join magazin m on o.id_oras = m.id_oras " +
                       "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                       "join pizza p on p.id_pizza = pc.id_pizza " +
                       "join comanda c on pc.cod_comanda = c.cod_comanda " +
                       "join client cl on c.id_client = cl.id_client " +
                       "where m.nume='" + magazinbox.Text + "' and p.nume='"+pizzabox.Text+"'";
                }
                if (cmdbox.SelectedIndex!=-1 && clientbox.SelectedIndex!=-1 && magazinbox.SelectedIndex!=-1 && pizzabox.SelectedIndex==-1)
                {
                    myquery = "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                       "from oras o join magazin m on o.id_oras = m.id_oras " +
                       "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                       "join pizza p on p.id_pizza = pc.id_pizza " +
                       "join comanda c on pc.cod_comanda = c.cod_comanda " +
                       "join client cl on c.id_client = cl.id_client " +
                       "where m.nume='" + magazinbox.Text + "' and c.cod_comanda="+cmdbox.Text+" and cl.id_client="+clientbox.Text;
                }
                if (cmdbox.SelectedIndex!=-1 && magazinbox.SelectedIndex!=-1 && pizzabox.SelectedIndex!=-1 && clientbox.SelectedIndex==-1)
                {
                    myquery = "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                      "from oras o join magazin m on o.id_oras = m.id_oras " +
                      "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                      "join pizza p on p.id_pizza = pc.id_pizza " +
                      "join comanda c on pc.cod_comanda = c.cod_comanda " +
                      "join client cl on c.id_client = cl.id_client " +
                      "where m.nume='" + magazinbox.Text + "' and c.cod_comanda=" + cmdbox.Text + " and p.nume='" + pizzabox.Text+"'";
                }
                if (cmdbox.SelectedIndex!=-1 && clientbox.SelectedIndex!=-1 && pizzabox.SelectedIndex!=-1 && magazinbox.SelectedIndex==-1)
                {
                    myquery = "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                      "from oras o join magazin m on o.id_oras = m.id_oras " +
                      "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                      "join pizza p on p.id_pizza = pc.id_pizza " +
                      "join comanda c on pc.cod_comanda = c.cod_comanda " +
                      "join client cl on c.id_client = cl.id_client " +
                      "where p.nume='" + pizzabox.Text + "' and c.cod_comanda=" + cmdbox.Text + " and cl.id_client=" + clientbox.Text;
                }
                if (clientbox.SelectedIndex!=-1 && pizzabox.SelectedIndex!=-1 && magazinbox.SelectedIndex!=-1 && cmdbox.SelectedIndex==-1)
                {
                    myquery = "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                      "from oras o join magazin m on o.id_oras = m.id_oras " +
                      "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                      "join pizza p on p.id_pizza = pc.id_pizza " +
                      "join comanda c on pc.cod_comanda = c.cod_comanda " +
                      "join client cl on c.id_client = cl.id_client " +
                      "where m.nume='" + magazinbox.Text + "' and p.nume='" + pizzabox.Text + "' and cl.id_client=" + clientbox.Text;
                }
                if (clientbox.SelectedIndex != -1 && pizzabox.SelectedIndex != -1 && magazinbox.SelectedIndex != -1 && cmdbox.SelectedIndex != -1)
                {
                    myquery = "select o.nume_oras, m.nume \"Magazin\", p.nume \"Pizza\", c.cod_comanda,cl.id_client, cl.nume, cl.prenume " +
                      "from oras o join magazin m on o.id_oras = m.id_oras " +
                      "join pizza_comandata pc on pc.id_magazin = m.id_magazin " +
                      "join pizza p on p.id_pizza = pc.id_pizza " +
                      "join comanda c on pc.cod_comanda = c.cod_comanda " +
                      "join client cl on c.id_client = cl.id_client " +
                      "where m.nume='" + magazinbox.Text + "' and p.nume='" + pizzabox.Text + "' and cl.id_client=" + clientbox.Text+" and c.cod_comanda="+cmdbox.Text;
                }
                Con.Open();
                OracleCommand cmd = new OracleCommand(myquery, Con);
                OracleDataReader r = cmd.ExecuteReader();
                int i = 0;
                while (r.Read())
                {
                    string oras = r["nume_oras"].ToString();
                    string mag = r["Magazin"].ToString();
                    string pizza = r["Pizza"].ToString();
                    string com = r["cod_comanda"].ToString();
                    string cl = r["id_client"].ToString();
                    string num = r["nume"].ToString();
                    string pren = r["prenume"].ToString();
                    CautareGrid.Rows.Insert(i++, oras, mag, pizza, com, cl, num, pren);
                }
                CautareGrid.Visible = true;
                Con.Close();
            }
            catch
            {
                MessageBox.Show("It failed!");
                Con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmdbox.SelectedIndex = -1;
            pizzabox.SelectedIndex = -1;
            clientbox.SelectedIndex = -1;
            magazinbox.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Meniu men = new Meniu();
            men.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CautareGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
