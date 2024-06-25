using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using TierPension.Helper;
using TierPension.Model;

namespace TierPension.ViewModel
{
    public class NeuesTierAnlegenViewModel : INotifyPropertyChanged
    {
        public NeuesTierAnlegenViewModel(Window thisWindow)
        {
            _window = thisWindow;
            Futter = new ObservableCollection<string>(Enum.GetNames<Futter>());
            Tierart = new ObservableCollection<string>(Enum.GetNames<Tierart>());

            SpeichernCommand = new RelayCommand(CanSave);
            AbbrechenCommand = new RelayCommand(Abbrechen);
        }

        #region Backing-Fields

        private string _errorMessage;
        private Window _window;

        #endregion

        #region Properties

        public ObservableCollection<string> Futter { get; set; }
        public ObservableCollection<string> Tierart { get; set; }
        public string SelectedFutter { get; set; }
        public string SelectedTierart { get; set; }
        public string Name { get; set; }
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set 
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        #endregion

        #region Commands

        public ICommand SpeichernCommand { get; set; }
        public ICommand AbbrechenCommand { get; set; }

        #endregion

        #region Methods

        private void CanSave(object obj)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(SelectedFutter) || string.IsNullOrEmpty(SelectedTierart) )
            {
                ErrorMessage = "Bitte füllen Sie alle Felder aus! Speichern nicht möglich.";
            }
            else
            {
                Save();
            }
        }

        private void Save()
        {
            Tier t;
            
            if (Enum.Parse<Tierart>(SelectedTierart) == Helper.Tierart.Katze)
            {
                t = new Katze(Guid.NewGuid(), Name, Enum.Parse<Tierart>(SelectedTierart), Enum.Parse<Futter>(SelectedFutter), false, true);
            }
            else if (Enum.Parse<Tierart>(SelectedTierart) == Helper.Tierart.Hund)
            {
                t = new Hund(Guid.NewGuid(), Name, Enum.Parse<Tierart>(SelectedTierart), Enum.Parse<Futter>(SelectedFutter), false, true);
            }
            else if (Enum.Parse<Tierart>(SelectedTierart) == Helper.Tierart.Vogel)
            {
                t = new Vogel(Guid.NewGuid(), Name, Enum.Parse<Tierart>(SelectedTierart), Enum.Parse<Futter>(SelectedFutter), false, true);
            }
            else if (Enum.Parse<Tierart>(SelectedTierart) == Helper.Tierart.Schildkröte)
            {
                t = new Schildkröte(Guid.NewGuid(), Name, Enum.Parse<Tierart>(SelectedTierart), Enum.Parse<Futter>(SelectedFutter), false, true);
            }
            else
            {
                t = new Papagei(Guid.NewGuid(), Name, Enum.Parse<Tierart>(SelectedTierart), Enum.Parse<Futter>(SelectedFutter), false, true);
            }

            Pension.Instance.AktuellerKunde.TiereID.Add(t.ID);
            MessageBox.Show($"Du hast {t.Name} erfolgreich hinzugefügt. Vielen Dank!", "Hinzufügen erfolgreich", MessageBoxButton.OK);
            _window.Close();
        }

        private void Abbrechen(object obj)
        {
            _window.Close();
        }

        #endregion

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
