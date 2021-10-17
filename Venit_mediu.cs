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
    public partial class Venit_mediu : Form
    {
        public Venit_mediu()
        {
            InitializeComponent();
            popJud();
            PopOras();
        }

        OracleConnection Con = new OracleConnection("DATA SOURCE = localhost:1521 / xe; PERSIST SECURITY INFO=True;USER ID = ADMINPIZZA;password=password2;");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        void popJud()
        {
            Con.Open();
            string myquery = "select distinct judet from oras";
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read()) 
            {   
                if (r["judet"].ToString().Length!=0)
                JudBox.Items.Add(r["judet"].ToString());
            }
            Con.Close();
        }

        void PopOras()
        {
            OrasBox.Items.Clear();
            if (JudBox.SelectedIndex != -1)
            {
                Con.Open();
                string myquery = "select nume_oras from oras where judet='" + JudBox.Text + "'";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                OracleDataReader r = cmd.ExecuteReader();
                while (r.Read())
                    OrasBox.Items.Add(r["nume_oras"].ToString());
                Con.Close();
            }
            else
            {
                Con.Open();
                string myquery = "select nume_oras from oras";
                OracleCommand cmd = new OracleCommand(myquery, Con);
                OracleDataReader r = cmd.ExecuteReader();
                while (r.Read())
                    OrasBox.Items.Add(r["nume_oras"].ToString());
                Con.Close();
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void JudBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopOras();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VMediu.Rows.Clear();
            Con.Open();
            string myquery = "select * from v_angajati";
            if (JudBox.SelectedIndex==-1 && OrasBox.SelectedIndex!=-1 && SalMedMIN.Text.Length==0)
            {
                myquery = "select * from v_angajati where nume_oras='" + OrasBox.Text + "'";
            }
            if (JudBox.SelectedIndex==-1 && OrasBox.SelectedIndex==-1 && SalMedMIN.Text.Length!=0)
            {
                myquery = "select * from v_angajati where \"Salariu mediu\">" + SalMedMIN.Text;
            }    
            if (JudBox.SelectedIndex!= -1 && OrasBox.SelectedIndex==-1 && SalMedMIN.Text.Length==0)
            {
                myquery = "select * from v_angajati where judet='" + JudBox.Text + "'";
            }
            if(JudBox.SelectedIndex!=-1 && OrasBox.SelectedIndex!=-1 && SalMedMIN.Text.Length==0)
            {
                myquery = "select * from v_angajati where judet='" + JudBox.Text + "' and nume_oras='" + OrasBox.Text + "'";
            }
            if (JudBox.SelectedIndex!=-1 && OrasBox.SelectedIndex==-1 && SalMedMIN.Text.Length!=0)
            {
                myquery = " select * from v_angajati where judet='" + JudBox.Text + "' and \"Salariu mediu\">" + SalMedMIN.Text;
            }
            if (JudBox.SelectedIndex != -1 && OrasBox.SelectedIndex != -1 && SalMedMIN.Text.Length != 0)
            {
                myquery = "select * from v_angajati where judet='" + JudBox.Text + "' and nume_oras='" + OrasBox.Text + "' and \"Salariu mediu\">" + SalMedMIN.Text;
            }
            if (JudBox.SelectedIndex==-1 && OrasBox.SelectedIndex!=-1 && SalMedMIN.Text.Length!=0)
            {
                myquery = " select * from v_angajati where nume_oras='" + OrasBox.Text + "' and \"Salariu mediu\">" + SalMedMIN.Text;
            }
            OracleCommand cmd = new OracleCommand(myquery, Con);
            OracleDataReader r = cmd.ExecuteReader();
            int i = 0;
            while (r.Read())
            {
                string judet = r["judet"].ToString();
                string oras = r["nume_oras"].ToString();
                string sal_med = r["Salariu mediu"].ToString();
                VMediu.Rows.Insert(i++, judet, oras, sal_med);
            }
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Meniu men = new Meniu();
            men.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JudBox.SelectedIndex = -1;
            OrasBox.SelectedIndex = -1;
            SalMedMIN.Clear();
        }
    }
}
