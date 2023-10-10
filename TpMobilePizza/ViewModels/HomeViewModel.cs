using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpMobilePizza.Models;
using TpMobilePizza.Services;

namespace TpMobilePizza.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        private IMyPizzaService _myPizzaService;
        public ObservableCollection<MyPizza> Datas { get; set; }
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            Datas = new ObservableCollection<MyPizza>();
            GetAll();
        }

        public void GetAll()
        {
            foreach (MyPizza product in _myPizzaService.GetAll())
            {
                Datas.Add(product);
            }
        }
    }
}
