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
    public partial class Adrese : Form
    {
        public Adrese()
        {
            InitializeComponent();
            popClient();
            locPop();
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
                string Myquery = "select * from adresa order by "+items.Text+" "+ord.Text ;
                OracleDataAdapter da = new OracleDataAdapter(Myquery, Con);
                OracleCommandBuilder builder = new OracleCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                AdresaGrid.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                Con.Close();
            }

        }

        void popClient()
        {
            Con.Open();
            string myquery = "select nume || ' ' || prenume \"Cl\" from client";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
                ClientBox.Items.Add(r["Cl"].ToString());
            Con.Close();
        }

        void locPop()
        {
            Con.Open();
            string myquery = "select distinct o.nume_oras from oras o join magazin m on m.id_oras=o.id_oras";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
                LocalitateBox.Items.Add(r["nume_oras"].ToString());
            Con.Close();
        }

        private void Bloc_Click(object sender, EventArgs e)
        {

        }

        private void ScaraBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adrese_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet9.ADRESA' table. You can move, or remove it, as needed.
            this.aDRESATableAdapter.Fill(this.dataSet9.ADRESA);

        }

        void SetClient()
        {
            Con.Open();
            string myquery = "select nume||' '||prenume \"Cl\" from client where id_client=" + AdresaGrid.SelectedRows[0].Cells[1].Value.ToString();
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            r.Read();
            ClientBox.SelectedItem = r["Cl"].ToString();
            Con.Close();
        }

        void GetClientId()
        {
            Con.Close();
            if (ClientBox.SelectedIndex != -1)
            {
                Con.Open();
                string myquery = "select id_client from client where (nume||' '||prenume)='" + ClientBox.Text + "'";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                OracleDataReader r = cmd.ExecuteReader();
                r.Read();
                SecretBox.Text = r["id_client"].ToString();
                Con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_adresa.Text = AdresaGrid.SelectedRows[0].Cells[0].Value.ToString();
            SetClient();
            LocalitateBox.SelectedItem = AdresaGrid.SelectedRows[0].Cells[2].Value.ToString();
            stradabox.Text = AdresaGrid.SelectedRows[0].Cells[3].Value.ToString();
            nr_strada.Text = AdresaGrid.SelectedRows[0].Cells[4].Value.ToString();
            blocbox.Text = AdresaGrid.SelectedRows[0].Cells[5].Value.ToString();
            ScaraBox.Text = AdresaGrid.SelectedRows[0].Cells[6].Value.ToString();
            etaj_box.Text = AdresaGrid.SelectedRows[0].Cells[7].Value.ToString();
            Apartament_Box.Text = AdresaGrid.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void ClientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetClientId();
        }

        private void SecretBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecretBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            id_adresa.Clear();
            ClientBox.SelectedIndex = -1;
            LocalitateBox.SelectedIndex = -1;
            stradabox.Clear();
            nr_strada.Clear();
            blocbox.Clear();
            ScaraBox.Clear();
            etaj_box.Clear();
            Apartament_Box.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clienti cl = new Clienti();
            cl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClientBox.SelectedIndex != -1 && LocalitateBox.SelectedIndex != -1 && stradabox.Text.Length != 0 && nr_strada.Text.Length != 0)
                {
                    Con.Open();
                    string myquery = "insert into v_adresa(id_adresa,id_client,localitate,strada,numar_strada,bloc,scara,etaj,apartament)" +
                            " values(id_adresa_pk_seq.NEXTVAL," + SecretBox.Text + ",'" + LocalitateBox.Text + "','" + stradabox.Text + "'," + nr_strada.Text + ", null,null,null,null)";
                    if (blocbox.Text.Length != 0 && ScaraBox.Text.Length != 0 && etaj_box.Text.Length != 0 && Apartament_Box.Text.Length != 0)
                    {
                        myquery = "insert into v_adresa(id_adresa,id_client,localitate,strada,numar_strada,bloc,scara,etaj,apartament)" +
                            " values(id_adresa_pk_seq.NEXTVAL," + SecretBox.Text + ",'" + LocalitateBox.Text + "','" + stradabox.Text + "'," + nr_strada.Text + ",'" + blocbox.Text + "','" + ScaraBox.Text + "'," + etaj_box.Text + "," + Apartament_Box.Text + ")";
                    }
                    if (etaj_box.Text.Length == 0 && blocbox.Text.Length != 0 && ScaraBox.Text.Length != 0 && Apartament_Box.Text.Length != 0)
                    {
                        myquery = "insert into v_adresa(id_adresa,id_client,localitate,strada,numar_strada,bloc,scara,etaj,apartament)" +
                            " values(id_adresa_pk_seq.NEXTVAL," + SecretBox.Text + ",'" + LocalitateBox.Text + "','" + stradabox.Text + "'," + nr_strada.Text + ",'" + blocbox.Text + "','" + ScaraBox.Text + "', null ," + Apartament_Box.Text + ")";
                    }
                    OracleCommand cmd = new OracleCommand(myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Adresa a fost adaugata!");
                    Con.Close();
                    populate();

                }
            }
            catch
            {
                MessageBox.Show("Adaugarea adresei a esuat!");
                Con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "delete from adresa where id_adresa not in( " +
                "select min(id_adresa) " +
                "from v_adresa " +
                "group by id_client)";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "delete from v_adresa where id_adresa=" + id_adresa.Text;
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populate();
                MessageBox.Show("Adresa a fost stearsa cu succes!");
                
            }
            catch
            {
                MessageBox.Show("Stergerea unei adrese a esuat!");
                Con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "update v_adresa set id_client=" + SecretBox.Text + ", localitate='" + LocalitateBox.Text + "', strada='" + stradabox.Text + "', numar_strada=" + nr_strada.Text + ", bloc='" + blocbox.Text + "', scara='" + ScaraBox.Text + "',etaj=" + etaj_box.Text + ",apartament=" + Apartament_Box.Text + " where id_adresa=" + id_adresa.Text;
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Adresa a fost updatata cu succes!");
                populate();
            }
            catch
            {
                Con.Close();
                MessageBox.Show("Updatarea adresei a esuat!");
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
    }
    
}
