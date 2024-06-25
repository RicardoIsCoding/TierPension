using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TierPension.Global;
using TierPension.View;

namespace TierPension.Model
{
    public class Pensionierung
    {
        public Pensionierung(Guid id, string kundenID, string tierID, DateTime beginn, DateTime ende, bool writeToFile = false) 
        {
            ID = id.ToString();
            KundeID = kundenID;
            TierID = tierID;
            Beginn = beginn;
            Ende = ende;
            if (writeToFile)
            {
                UpdatePensionierung();
            }
        }

        [JsonProperty("id")]
        public string ID { get; init; }

        [JsonProperty("kunde")]
        public string KundeID { get; set; }

        [JsonProperty("tier")]
        public string TierID { get; set; }

        [JsonProperty("rechnung")]
        public Rechnung? Rechnung { get; set; }

        [JsonProperty("beginn")]
        public DateTime Beginn { get; set; }

        [JsonProperty("ende")]
        public DateTime Ende { get; set; }

        [JsonProperty("abgeschlossen")]
        public bool Abgeschlossen { get; set; } = false;

        /// <summary>
        /// Diese Methode aktualisiert die JSON Datei im Hintergrund oder erstellt eine neue wenn es keine passende gibt.
        /// </summary>
        public void UpdatePensionierung()
        {
            string path = Config.FilePathPensionierungDaten + "\\" + ID + ".JSON";

            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(path, json);
        }
    }
}
