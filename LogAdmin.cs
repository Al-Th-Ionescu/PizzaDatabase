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
    public partial class LogAdmin : Form
    {
        public LogAdmin()
        {
            InitializeComponent();
            usernamebox.Text = "AdminPizza";
            passwordbox.Text = "Parola123";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernamebox.Text != "AdminPizza" || passwordbox.Text != "Parola123")
                MessageBox.Show("ID Admin sau parola introduse incorect!");
            else
            {
                Meniu m = new Meniu();
                m.Show();
                this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Intrare intr = new Intrare();
            intr.Show();
            this.Hide();
        }
    }
}
