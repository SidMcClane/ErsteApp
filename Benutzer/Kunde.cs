using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benutzer {
    class Kunde : Person{
        string kundenNr;

        public Kunde(string name, string vorname, string kundenNr) : base(name, vorname) {
            this.kundenNr = kundenNr;
        }
    }
}
