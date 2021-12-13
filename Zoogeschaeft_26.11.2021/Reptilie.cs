using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoogeschaeft_26._11._2021 {
    class Reptilie : Tier {

        bool giftig;
        bool abAchtzehn;
        bool keinEintrag;


        // Konstruktor
        public Reptilie(bool giftig, bool abAchtzehn, bool keinEintrag, float preis, float groesse, float gewicht) : base(preis, groesse, gewicht) {
            this.giftig = giftig;
            this.abAchtzehn = abAchtzehn;
            this.keinEintrag = keinEintrag;
        }



    }
}
