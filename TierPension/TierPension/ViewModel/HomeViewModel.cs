using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TierPension.Helper;
using TierPension.Model;
using TierPension.View;

namespace TierPension.ViewModel
{
    public class HomeViewModel
    {
        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            AbgebenCommand = new RelayCommand(OpenTierPensionierenDialog);
            AbholenCommand = new RelayCommand(GoToTierAbholenPage);
            TierHinzufuegenCommand = new RelayCommand(OpenTierHinzufuegenDialog);
            ZurueckCommand = new RelayCommand(GoBack);
            //TiereBearbeitenCommand = new RelayCommand();
            HomeScreenText = $"Willkommen zurück, {Pension.Instance.AktuellerKunde.Vorname}!";
        }

        #region Methods

        private void OpenTierHinzufuegenDialog(object obj)
        {
            NeuesTierAnlegenDialog dialog = new NeuesTierAnlegenDialog();
            dialog.SizeToContent = System.Windows.SizeToContent.WidthAndHeight;
            dialog.ShowDialog();
        }

        private void OpenTierPensionierenDialog(object obj)
        {
            TierPensionierenDialog dialog = new TierPensionierenDialog();
            dialog.SizeToContent = System.Windows.SizeToContent.WidthAndHeight;
            dialog.ShowDialog();
        }

        private void GoToTierAbholenPage(object obj)
        {
            TierAbholenDialog dialog = new TierAbholenDialog();
            dialog.SizeToContent = System.Windows.SizeToContent.WidthAndHeight;
            dialog.ShowDialog();
        }

        private void GoBack(object obj)
        {
            _navigationService.GoBack();
        }

        #endregion

        public string HomeScreenText { get; set; }

        #region Commands, Service, Events

        public ICommand AbgebenCommand { get; set; }
        public ICommand AbholenCommand { get; set; }
        public ICommand TierHinzufuegenCommand { get; set; }
        public ICommand TiereBearbeitenCommand { get; set; }
        public ICommand ZurueckCommand { get; set; }
        private readonly INavigationService _navigationService;

        #endregion
    }
}
