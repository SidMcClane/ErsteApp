using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoogeschaeft_26._11._2021 {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            
            // ************* Forms anzeigen ***************
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
            
            Console.WriteLine("" +
                "Welches Tier willst du haben?\n" +
                "[1] Fisch\n" +
                "[2] Vogel\n" +
                "[3] Reptilie\n");

            string auswahl = Console.ReadLine();

            switch (auswahl) {
                case "1":
                    imputFisch();
                    return;
                case "2":

                    return;
                case "3":

                    return;
                default:
                    break;
            }




        }




        // Funktionen
        public static void imputFisch() {

            Console.WriteLine("Anzahl Rückenflossen:");
            int rueckenflosse = Convert.ToInt32(Console.ReadLine());

            float preis;
            float groesse;
            float gewicht;

            Console.WriteLine("\nPreis angeben:");
            float.TryParse(Console.ReadLine(), out preis);

            Console.WriteLine("\nGröße angeben:");
            float.TryParse(Console.ReadLine(), out groesse);

            Console.WriteLine("\nGewicht angeben:");
            float.TryParse(Console.ReadLine(), out gewicht);

            Fisch fisch = new Fisch(rueckenflosse, preis, groesse, gewicht);

        }
    }
}
