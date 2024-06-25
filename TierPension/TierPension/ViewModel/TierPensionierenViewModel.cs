using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TierPension.Helper;
using TierPension.Model;

namespace TierPension.ViewModel
{
    public class TierPensionierenViewModel : Page, INotifyPropertyChanged
    {
        public TierPensionierenViewModel(Window thisWindow)
        {
            _thisWindow = thisWindow;
            _aktuellerKunde = Pension.Instance.AktuellerKunde;

            TiereDesKunden = new ObservableCollection<Tier>(TierHelper.GetAllTierByID(_aktuellerKunde.TiereID));

            SpeichernCommand = new RelayCommand(CanSave);
            AbbrechenCommand = new RelayCommand(Abbrechen);
        }

        #region Backing-Fields

        private string _errorMessage;
        private DateTime _abgabeDatum = DateTime.Now;
        private DateTime _abholDatum = DateTime.Now;
        private Window _thisWindow;
        private Kunde _aktuellerKunde;
        private Pensionierung _pensionierung;

        #endregion

        #region Properties

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public ObservableCollection<Tier> TiereDesKunden { get; set; }

        public Tier SelectedTier { get; set; }

        public DateTime AbgabeDatum
        {
            get { return _abgabeDatum; }
            set { _abgabeDatum = value; }
        }

        public DateTime AbholDatum
        {
            get { return _abholDatum; }
            set { _abholDatum = value; }
        }

        #endregion

        #region Methods

        private void CanSave(object obj)
        {
            if (SelectedTier == null || AbgabeDatum == DateTime.MinValue || AbholDatum == DateTime.MinValue)
            {
                ErrorMessage = "Füllen Sie alle Felder aus!";
            }
            else if (AbgabeDatum < DateTime.Today || AbgabeDatum > AbholDatum || AbholDatum <= DateTime.Today)
            {
                ErrorMessage = "Falsches Anfang oder End-Datum. Bitte überprüfen Sie Ihre Eingabe!";
            }
            else
            {
                Save();
            }
        }

        private void Save()
        {
            Pensionierung p = new Pensionierung(Guid.NewGuid() , _aktuellerKunde.ID, SelectedTier.ID, AbgabeDatum, AbholDatum, true);
            SelectedTier.IstPensioniert = true;
            Pension.Instance.Update();
            MessageBox.Show($"Du hast {SelectedTier.Name} erfolgreich pensioniert. Vielen Dank!", "Pensionierung erfolgreich", MessageBoxButton.OK);
            _thisWindow.Close();
        }

        private void Abbrechen(object obj)
        {
            _thisWindow.Close();
        }

        #endregion

        #region Commands, Events

        public ICommand SpeichernCommand { get; set; }
        public ICommand AbbrechenCommand { get; set; }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion

    }
}
