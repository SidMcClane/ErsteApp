using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeuge_Uebung {
    class Fahrrad : Fahrzeug{
        float rahmenhoehe;

        public Fahrrad(float rahmenhoehe, float leergewicht, float zulaessigesGesamtgewicht, float zuladung) : base(leergewicht, zulaessigesGesamtgewicht,zuladung){
            this.rahmenhoehe = rahmenhoehe;
        }
    }
}
