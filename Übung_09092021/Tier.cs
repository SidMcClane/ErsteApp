using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_09092021 {
    class Tier {
        static int autonummer = 1337;
        public int anzahlBeine { get; set; }
        int anzahlAugen;
        string farbe;
        double groesse;
        string gattung;


        public Tier(int anzahlBeine, int anzahlAugen, string farbe, double groesse, string gattung) {

            this.anzahlBeine = anzahlBeine;
            this.anzahlAugen = anzahlAugen;
            this.farbe = farbe;
            this.groesse = groesse;
            this.gattung = gattung;

        }
        public override string ToString() {
            return 
                $"Gattung {gattung}\n" +
                $"Beine: {anzahlBeine} \n" +
                $"Augen {anzahlAugen}\n" +
                $"Farbe {farbe}\n" +
                $"Groesse {groesse}\n";
        }
    }
}
