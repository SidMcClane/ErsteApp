using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeuge_Uebung {
    class Fahrzeug {
        int fahrzeugnummer;
        private static int autoNummer = 0;
        float leergewicht;
        float zulaessigesGesamtgewicht;
        float zuladung;
        public bool motor { set; get; } = false;


        // Konstruktor
        public Fahrzeug(float leergewicht, float zulaessigesGesamtgewicht, float zuladung) {
            this.fahrzeugnummer = ++autoNummer;
            this.leergewicht = leergewicht;
            this.zulaessigesGesamtgewicht = zulaessigesGesamtgewicht;
            this.zuladung = zuladung;
            
        }



        public virtual void methoden_name() { 
            // Irgend eine Funktion
        }


        //Methoden überladen
        public void berechnen(int a) { 
            // Berechnung von Ganzzahlen
        }

        public void berechnen(float b) { 
            // Berechnen von Gleitkommazahlen
        }


        public override string ToString() {
            return base.ToString();

        }
    }
}
