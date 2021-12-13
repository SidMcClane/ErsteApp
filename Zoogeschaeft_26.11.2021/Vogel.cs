using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoogeschaeft_26._11._2021 {
    class Vogel : Tier {

        bool flugFaehig;
        float flugReichweite;


        // Konstruktor
        public Vogel(
            bool flugFaehig,
            float flugReichweite,
            float preis,
            float groesse,
            float gewicht
            ) : base(
                preis, 
                groesse, 
                gewicht) {
            this.flugFaehig = flugFaehig;
            
            if (flugFaehig) {
                this.flugReichweite = flugReichweite;
            } else {
                this.flugReichweite = 0;
            }
        }

        // Methode - Ausgabe der Eingaben des erstellten Objekts
        public void Ausgabe(float preis, float groesse, float gewicht, bool flugFaehig, float flugReichweite) {
            Console.Clear();

            string flugFaehigAusgabe;
            if (flugFaehig) {
                flugFaehigAusgabe = "Ja";
            } else {
                flugFaehigAusgabe = "Nein";
            }

            Console.WriteLine("" +
                "\nDu hast einen {0} gekauft" +
                "\nRechnungsnummer:\t2021_{1}" +
                "\nFlugfähig:\t\t{2}" +
                "\nFlugreichweite:\n{3} km\n" +
                "\nPreis:\t\t\t{4:f2} Eur" +
                "\nGröße:\t\t\t{5:f2} cm" +
                "\nGewicht:\t\t{6:f2} kg" +
                "", this.GetType().Name, this.nummer, flugFaehigAusgabe, flugReichweite, preis, groesse, gewicht
                );
        }
    }
}
