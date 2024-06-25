using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TierPension.Helper;

namespace TierPension.Model
{
    public class Pension
    {
        private static Pension? _instance = null;

        private static readonly object _lock = new object();

        private Pension()
        {
            Update();  
        }

        // Öffentliche statische Methode, um die einzige Instanz der Klasse zu erhalten
        public static Pension Instance
        {
            get
            {
                // Doppelt überprüfte Sperre für Thread-Sicherheit und Leistung
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Pension();
                        }
                    }
                }
                return _instance;
            }
        }

        // Öffentliche Eigenschaften
        public List<Kunde> Kunden { get; set; }
        public List<Pensionierung> Pensionierungen { get; set; }
        public Kunde? AktuellerKunde { get; set; } // ist vor Login NULL

        /// <summary>
        /// Aktualisiert die Listen für die Kunden und Pensionierungen
        /// </summary>
        public void Update()
        {
            Kunden = KundeHelper.GetAllKunden();
            Debug.WriteLine($"Update Pension: Es wurden {Kunden.Count()} Kunden gefunden!");
            Pensionierungen = PensionierungHelper.GetAllPensionierungenOfCurrentUser();
            Debug.WriteLine($"Update Pension: Es wurden {Pensionierungen.Count()} Pensionierungen gefunden!");
        }
    }
}
