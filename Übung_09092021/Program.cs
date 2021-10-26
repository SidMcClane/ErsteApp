using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Übung_09092021 {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {

            Tier elephant = new Tier(4, 2, "grau", 3.5, "Säugetier");
            Console.WriteLine($"Anzahl der Beine: {elephant.anzahlBeine}");
            Console.WriteLine($"Anzahl der Beine: {elephant.anzahlBeine}");

        }
    }
}
