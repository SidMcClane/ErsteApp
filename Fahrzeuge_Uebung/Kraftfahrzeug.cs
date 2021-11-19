using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeuge_Uebung {
    class Kraftfahrzeug : Fahrzeug {
        int hoechstgeschwindigkeit;
        int leistung;

        public Kraftfahrzeug(int hoechstgeschwindigkeit, int leistung, float leergewicht, float zulaessigesGesamtgewicht, float zuladung) : base(leergewicht, zulaessigesGesamtgewicht, zuladung) {
            this.hoechstgeschwindigkeit = hoechstgeschwindigkeit;
            this.leistung = leistung;
        }

        public override void methoden_name() {
            base.methoden_name();
        }

        public override string ToString() {
            return $"Kraftfahrzeug hat eine Höchstgeschwindigkeit von: {hoechstgeschwindigkeit}";
        }
    }
}
