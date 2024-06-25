using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TierPension.Global;
using TierPension.Model;

namespace TierPension.Helper
{
    public class PensionierungHelper
    {
        /// <summary>
        /// Gibt in einer List alle Pensionierung des aktuell angemeldeten Users zurück
        /// </summary>
        /// <returns></returns>
        public static List<Pensionierung> GetAllPensionierungenOfCurrentUser()
        {
            var pensionierungsDateien = Directory.GetFiles(Config.FilePathPensionierungDaten, "*.JSON");
            var pensionierungsListe = new List<Pensionierung>();

            foreach (var datei in pensionierungsDateien)
            {
                var jsonInhalt = File.ReadAllText(datei);
                var pensionierung = JsonConvert.DeserializeObject<Pensionierung>(jsonInhalt);
                if (pensionierung != null && pensionierung.KundeID == Pension.Instance.AktuellerKunde.ID)
                {
                    pensionierungsListe.Add(pensionierung);
                }
            }

            return pensionierungsListe;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true -> deletion successfull, false otherwise</returns>
        public static bool DeletePensionierung(string id)
        {
            string filePath = Path.Combine(Config.FilePathPensionierungDaten, id + ".JSON");

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    Console.WriteLine($"Datei {filePath} wurde erfolgreich gelöscht.");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler beim Löschen der Datei {filePath}: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Datei {filePath} wurde nicht gefunden.");
            }
            return false;
        }
    }
}
