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
    public partial class Vanzari : Form
    {
        public Vanzari()
        {
            InitializeComponent();
            popOras();
        }

        OracleConnection Con = new OracleConnection("DATA SOURCE = localhost:1521 / xe; PERSIST SECURITY INFO=True;USER ID = ADMINPIZZA;password=password2;");


        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void popOras()
        {
            Con.Open();
            string myquery = "select nume_oras from oras";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
                OrasBox.Items.Add(r["nume_oras"]).ToString();
            Con.Close();
        }

        void popMagazin()
        {
            Con.Open();
            string myquery = "select m.nume from magazin m join oras o on o.id_oras=m.id_oras where o.nume_oras='" + OrasBox.Text + "'";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                magazinbox.Items.Add(r["nume"].ToString());
            }
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Meniu men = new Meniu();
            men.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vanzarigrid.Rows.Clear();
            Con.Open();
            string myquery = "select o.nume_oras, m.nume, sum(pc.cantitate) \"Pizza vanduta\" " +
                "from magazin m join pizza_comandata pc on m.id_magazin = pc.id_magazin join oras o on o.id_oras = m.id_oras " +
                "group by o.nume_oras, m.nume";
            if (magazinbox.SelectedIndex == -1 && vnz_min.TextLength == 0 && OrasBox.SelectedIndex != -1)
            {
                myquery = "select o.nume_oras, m.nume, sum(pc.cantitate) \"Pizza vanduta\" " +
                "from magazin m join pizza_comandata pc on m.id_magazin = pc.id_magazin join oras o on o.id_oras = m.id_oras " +
                "group by o.nume_oras, m.nume " +
                "having o.nume_oras='"+OrasBox.Text+"'";
            }
            if (magazinbox.SelectedIndex != -1 && vnz_min.TextLength == 0 && OrasBox.SelectedIndex != -1)
            {
                myquery = "select o.nume_oras, m.nume, sum(pc.cantitate) \"Pizza vanduta\" " +
                "from magazin m join pizza_comandata pc on m.id_magazin = pc.id_magazin join oras o on o.id_oras = m.id_oras " +
                "group by o.nume_oras, m.nume " +
                "having o.nume_oras='" + OrasBox.Text + "' and m.nume='"+magazinbox.Text+"'";
            }
            if (OrasBox.SelectedIndex != -1 && magazinbox.SelectedIndex != -1 && vnz_min.TextLength != 0)
            {
                myquery = myquery = "select o.nume_oras, m.nume, sum(pc.cantitate) \"Pizza vanduta\" " +
                "from magazin m join pizza_comandata pc on m.id_magazin = pc.id_magazin join oras o on o.id_oras = m.id_oras " +
                "group by o.nume_oras, m.nume " +
                    "having o.nume_oras = '" + OrasBox.Text + "' and m.nume='" + magazinbox.Text + "' and sum(pc.cantitate) >=" + vnz_min.Text;
            }
            if (OrasBox.SelectedIndex != -1 && vnz_min.TextLength != 0 && magazinbox.SelectedIndex == -1)
            {
                myquery = myquery = "select o.nume_oras, m.nume, sum(pc.cantitate) \"Pizza vanduta\" " +
                "from magazin m join pizza_comandata pc on m.id_magazin = pc.id_magazin join oras o on o.id_oras = m.id_oras " +
                "group by o.nume_oras, m.nume " +
                  "having o.nume_oras = '" + OrasBox.Text + "' and sum(pc.cantitate) >=" + vnz_min.Text;
            }
            if (OrasBox.SelectedIndex == -1 && magazinbox.SelectedIndex == -1 && vnz_min.TextLength != 0)
            {
                myquery = myquery = "select o.nume_oras, m.nume, sum(pc.cantitate) \"Pizza vanduta\" " +
                "from magazin m join pizza_comandata pc on m.id_magazin = pc.id_magazin join oras o on o.id_oras = m.id_oras " +
                "group by o.nume_oras, m.nume " +
                 "having sum(pc.cantitate) >=" + vnz_min.Text;
            }
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            int i = 0;
            while (r.Read())
            {
                string oras = r["nume_oras"].ToString();
                string magazin = r["nume"].ToString();
                string total = r["Pizza vanduta"].ToString();
                vanzarigrid.Rows.Insert(i++, oras, magazin, total);
            }
            Con.Close();
        }

        private void OrasBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            magazinbox.Items.Clear();
            popMagazin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrasBox.SelectedIndex = -1;
            magazinbox.SelectedIndex = -1;
            vnz_min.Clear();
        }

        private void vanzarigrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
