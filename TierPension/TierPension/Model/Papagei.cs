using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TierPension.Helper;

namespace TierPension.Model
{
    public class Papagei : Tier
    {
        public Papagei(Guid id, string name, Tierart tierart, Futter futter, bool istPensioniert, bool writeToFile = false) : base(id, name, tierart, futter, istPensioniert, writeToFile)
        {
        }

        public override string Call()
        {
            return $"Der Papagei {Name} wurde gerufen! Er ruft zurück!";
        }

        public override string Care()
        {
            return $"Es wurde siche um den Papagei {Name} gekümmert!";
        }
    }
}
