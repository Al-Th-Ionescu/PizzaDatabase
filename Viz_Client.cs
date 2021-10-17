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
    public partial class Viz_Client : Form
    {
        public Viz_Client()
        {
            InitializeComponent();
            GetName();
            if (Client_prev.id_client =="")
            {
                PopOras();
            }
            GetAdresa();
            adresa();
        }
        OracleConnection Con = new OracleConnection("DATA SOURCE = localhost:1521 / xe; PERSIST SECURITY INFO=True;USER ID = ADMINPIZZA;password=password2;");
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void Viz_Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet4.ORAS' table. You can move, or remove it, as needed.
            this.oRASTableAdapter.Fill(this.dataSet4.ORAS);
            pizza();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                blocbox.ReadOnly = false;
                scarabox.ReadOnly = false;
                apartamentbox.ReadOnly = false;
                etajbox.ReadOnly = false;
            }
            else
            {
                blocbox.ReadOnly = true;
                scarabox.ReadOnly = true;
                apartamentbox.ReadOnly = true;
                etajbox.ReadOnly = true;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void pizza()
        {
            try
            {
                Con.Open();
                string myquery;
                myquery = "select nume,pret,blat from pizza p";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                OracleDataReader r = cmd.ExecuteReader();
                PizzaView.Rows.Clear();
                int i = 0;
                while(r.Read())
                {
                    string tipPizza = r["nume"].ToString();
                    string pretPizza = r["pret"].ToString();
                    string blat = r["blat"].ToString();
                    PizzaView.Rows.Insert(i++, tipPizza,pretPizza,blat);
                }      
                Con.Close();
            }
            catch
            {
                Con.Close();
            }
        }
        
        private void orascombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CosCumparaturi.Rows.Clear();
            j = 0;
            total = 0;
            totalplata.Text = total.ToString();
            Pop();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Doriti sa finalizati comanda?", "Finalizare comanda", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {  try
                {
                    Con.Open();
                         if (Client_prev.id_client == "")
                    {
                        string myquery1 = "insert into client values(id_client_pk_seq.NEXTVAL,'" + NumeBox.Text + "','" + PrenumeBox.Text + "','" + TelefonBox.Text + "')";

                        OracleCommand cmd1 = new OracleCommand(myquery1, Con);
                        cmd1.ExecuteNonQuery();
                    }
                    string myquery3;
                    if (label25.Visible == false)
                    {
                        string myquery2;
                        if (checkBox1.Checked)
                        {
                            if (etajbox.Text != "P")
                            {
                                if (Client_prev.id_client == "")
                                    myquery2 = "insert into adresa values(id_adresa_pk_seq.NEXTVAL,id_client_pk_seq.CURRVAL,'" + orascombo.Text + "','" + StradaBox.Text + "','" + NrStradaBox.Text + "','" + blocbox.Text + "','" + scarabox.Text + "'," + etajbox.Text + "," + apartamentbox.Text + ")";
                                else
                                    myquery2 = "insert into adresa values(id_adresa_pk_seq.NEXTVAL," + Client_prev.id_client + ",'" + orascombo.Text + "','" + StradaBox.Text + "','" + NrStradaBox.Text + "','" + blocbox.Text + "','" + scarabox.Text + "'," + etajbox.Text + "," + apartamentbox.Text + ")";
                            }
                            else
                            {
                                if (Client_prev.id_client == "")
                                    myquery2 = "insert into adresa values(id_adresa_pk_seq.NEXTVAL,id_client_pk_seq.CURRVAL,'" + orascombo.Text + "','" + StradaBox.Text + "','" + NrStradaBox.Text + "','" + blocbox.Text + "','" + scarabox.Text + "', null ," + apartamentbox.Text + ")";
                                else
                                    myquery2 = "insert into adresa values(id_adresa_pk_seq.NEXTVAL," + Client_prev.id_client + ",'" + orascombo.Text + "','" + StradaBox.Text + "','" + NrStradaBox.Text + "','" + blocbox.Text + "','" + scarabox.Text + "', null ," + apartamentbox.Text + ")";
                            }
                        }
                        else
                            if (Client_prev.id_client == "")
                            myquery2 = "insert into adresa (ID_ADRESA,ID_CLIENT,LOCALITATE,STRADA,NUMAR_STRADA,BLOC,SCARA,ETAJ,APARTAMENT) values (id_adresa_pk_seq.NEXTVAL,id_client_pk_seq.CURRVAL,'" + orascombo.Text + "','" + StradaBox.Text + "','" + NrStradaBox.Text + "',null,null,null,null)";
                        else
                            myquery2 = "insert into adresa (ID_ADRESA,ID_CLIENT,LOCALITATE,STRADA,NUMAR_STRADA,BLOC,SCARA,ETAJ,APARTAMENT) values (id_adresa_pk_seq.NEXTVAL," + Client_prev.id_client + ",'" + orascombo.Text + "','" + StradaBox.Text + "','" + NrStradaBox.Text + "',null,null,null,null)";
                        OracleCommand cmd2 = new OracleCommand(myquery2, Con);
                        cmd2.ExecuteNonQuery();
                    }
                    if (Client_prev.id_client == "")
                        myquery3 = "insert into comanda values (cod_comanda_pk_seq.NEXTVAL, id_client_pk_seq.CURRVAL,sysdate)";
                    else
                        myquery3 = "insert into comanda values (cod_comanda_pk_seq.NEXTVAL," + Client_prev.id_client + ",sysdate)";
                    OracleCommand cmd3 = new OracleCommand(myquery3, Con);
                    
                    cmd3.ExecuteNonQuery();
                    for (int k = 0; k < CosCumparaturi.Rows.Count; k++)
                    {
                        string interm5 = "select id_pizza from pizza where nume='" + CosCumparaturi.Rows[k].Cells[0].Value.ToString() + "'";
                        OracleCommand intercmd = new OracleCommand(interm5, Con);
                        OracleDataReader read = intercmd.ExecuteReader();
                        read.Read();
                        string var = read["id_pizza"].ToString();
                        string myquery4 = "insert into pizza_comandata values ("+id_mag.Text.Trim()+ "," + var.Trim() + ",cod_comanda_pk_seq.CURRVAL," + CosCumparaturi.Rows[k].Cells[1].Value.ToString() + ")";
                        OracleCommand cmd4 = new OracleCommand(myquery4, Con);
                        cmd4.ExecuteNonQuery();
                    }
                    if (Client_prev.id_client == "")
                    {
                        string myquery = "select id_client_pk_seq.CURRVAL from dual";
                        OracleCommand cmmd = new OracleCommand(myquery, Con);
                        OracleDataReader rea = cmmd.ExecuteReader();
                        rea.Read();
                        id_box.Text = rea["CURRVAL"].ToString();
                        Con.Close();
                    }
                    MessageBox.Show("Comanda efectuata cu succes!");
                    if (Client_prev.id_client=="")
                    MessageBox.Show("Aveti codul client " + id_box.Text+"!");
                }
                catch
                {
                    MessageBox.Show("Comanda nu a reusit!");
                    Con.Close();
                }
                }
        else if (dialogResult == DialogResult.No)
            {

            }
    }

        void id_maga()
        {
            string myquery = "select id_magazin from magazin where nume ='" + MagazinBox.Text + "'";
            Con.Open();
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            r.Read();
            id_mag.Text = r["id_magazin"].ToString();
            Con.Close();
        }

        private void PizzaView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TipPizzaBox.Text = PizzaView.SelectedRows[0].Cells[0].Value.ToString();
            pret_buc.Text = PizzaView.SelectedRows[0].Cells[1].Value.ToString();
        }
        int j = 0;
        double total = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int cant;
                double pret, cost;
                int.TryParse(CantitatePizza.Text, out cant);
                double.TryParse(pret_buc.Text, out pret);
                cost = cant * pret;
                total = total + cost;
                if (cant > 0 && TipPizzaBox.Text !="")
                CosCumparaturi.Rows.Insert(j++, TipPizzaBox.Text, CantitatePizza.Text, cost );
                totalplata.Text= total.ToString();
            }
            catch
            {
                MessageBox.Show("Nu ati reusit sa adaugati in cos!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kost.Text = CosCumparaturi.SelectedRows[0].Cells[2].Value.ToString();
            double val;
            double.TryParse(kost.Text, out val);
            int RowIndex = CosCumparaturi.CurrentCell.RowIndex;
            CosCumparaturi.Rows.RemoveAt(RowIndex);
            total = total - val;
            totalplata.Text = total.ToString();
            j--;
        }

        private void MagazinBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_maga();
        }

        void Pop()
        {
            try
            {
                Con.Open();
                string query = "select m.nume from magazin m join oras o on o.id_oras = m.id_oras where o.nume_oras ='" + orascombo.Text + "'";
                OracleCommand cmd = new OracleCommand(query, Con);
                OracleDataReader r = cmd.ExecuteReader();
                MagazinBox.Items.Clear();
                while (r.Read())
                {
                    string Magazin = r["nume"].ToString();
                    MagazinBox.Items.Add(Magazin);
                }
                Con.Close();
            }
            catch
            {
                Con.Close();  
            }
        }

        private void pret_buc_TextChanged(object sender, EventArgs e)
        {

        }

        void GetName()
        {
            if (Client_prev.id_client != "")
            {
                Con.Open();
                string query = "select nume,prenume,telefon from client where id_client=" + Client_prev.id_client + "";
                OracleCommand comanda = new OracleCommand(query, Con);
                OracleDataReader re = comanda.ExecuteReader();
                re.Read();
                NumeBox.Text = re["NUME"].ToString();
                PrenumeBox.Text = re["PRENUME"].ToString();
                TelefonBox.Text = re["TELEFON"].ToString();
                Con.Close();
                NumeBox.ReadOnly = true;
                PrenumeBox.ReadOnly = true;
                TelefonBox.ReadOnly = true;
            }
        }
        void adresa()
        {
            if (Client_prev.id_client!="")
            {
                label25.Visible = true;
                label14.Visible = false;
                checkBox1.Visible = false;
                label10.Visible = false;
                blocbox.Visible = false;
                label11.Visible = false;
                scarabox.Visible = false;
                label12.Visible = false;
                label20.Visible = false;
                etajbox.Visible = false;
                label13.Visible = false;
                apartamentbox.Visible = false;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void GetAdresa()
        {
            if (Client_prev.id_client != "")
            {
                Con.Open();
                string myquery = "select a.strada,a.numar_strada, o.nume_oras from adresa a join oras o on o.nume_oras=a.localitate where id_client=" + Client_prev.id_client + "";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                OracleDataReader r = cmd.ExecuteReader();
                r.Read();
                StradaBox.ReadOnly = true;
                NrStradaBox.ReadOnly = true;
                StradaBox.Text = r["strada"].ToString();
                NrStradaBox.Text = r["numar_strada"].ToString();
                orascombo.Items.Add(r["nume_oras"].ToString());
                Con.Close();
            }
        }

        void PopOras()
        {
            Con.Open();
            string myquery = "select nume_oras from ORAS";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                orascombo.Items.Add(r["nume_oras"]);
            }
            Con.Close();
        }


        private void label25_Click(object sender, EventArgs e)
        {
            if (Client_prev.id_client != "")
            {
                orascombo.Items.Clear();
                StradaBox.ReadOnly = false;
                StradaBox.Clear();
                NrStradaBox.ReadOnly = false;
                NrStradaBox.Clear();
                label25.Visible = false;
                label14.Visible = true;
                checkBox1.Visible = true;
                label10.Visible = true;
                blocbox.Visible = true;
                label11.Visible = true;
                scarabox.Visible = true;
                label12.Visible = true;
                label20.Visible = true;
                etajbox.Visible = true;
                label13.Visible = true;
                PopOras();
                apartamentbox.Visible = true;
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            Client_prev viz = new Client_prev();
            viz.Show();
            this.Hide();
        }
    }
}
