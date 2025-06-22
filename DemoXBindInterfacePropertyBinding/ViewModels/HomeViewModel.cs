using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace DemoXBindInterfacePropertyBinding.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        private IInterfaceWithObservableProperty interfaceWithProperty;

        public HomeViewModel(IInterfaceWithObservableProperty interfaceWithProperty)
        {
            this.interfaceWithProperty = interfaceWithProperty;
        }

        [RelayCommand]
        private async Task RunCalculateMethodAsync()
        {
            await InterfaceWithProperty.ExecuteAsync();
        }

    }
}
