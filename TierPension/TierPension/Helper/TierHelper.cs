using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TierPension.Global;
using TierPension.Model;

namespace TierPension.Helper
{
    public static class TierHelper
    {
        public static Tier? GetTierByID(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Username is null or empty", "ERROR", MessageBoxButton.OK);
                return null;
            }

            var tierDateien = Directory.GetFiles(Config.FilePathTiereDaten, "*.JSON");
            var tierListe = new List<Tier>();

            foreach (var datei in tierDateien)
            {
                var jsonInhalt = File.ReadAllText(datei);
                var tier = JsonConvert.DeserializeObject<Tier>(jsonInhalt);
                tierListe.Add(tier);
            }

            var gesuchtesTier = tierListe.FirstOrDefault(k => k.ID.Equals(id, StringComparison.Ordinal));

            return gesuchtesTier;
        }

        public static List<Tier>? GetAllTierByID(List<string> idList)
        {
            if (idList == null || idList.Count == 0)
            {
                MessageBox.Show("Username is null or empty", "ERROR", MessageBoxButton.OK);
                return null;
            }

            var tierDateien = Directory.GetFiles(Config.FilePathTiereDaten, "*.JSON");
            var tierListe = new List<Tier>();

            foreach (var datei in tierDateien)
            {
                var jsonInhalt = File.ReadAllText(datei);
                var tier = JsonConvert.DeserializeObject<Tier>(jsonInhalt);
                tierListe.Add(tier);
            }

            List<Tier> gesuchteTiere = new List<Tier>();

            foreach (var tier in tierListe)
            {
                if (idList.Contains(tier.ID))
                {
                    gesuchteTiere.Add(tier);
                }
            }

            return gesuchteTiere;
        }


    }

    public enum Tierart
    {
        Hund,
        Katze,
        Vogel,
        Schildkröte,
        Papagei
    }

    public enum Futter
    {
        Fleisch,
        Vegetarisch,
        Mischfutter,
    }
}
