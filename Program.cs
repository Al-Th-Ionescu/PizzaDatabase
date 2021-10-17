using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazeDeDate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
          /*  Application.Run(new Intrare());
            Application.Run(new Viz_Client());
            Application.Run(new Meniu());
            Application.Run(new Clienti());
            Application.Run(new Comenzi());
            Application.Run(new Pizza());
            Application.Run(new Client_prev());
        */}
    }
}
