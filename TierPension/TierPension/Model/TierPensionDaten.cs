using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace TierPension.Model
{
    public class TierPensionDaten
    {
        public TierPensionDaten()
        {
            
        }

        /*
        // Beispielmethode zum Speichern der Daten in eine JSON-Datei
        public void SaveToJson(string filePath = @"C:\Users\Ricardo.Reindl\Documents\RE\Tierpension\TierPension\Daten\")
        {
            // Serialisieren des Objekts in JSON
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);

            // Sanitize Vorname and Nachname to remove invalid filename characters
            Vorname = SanitizeFilename(Vorname);
            Nachname = SanitizeFilename(Nachname);

            // Use a date format that avoids characters invalid in filenames
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");

            string fileName = $"{Vorname}_{Nachname}_{TierName}_{timestamp}.JSON";

            // Speichern des JSON in eine Datei
            File.WriteAllText(filePath + fileName , json);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string SanitizeFilename(string input)
        {
            // Remove invalid filename characters
            string invalidChars = new string(Path.GetInvalidFileNameChars());
            string invalidReStr = string.Format(@"[{0}]", Regex.Escape(invalidChars));
            return Regex.Replace(input, invalidReStr, "");
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        */
    }
}
