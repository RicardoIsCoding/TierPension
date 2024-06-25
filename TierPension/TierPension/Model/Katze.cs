using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TierPension.Helper;

namespace TierPension.Model
{
    public class Katze : Tier
    {
        public Katze(Guid id, string name, Tierart tierart, Futter futter, bool istPensioniert, bool writeToFile = false) : base(id, name, tierart, futter, istPensioniert, writeToFile)
        {
        }

        public override string Call()
        {
            return $"Die Katze {Name} wurde gerufen!";
        }

        public override string Care()
        {
            return $"Es wurde siche um die Katze {Name} gekümmert!";
        }
    }
}
