using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;
using TierPension.Helper;
using TierPension.Model;

namespace TierPension.ViewModel
{
    public class AnmeldenViewModel
    {
        public AnmeldenViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            AnmeldenCommand = new RelayCommand(CanLogin);
        }

        private void CanLogin(object obj)
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Passwort))
            {
                ErrorMessageVisibility = true; 
                return;
            }
            
            kunde = KundeHelper.GetKundeByUsername(Username);
            if (kunde == null) 
            {
                ErrorMessageVisibility = true;
                return;
            }

            if (kunde.Passwort == Passwort)
            {
                _navigationService.NavigateTo<HomeViewModel>(kunde);
            }
        }

        private Kunde kunde;

        public string Username { private get; set; }
        public string Passwort { private get; set; }
        public bool ErrorMessageVisibility { get; set; }

        public ICommand AnmeldenCommand { get; set; }
        private readonly INavigationService _navigationService;
    }
}
