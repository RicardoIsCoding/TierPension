using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TierPension.Model;

namespace TierPension.ViewModel
{
    public class RechnungViewModel
    {
        public RechnungViewModel(string TierName)
        {
            
        }

        private decimal _kostenInsgesamt;

        public decimal KostenInsgesamt
        {
            get { return _kostenInsgesamt; }
            set { _kostenInsgesamt = value; }
        }

        private int _anzahlTage;

        public int AnzahlTage
        {
            get { return _anzahlTage; }
            set { _anzahlTage = value; }
        }


    }
}
