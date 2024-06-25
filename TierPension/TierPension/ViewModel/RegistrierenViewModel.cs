using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using TierPension.Global;
using TierPension.Helper;
using TierPension.Model;

namespace TierPension.ViewModel
{
    public class RegistrierenViewModel : Page, INotifyPropertyChanged
    {
        public RegistrierenViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            RegistrierenCommand = new RelayCommand(CanRegister);
            ZurueckCommand = new RelayCommand(Zurueck);
        }

        #region Properties

        public string Vorname { get; set; }
        public string Nachname { get; set; }
        private string _nutzername;
        public string Nutzername
        {
            get { return _nutzername; }
            set 
            {
                if (KundeHelper.GetKundeByUsername(value) != null)
                {
                    ErrorMessage = "This Username is already taken!";
                }
                else
                {
                    _nutzername = value;
                }
            }
        }
        public string EMail { get; set; }
        public string Passwort { private get; set; }
        private string _errorMessage;
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        #endregion

        #region Methods

        private void CanRegister(object obj)
        {
            if (string.IsNullOrEmpty(Passwort) || string.IsNullOrEmpty(Nutzername) ||
                string.IsNullOrEmpty(Vorname) || string.IsNullOrEmpty(Nachname) || string.IsNullOrEmpty(EMail))
            {
                ErrorMessage = "Bitte fülle alle Felder aus!";
            }
            else
            {
                ErrorMessage = "";
                Register();
            }
        }

        private void Register()
        {
            Kunde neuerKunde = new Kunde(Guid.NewGuid(), Vorname, Nachname, Nutzername, EMail, Passwort, true);
            Pension.Instance.Kunden.Add(neuerKunde);
            MessageBox.Show("Sie haben sich erfolgreich registriert!", "Registration abgeschlossen", MessageBoxButton.OK, MessageBoxImage.Information);
            _navigationService.NavigateTo<LoginViewModel>();
        }

        private void Zurueck(object obj)
        {
            _navigationService.GoBack();
        }

        #endregion

        #region Commands, Events, Service

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ICommand RegistrierenCommand { get; set; }
        public ICommand ZurueckCommand { get; set; }
        private readonly INavigationService _navigationService;

        #endregion
    }
}
