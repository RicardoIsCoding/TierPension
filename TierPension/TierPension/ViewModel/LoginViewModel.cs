using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TierPension.Helper;
using TierPension.Model;

namespace TierPension.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            AnmeldenCommand = new RelayCommand(CanLogin);
            RegistrierenCommand = new RelayCommand(GoToRegister);
            ZurueckCommand = new RelayCommand(GoBack);
            Pension.Instance.AktuellerKunde = null;
        }


        #region Methods

        private void GoBack(object obj)
        {
            _navigationService.GoBack();
        }

        private void CanLogin(object obj)
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Passwort))
            {
                ErrorMessage = "Bitte füllen Sie die Felder aus!";
                return;
            }

            _kunde = KundeHelper.GetKundeByUsername(Username);

            if (_kunde == null)
            {
                ErrorMessage = "Der Nutzername existiert nicht!";
                return;
            }

            if (_kunde.Passwort != Passwort)
            {
                ErrorMessage = "Das Passwort ist falsch!";
            }
            else 
            {
                Pension.Instance.AktuellerKunde = _kunde;
                _navigationService.NavigateTo<HomeViewModel>(_kunde);
            }
        }

        private void GoToRegister(object obj)
        {
            _navigationService.NavigateTo<RegistrierenViewModel>();
        }

        #endregion

        #region Properties, Backing-Fields

        private Kunde _kunde;

        public string Username { private get; set; }
        public string Passwort { private get; set; }

        private string _errorMessage;
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; OnPropertyChanged(nameof(ErrorMessage)); }
        }

        #endregion

        #region Commands, Events

        public ICommand AnmeldenCommand { get; set; }
        public ICommand RegistrierenCommand { get; set; }
        public ICommand ZurueckCommand { get; set; }
        private readonly INavigationService _navigationService;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion
    }
}
