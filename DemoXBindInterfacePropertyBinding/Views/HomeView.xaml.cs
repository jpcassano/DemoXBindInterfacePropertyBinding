using DemoXBindInterfacePropertyBinding.ViewModels;
using Microsoft.UI.Xaml.Controls;



namespace DemoXBindInterfacePropertyBinding
{
    public sealed partial class HomeView : Page
    {
        public HomeViewModel ViewModel;

        public HomeView()
        {
            InitializeComponent();
            ViewModel = App.GetService<HomeViewModel>();    
        }

    }
}
