using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTIONBAR
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
            Application.Run(new Form1());
            //    Journal.SommeDepart = 15000;
            //    Journal.Recette = 1600;
            //    Journal.Vendu(220);
            //    Journal.Vendu(250);
            //    Journal.Sauvegarder();
            

        }
    }
}
