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
        }
    }
}
