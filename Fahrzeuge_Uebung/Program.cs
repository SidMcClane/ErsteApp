using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrzeuge_Uebung {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            Fahrrad mountainbike = new Fahrrad(66.5f, 8.8f, 80.4f, 20.5f);
            Motorrad hondy = new Motorrad(160, 56, 90, 220, 130);
            Pkw meinAuto = new Pkw(5, 120, 88, 1200, 1500, 300);
            Lkw truck = new Lkw(18.6f, 80, 500, 20000, 40000, 20000);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }
    }
}
