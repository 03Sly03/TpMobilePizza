using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TpMobilePizza.Services;

namespace TpMobilePizza.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
        protected readonly INavigationService _navigationService;
        public ICommand GoToHomeCommand { get; set; }

        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoToHomeCommand = new RelayCommand(GoToHome);
        }

        private void GoToHome()
        {
            _navigationService.NavigateToAsync("//HomePage");
        }
    }
}
