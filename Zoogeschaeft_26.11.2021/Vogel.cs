using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoogeschaeft_26._11._2021 {
    class Vogel : Tier {

        bool flugFaehig;
        int flugReichweite;


        // Konstruktor
        public Vogel(bool flugFaehig, int flugReichweite, float preis, float groesse, float gewicht) : base(preis, groesse, gewicht) {
            this.flugFaehig = flugFaehig;
            
            if (flugFaehig) {
                this.flugReichweite = flugReichweite;
            } else {
                this.flugReichweite = 0;
            }
        }
    }
}
