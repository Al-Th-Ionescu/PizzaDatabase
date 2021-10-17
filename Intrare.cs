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
    public partial class Intrare : Form
    {
        public Intrare()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogAdmin men = new LogAdmin();
            men.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client_prev c = new Client_prev();
            c.Show();
            this.Hide();
        }
    }
}
