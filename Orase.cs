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
    public partial class Orase : Form
    {
        public Orase()
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
                string Myquery = "select * from oras order by "+items.Text+" "+ord.Text;
                OracleDataAdapter da = new OracleDataAdapter(Myquery, Con);
                OracleCommandBuilder builder = new OracleCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OraseGrid.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
                Con.Close();
            }

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
                myquery = "insert into oras values (oras_pk_seq.NEXTVAL, '" + nume_oras_box.Text + "','" + judet_box.Text + "')";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Orasul a fost adaugat!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Adaugarea unui oras a esuat!");
                Con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "delete from oras where id_oras=" + id_oras_box.Text + "";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Orasul a fost sters cu succes!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Nu a fost niciun oras selectat!");
                Con.Close();
            }
        }

        private void Orase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet5.ORAS' table. You can move, or remove it, as needed.
            this.oRASTableAdapter1.Fill(this.dataSet5.ORAS);
            

        }

        private void id_oras_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void OraseGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id_oras_box.Text = OraseGrid.SelectedRows[0].Cells[0].Value.ToString();
            nume_oras_box.Text = OraseGrid.SelectedRows[0].Cells[1].Value.ToString();
            judet_box.Text = OraseGrid.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                OracleCommand cmd = new OracleCommand("update oras set nume_oras='" + nume_oras_box.Text + "', judet='" + judet_box.Text + "' where id_oras=" + id_oras_box.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Orasul a fost updatat!");
                Con.Close();
                populate();
            }
            catch
            {
                MessageBox.Show("Editarea unui oras a esuat!");
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
            id_oras_box.Clear();
            nume_oras_box.Clear();
            judet_box.Clear();
        }
    }
}
