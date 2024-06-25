using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TierPension.Helper;
using TierPension.View;
using TierPension.ViewModel;

namespace TierPension.VM
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _navigationService.NavigateTo<StartViewModel>();
        }

        private readonly INavigationService _navigationService;
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
