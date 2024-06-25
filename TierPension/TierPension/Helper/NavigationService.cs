using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TierPension.Model;
using TierPension.View;
using TierPension.ViewModel;

namespace TierPension.Helper
{
    public interface INavigationService
    {
        void NavigateTo<TViewModel>(object parameter = null);
        void GoBack();
        void Close();
    }

    public class NavigationService : INavigationService
    {
        private readonly MainWindow _mainWindow;
        private readonly Stack<Page> _navigationStack = new Stack<Page>();

        public NavigationService(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
        }

        public void NavigateTo<TViewModel>(object parameter = null)
        {
            Page page = null;
            if (typeof(TViewModel) == typeof(StartViewModel)) 
            {
                page = new Start();
                page.DataContext = new StartViewModel(this);
            }
            else if (typeof(TViewModel) == typeof(RechnungViewModel)) 
            {
                page = new Rechnung();
                page.DataContext = new RechnungViewModel((string)parameter);
            }
            else if (typeof(TViewModel) == typeof(RegistrierenViewModel))
            {
                page = new Register();
                page.DataContext = new RegistrierenViewModel(this);
            }
            else if (typeof(TViewModel) == typeof(AnmeldenViewModel))
            {
                page = new Anmelden();
                page.DataContext = new AnmeldenViewModel(this);
            } 
            else if (typeof(TViewModel) == typeof(LoginViewModel))
            {
                page = new Login();
                page.DataContext = new LoginViewModel(this);
            }
            else if(typeof(TViewModel) == typeof(HomeViewModel)) 
            {
                page = new Home();
                page.DataContext = new HomeViewModel(this);
            }

            if (page != null)
            {
                _navigationStack.Push(page);
                _mainWindow.MainFrame.Navigate(page);
            }
        }

        public void GoBack()
        {
            if (_navigationStack.Count > 1)
            {
                // Remove current page
                _navigationStack.Pop();
                // Navigate to the previous page
                var previousPage = _navigationStack.Peek();
                _mainWindow.MainFrame.Navigate(previousPage);
            }
        }

        public void Close()
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
