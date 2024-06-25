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
            _kundeID = kundenID;
            _tierID = tierID;
            _beginn = beginn;
            _ende = ende;
            if (writeToFile)
            {
                UpdatePensionierung();
            }
        }

        #region Backing-Fields

        private string _kundeID;
        private string _tierID;
        private string? _rechnungID;
        private DateTime _beginn;
        private DateTime _ende;
        private bool _abgeschlossen = false;

        #endregion

        #region Properties

        [JsonProperty("id")]
        public string ID { get; init; }

        [JsonProperty("kunde")]
        public string KundeID
        {
            get { return _kundeID; }
            set {
                _kundeID = value; 
                UpdatePensionierung();
            }
        }

        [JsonProperty("tier")]
        public string TierID
        {
            get { return _tierID; }
            set 
            {
                _tierID = value;
                UpdatePensionierung();
            }
        }

        [JsonProperty("rechnung")]
        public string? RechnungID
        {
            get { return _rechnungID; }
            set 
            {
                _rechnungID = value;
                UpdatePensionierung();
            }
        }

        [JsonProperty("beginn")]
        public DateTime Beginn
        {
            get { return _beginn; }
            set 
            {
                _beginn = value;
                UpdatePensionierung();
            }
        }

        [JsonProperty("ende")]
        public DateTime Ende
        {
            get { return _ende; }
            set 
            {
                _ende = value;
                UpdatePensionierung();
            }
        }

        [JsonProperty("abgeschlossen")]
        public bool Abgeschlossen
        {
            get { return _abgeschlossen; }
            set
            {
                if (_abgeschlossen != value)
                {
                    _abgeschlossen = value;
                    UpdatePensionierung();
                }
            }
        }

        #endregion

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
