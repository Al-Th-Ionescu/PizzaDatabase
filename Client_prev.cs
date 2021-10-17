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
    public partial class Client_prev : Form
    {
        public Client_prev()
        {
            InitializeComponent();
        }
        OracleConnection Con = new OracleConnection("DATA SOURCE = localhost:1521 / xe; PERSIST SECURITY INFO=True;USER ID = ADMINPIZZA;password=password2;");
        public static string id_client = "";
        private void Client_prev_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClientCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ClientCheck.Checked)
            {
                ClientBox.ReadOnly = false;
                TelefonBox.ReadOnly = false;
            }
            else
            {
                ClientBox.ReadOnly = true;
                TelefonBox.ReadOnly = true;
            }                
        }

        void GetClient()
        {
            if (ClientCheck.Checked)
            {
                Con.Open();
                string myquery = "select telefon from client where id_client =" + ClientBox.Text + "";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                OracleDataReader r = cmd.ExecuteReader();
                try
                {
                    r.Read();
                    TestTelefon.Text = r["TELEFON"].ToString();
                }
                catch
                {
                    MessageBox.Show("Nu exista niciun client cu id-ul introdus!");
                }
                Con.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (ClientCheck.Checked)
                GetClient();
            try
            {
                if (TelefonBox.Text == TestTelefon.Text)
                {
                    id_client = ClientBox.Text.Trim();
                    Viz_Client v = new Viz_Client();
                    v.Show();
                    this.Hide();
                }
                else if (TestTelefon.Text != "")
                    MessageBox.Show("Numarul de telefonul nu se potriveste!");
            }
            catch
            {
                
            }
        }
        
        private void TelefonBox_TextChanged(object sender, EventArgs e)
        {
        }

        void ForgetClient()
        {
            if (ClientCheck.Checked)
            {
                string mystring = "select id_client from client where telefon=" + TelefonBox.Text + "";
                Con.Open();
                OracleCommand cmd = new OracleCommand(mystring, Con);
                OracleDataReader r = cmd.ExecuteReader();
                try
                {
                    r.Read();
                    ClientTest.Text = r["id_client"].ToString();
                }
                catch
                {
                    MessageBox.Show("Numarul de telefon nu corespunde niciunui client!");
                }
                Con.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            IDSHOW.Visible = true;
            ClientTest.Visible = true;
            ForgetClient();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Intrare intr = new Intrare();
            intr.Show();
            this.Hide();
        }
    }
}
