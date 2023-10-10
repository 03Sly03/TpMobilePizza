using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpMobilePizza.Pages;
using TpMobilePizza.Services;
using TpMobilePizza.ViewModels;

namespace TpMobilePizza.Tools
{
    public static class Extension
    {
        public static void AddCustomServices(this MauiAppBuilder appBuilder)
        {
            appBuilder.Services.AddScoped<IMyPizzaService, MyPizzaFakeDbService>();
            appBuilder.Services.AddScoped<INavigationService, NavigationService>();
            appBuilder.Services.AddScoped<BaseViewModel>();
            appBuilder.Services.AddScoped<HomeViewModel>();
            appBuilder.Services.AddScoped<MainPage>();
            appBuilder.Services.AddScoped<HomePage>();
        }
    }
}
