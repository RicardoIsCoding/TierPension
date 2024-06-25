using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using TierPension.Helper;

namespace TierPension.ViewModel
{
    public class StartViewModel : Page, INotifyPropertyChanged
    {
        public StartViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            AnmeldenCommand = new RelayCommand(OpenAnmeldenPage);
            RegistrierenCommand = new RelayCommand(OpenRegistrierenPage);
            CloseCommand = new RelayCommand(CloseApplication);
        }

        public ICommand AnmeldenCommand { get; set; }
        public ICommand RegistrierenCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        private readonly INavigationService _navigationService;

        private void CloseApplication(object obj)
        {
            _navigationService.Close();
        }

        private void OpenAnmeldenPage(object parameter)
        {
            _navigationService.NavigateTo<LoginViewModel>();
            //_navigationService.NavigateTo<AnmeldenViewModel>();
        }

        private void OpenRegistrierenPage(object parameter)
        {
            _navigationService.NavigateTo<RegistrierenViewModel>();
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
