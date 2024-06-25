using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TierPension.Helper;

namespace TierPension.Model
{
    public class Hund : Tier
    {
        public Hund(Guid id, string name, Tierart tierart, Futter futter, bool istPensioniert, bool writeToFile = false) : base(id, name, tierart, futter, istPensioniert, writeToFile)
        {
        }

        public override string Call()
        {
            return $"Der Hund {Name} wurde gerufen!";
        }

        public override string Care()
        {
            return $"Es wurde siche um den Hund {Name} gekümmert!";
        }
    }
}
