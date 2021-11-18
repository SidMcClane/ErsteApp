using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeuge_Uebung {
    class Pkw : Kraftfahrzeug {
        int anzahlSitzplaetze;

        public Pkw(int anzahlSitzplaetze, int hoechstgeschwindigkeit, int leistung, float leergewicht, float zulaessigesGesamtgewicht, float zuladung) : base(hoechstgeschwindigkeit, leistung, leergewicht, zulaessigesGesamtgewicht, zuladung) {
            this.anzahlSitzplaetze = anzahlSitzplaetze;
        }

        public override void methoden_name() {
            base.methoden_name();
        }
    }
}
