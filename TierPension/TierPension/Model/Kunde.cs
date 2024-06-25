using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TierPension.Global;

namespace TierPension.Model
{
    public class Kunde
    {
        public Kunde(Guid id, string vorname, string nachname, string nutzername, string email, string passwort, bool writeToFile = false)
        {
            ID = id.ToString();
            _vorname = vorname;
            _nachname = nachname;
            _nutzername = nutzername;
            _email = email;
            _passwort = passwort;
            _tiereID = new List<string>();

            if (writeToFile)
            {
                UpdateKunde();
            }
        }

        #region Backing-Fields

        private string _vorname;
        private string _nachname;
        private string _nutzername;
        private string _email;
        private string _passwort;
        private List<string> _tiereID;

        #endregion

        #region Properties

        [JsonProperty("id")]
        public string ID { get; }

        [JsonProperty("vorname")]
        public string Vorname
        {
            get { return _vorname; }
            set 
            {
                if (value != null && _vorname != value) 
                {
                    _vorname = value; 
                    UpdateKunde();
                }
            }
        }

        [JsonProperty("nachname")]
        public string Nachname
        {
            get { return _nachname; }
            set 
            {
                if (value != null && _nachname != value)
                {
                    _nachname = value; 
                    UpdateKunde();
                }
            }
        }

        [JsonProperty("nutzername")]
        public string Nutzername
        {
            get { return _nutzername; }
            set 
            {
                if (value != null && _nutzername != value)
                {
                    _nutzername = value; 
                    UpdateKunde();
                }
            }
        }

        [JsonProperty("email")]
        public string EMail
        {
            get { return _email; }
            set
            {
                if (value != null && _email != value)
                {
                    _email = value;
                    UpdateKunde();
                }
            }
        }

        [JsonProperty("passwort")]
        public string Passwort
        {
            get { return _passwort; }
            set 
            {
                if (value != null && _passwort != value)
                {
                    _passwort = value;
                    UpdateKunde();
                }
            }
        }

        [JsonProperty("tiereID")]
        public List<string> TiereID
        {
            get { return _tiereID; }
            set 
            {
                if (value != null && _tiereID != value)
                {
                    _tiereID = value;
                    UpdateKunde();
                }
            }
        }
        
        #endregion

        /// <summary>
        /// Diese Methode aktualisiert die JSON Datei im Hintergrund oder erstellt eine neue wenn es keine passende gibt.
        /// </summary>
        public void UpdateKunde()
        {
            string path = Config.FilePathKundenDaten + "\\" + ID + ".JSON";

            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(path, json);
        }
    }
}
