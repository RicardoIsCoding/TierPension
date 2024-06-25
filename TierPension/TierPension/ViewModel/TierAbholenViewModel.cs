using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using TierPension.Helper;
using TierPension.Model;

namespace TierPension.ViewModel
{
    public class TierAbholenViewModel : Page, INotifyPropertyChanged
    {
        public TierAbholenViewModel(Window window)
        {
            _thisWindow = window;
            RechnungCommand = new RelayCommand(RechnungAnzeigen);
            AbholenOderLoeschenCommand = new RelayCommand(AbholenOderLoeschen);
            AbbrechenCommand = new RelayCommand(Abbrechen);

            TiereDesKunden = new ObservableCollection<Tier>(TierHelper.GetAllTierByID(Pension.Instance.AktuellerKunde.TiereID));
            _allePensionierungen = PensionierungHelper.GetAllPensionierungenOfCurrentUser();
            TiereDesKunden = GetAllePensioniertenTiere();
        }

        #region Methods

        private ObservableCollection<Tier> GetAllePensioniertenTiere()
        {
            ObservableCollection<Tier> list = new ObservableCollection<Tier>();
            foreach (var pensionierung in _allePensionierungen)
            {
                if (!pensionierung.Abgeschlossen)
                {
                    list.Add(TierHelper.GetTierByID(pensionierung.TierID));
                }
            }
            return list;
        }

        private void Abbrechen(object obj)
        {
            _thisWindow.Close();
        }

        private void AbholenOderLoeschen(object obj)
        {
            if (SelectedTier == null)
            {
                throw new ArgumentNullException(nameof(SelectedTier));
            }

            if (SelectedTier.IstPensioniert) // Tier "abholen"
            {
                SelectedTier.IstPensioniert = false;
                _allePensionierungen.Where(w => w.TierID == SelectedTier.ID).ToList().ForEach(p => p.Abgeschlossen = true);
            }
            else //Pensionierung loeschen
            {
                string pID = _allePensionierungen.Where(w => w.TierID == SelectedTier.ID).Select(s => s.ID).FirstOrDefault();
                bool success = PensionierungHelper.DeletePensionierung(pID);
                if (success) 
                {
                    MessageBox.Show($"Die Pensionierun für {SelectedTier.Name} wurde erfolgreich gelöscht!", "Löschen erfolgreich", MessageBoxButton.OK);
                }
                else
                {
                    throw new Exception("Pensionierung konnte nicht gelöscht werden!");
                }
            }
        }

        private void RechnungAnzeigen(object obj)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Backing-Fields

        private ObservableCollection<Tier> _tiereDesKunden;
        private Tier? _selectedTier;
        private Window _thisWindow;
        private List<Pensionierung> _allePensionierungen;
        private string _errorMessage;

        #endregion

        #region Properties

        public ObservableCollection<Tier> TiereDesKunden
        {
            get { return _tiereDesKunden; }
            set
            {
                _tiereDesKunden = value;
                OnPropertyChanged(nameof(TiereDesKunden));
            }
        }
        public Tier? SelectedTier
        {
            get { return _selectedTier; }
            set 
            {
                _selectedTier = value; 
                OnPropertyChanged(nameof(SelectedTier));
            }
        }
        public string AbgabeDatum { get; set; } = "Hallo";
        public string AbholDatum { get; set; }
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        #endregion

        #region Commands, Events

        public ICommand RechnungCommand { get; set; }
        public ICommand AbholenOderLoeschenCommand { get; set; }
        public ICommand AbbrechenCommand { get; set; }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion
    }
}
