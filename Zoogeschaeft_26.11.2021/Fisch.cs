using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoogeschaeft_26._11._2021 {
    class Fisch : Tier {

        int rueckenflosse;


        // Konstruktor
        public Fisch(
            int rueckenflosse, 
            float preis, 
            float groesse, 
            float gewicht
            ) : base(
                preis, 
                groesse, 
                gewicht) {
            this.rueckenflosse = rueckenflosse;
            //int nummer = this.nummer;
        }
        
        // Methode - Ausgabe der Eingaben des erstellten Objekts
        public void Ausgabe(float preis, float groesse, float gewicht, int rueckenflosse) {
            Console.Clear();
            Console.WriteLine("" +
                "\nDu hast einen {0} gekauft" +
                "\nRechnungsnummer:\t2021_{1}" +
                "\nRückenflossen:\t\t{2}\n" +
                "\nPreis:\t\t\t{3:f2} Eur" +
                "\nGröße:\t\t\t{4:f2} cm" +
                "\nGewicht:\t\t{5:f2} kg" +
                "", this.GetType().Name, this.nummer, rueckenflosse, preis, groesse, gewicht
                );
        }
    }
}
