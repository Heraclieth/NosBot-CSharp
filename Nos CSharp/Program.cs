using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Nos_CSharp
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Process[] myProcess = Process.GetProcessesByName("nostalex.dat");

            if (myProcess.Length != 0)
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Nostalex.dat not found !");
            }

        }
    }
}
