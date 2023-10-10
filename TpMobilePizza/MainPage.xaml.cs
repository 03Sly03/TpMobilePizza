using TpMobilePizza.ViewModels;

namespace TpMobilePizza
{
    public partial class MainPage : ContentPage
    {
        public MainPage(BaseViewModel viewModel)
        {
            BindingContext = viewModel;
            InitializeComponent();
        }
    }
}