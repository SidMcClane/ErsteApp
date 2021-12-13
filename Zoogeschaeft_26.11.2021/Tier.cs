using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Entwickle ein Programm zur Verwaltung eines Zoogeschäfts.
Alle Tiere haben eine
    Nr#,
    einen Preis,
    eine Größe 
    ein Gewicht.

Die Tiere bewegen sich alle unterschiedlich.

Fische unterscheiden sich durch 
    ihre Anzahl der Rückenflossen.

Vögel unterscheiden sich darin,
    ob sie Flugfähig sind und in
    ihrer maximalen Flugweite.

Reptilien können 
    giftig sein.

Personen, welche ein gefährliches Reptil halten wollen müssen über eine Berechtigung verfügen.
Die Berechtigung wird in unserem Fall erteilt,
    wenn die Person über 18 Jahre ist und
    keinen Eintrag im Führungszeugnis besitzt.

Dein Programm soll es ermöglichen,
    Tiere zu kaufen und verkaufen.

Die Umsetzung soll objektorientiert erfolgen. 
Nutze verschiedene Klassen und speichere diese in separaten Dateien ab.
Überlege dir ein eigenes zweckmäßiges Design und setze das mini Projekt alleine um.
*/

/*
Tier    - Fisch
        - Vogel
        - Reptilie



*/
        // Bewegung muss noch rein



namespace Zoogeschaeft_26._11._2021 {
    public abstract class Tier {
        protected int nummer;
        private static int id = 0;
        float preis;
        float groesse;
        float gewicht;


        // Konstruktor
        public Tier(float preis, float groesse, float gewicht) {
            this.nummer = ++id;
            this.preis = preis;
            this.groesse = groesse;
            this.gewicht = gewicht;
        }


    }
}
