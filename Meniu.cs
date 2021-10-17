using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazeDeDate
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Angajati ang = new Angajati();
            ang.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orase o = new Orase();
            o.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clienti c = new Clienti();
            c.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Comenzi co = new Comenzi();
            co.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pizza p = new Pizza();
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Magazine mag = new Magazine();
            mag.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pizza_comandata pc = new Pizza_comandata();
            pc.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Caut caut = new Caut();
            caut.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Tot_incasari tot = new Tot_incasari();
            tot.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Vanzari vz = new Vanzari();
            vz.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Venit_mediu v_med = new Venit_mediu();
            v_med.Show();
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Intrare intr = new Intrare();
            intr.Show();
            this.Hide();
        }
    }
}
