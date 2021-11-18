using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeuge_Uebung {
    class Motorrad : Kraftfahrzeug {
        public Motorrad(int hoechstgeschwindigkeit, int leistung, float leergewicht, float zulaessigesGesamtgewicht, float zuladung) : base(hoechstgeschwindigkeit, leistung, leergewicht, zulaessigesGesamtgewicht, zuladung) {
        }
    }
}
