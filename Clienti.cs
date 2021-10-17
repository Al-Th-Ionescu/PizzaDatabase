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
    public partial class Clienti : Form
    {
        public Clienti()
        {
            InitializeComponent();
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
                string Myquery = "select * from client order by "+items.Text+" "+ord.Text;
                OracleDataAdapter da = new OracleDataAdapter(Myquery,Con);
                OracleCommandBuilder builder = new OracleCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ClientGridView.DataSource = ds.Tables[0];
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
               string myquery;
               myquery = "insert into client values(id_client_pk_seq.NEXTVAL,'" + NUME.Text + "','" + PRENUME.Text + "','" + TELEFON.Text + "')";
               OracleCommand cmd = new OracleCommand(myquery, Con);
              cmd.ExecuteNonQuery();
              MessageBox.Show("Clientul a fost adaugat!");
              Con.Close();
              populate();
            }
            catch
            {
                MessageBox.Show("Adaugarea clientului a esuat!");
                Con.Close();
            }
        }
       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clienti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.dataSet1.CLIENT);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ID_CLIENT.Text.Length != 0)
            {
                Con.Open();
                string myquery = "delete from client where id_client=" + ID_CLIENT.Text + "";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Clientul a fost sters cu succes!");
                Con.Close();
                populate(); 
            }
            else
            {
                MessageBox.Show("Nu a fost niciun client selectat!");
            }
        }

        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_CLIENT.Text = ClientGridView.SelectedRows[0].Cells[0].Value.ToString();
            NUME.Text = ClientGridView.SelectedRows[0].Cells[1].Value.ToString();
            PRENUME.Text = ClientGridView.SelectedRows[0].Cells[2].Value.ToString();
            TELEFON.Text = ClientGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                OracleCommand cmd = new OracleCommand("update client set nume='"+NUME.Text+"', prenume='"+PRENUME.Text+"', telefon='"+TELEFON.Text+"' where id_client="+ID_CLIENT.Text+"", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datele clientului au fost updatate!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Editarea clientului a esuat!");
                Con.Close();
            }
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
            ID_CLIENT.Clear();
            NUME.Clear();
            PRENUME.Clear();
            TELEFON.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Adrese adr = new Adrese();
            adr.Show();
            this.Hide();
        }
    }
    }

