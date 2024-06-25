using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TierPension.Global;
using TierPension.Helper;

namespace TierPension.Model
{
    public class Tier
    {
        public Tier(Guid id, string name, Tierart tierart, Futter futter, bool istPensioniert, bool writeToFile = false)
        {
            ID = id.ToString();
            _name = name;
            _tierart = tierart;
            _futter = futter;
            _istPensioniert = istPensioniert;
            if (writeToFile)
            {
                UpdateTier();
            }
        }

        #region Backing-Fields

        private string _name;
        private Tierart _tierart;
        private Futter _futter;
        private bool _istPensioniert;

        #endregion

        #region Properties

        [JsonProperty("id")]
        public string ID { get; init; }

        [JsonProperty("name")]
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != _name && value != null)
                {
                    _name = value;
                    UpdateTier();
                }
            }
        }

        [JsonProperty("tierart")]
        public Tierart Tierart
        {
            get
            {
                return _tierart;
            }
            set
            {
                if (value != _tierart)
                {
                    _tierart = value;
                    UpdateTier();
                }
            }
        }

        [JsonProperty("futter")]
        public Futter Futter
        {
            get
            {
                return _futter;
            }
            set
            {
                if (value != _futter)
                {
                    _futter = value;
                    UpdateTier();
                }
            }
        }

        [JsonProperty("istPensioniert")]
        public bool IstPensioniert
        {
            get
            {
                return _istPensioniert;
            }
            set
            {
                if (_istPensioniert != value)
                {
                    _istPensioniert = value;
                    UpdateTier();
                }
            }
        }

        #endregion

        #region Methods

        public virtual string Call()
        {
            return "Das Tier wurde gerufen!";
        }

        public virtual string Care()
        {
            return "Es wurde sich gekümmert!";
        }

        /// <summary>
        /// Diese Methode aktualisiert die JSON Datei im Hintergrund oder erstellt eine neue wenn es keine passende gibt.
        /// </summary>
        public void UpdateTier()
        {
            string path = Config.FilePathTiereDaten + "\\" + ID + ".JSON";

            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(path, json);
        }

        #endregion
    }
}
