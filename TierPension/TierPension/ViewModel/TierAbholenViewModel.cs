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

            TiereDesKunden = new ObservableCollection<Tier>(Pension.Instance.AktuellerKunde.TiereID);
            _allePensionierungen = PensionierungHelper.GetAllPensionierungenOfCurrentUser();
            TiereDesKunden = GetAllePensioniertenTiere();
        }

        private ObservableCollection<Tier> GetAllePensioniertenTiere()
        {
            ObservableCollection<Tier> list = new ObservableCollection<Tier>();
            foreach (var pension in _allePensionierungen)
            {
                list.Add(pension.TierID);
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
                _allePensionierungen.Where(w => w.TierID.ID == SelectedTier.ID).ToList().ForEach(p => p.Abgeschlossen = true);
            }
            else
            {
                string pID = _allePensionierungen.Where(w => w.TierID.ID == SelectedTier.ID).Select(s => s.ID).FirstOrDefault();
                PensionierungHelper.DeletePensionierung(pID);
                MessageBox.Show($"Die Pensionierun für {SelectedTier.Name} wurde erfolgreich gelöscht!", "Löschen erfolgreich", MessageBoxButton.OK);
            }
        }

        private void RechnungAnzeigen(object obj)
        {
            throw new NotImplementedException();
        }

        private ObservableCollection<Tier> _tiereDesKunden;

        public ObservableCollection<Tier> TiereDesKunden
        {
            get { return _tiereDesKunden; }
            set
            {
                _tiereDesKunden = value;
                OnPropertyChanged(nameof(TiereDesKunden));
            }
        }

        private Tier? _selectedTier;

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

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }


        private List<Pensionierung> _allePensionierungen;
        public ICommand RechnungCommand { get; set; }
        public ICommand AbholenOderLoeschenCommand { get; set; }
        public ICommand AbbrechenCommand { get; set; }


        private Window _thisWindow;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
