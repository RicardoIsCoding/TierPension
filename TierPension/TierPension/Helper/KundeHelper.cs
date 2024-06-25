using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TierPension.Global;
using TierPension.Model;

namespace TierPension.Helper
{
    public static class KundeHelper
    {
        public static Kunde? GetKundeByUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is null or empty", "ERROR", MessageBoxButton.OK);
                return null;
            }

            var kundenDateien = Directory.GetFiles(Config.FilePathKundenDaten, "*.JSON");
            var kundenListe = new List<Kunde>();

            foreach (var datei in kundenDateien)
            {
                var jsonInhalt = File.ReadAllText(datei);
                var kunde = JsonConvert.DeserializeObject<Kunde>(jsonInhalt);
                kundenListe.Add(kunde);
            }

            var gesuchterKunde = kundenListe.FirstOrDefault(k => k.Nutzername.Equals(username, StringComparison.Ordinal));

            return gesuchterKunde;
        }  
        
        public static Kunde? GetKundeByID(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Username is null or empty", "ERROR", MessageBoxButton.OK);
                return null;
            }

            var kundenDateien = Directory.GetFiles(Config.FilePathKundenDaten, "*.JSON");
            var kundenListe = new List<Kunde>();

            foreach (var datei in kundenDateien)
            {
                var jsonInhalt = File.ReadAllText(datei);
                var kunde = JsonConvert.DeserializeObject<Kunde>(jsonInhalt);
                kundenListe.Add(kunde);
            }

            var gesuchterKunde = kundenListe.FirstOrDefault(k => k.Nutzername.Equals(id, StringComparison.Ordinal));

            return gesuchterKunde;
        }

        public static List<Kunde> GetAllKunden()
        {
            var kundenDateien = Directory.GetFiles(Config.FilePathKundenDaten, "*.JSON");
            var kundenListe = new List<Kunde>();

            foreach (var datei in kundenDateien)
            {
                var jsonInhalt = File.ReadAllText(datei);
                var kunde = JsonConvert.DeserializeObject<Kunde>(jsonInhalt);
                if (kunde != null)
                {
                    kundenListe.Add(kunde);
                }
            }

            return kundenListe;
        }
    }
}
