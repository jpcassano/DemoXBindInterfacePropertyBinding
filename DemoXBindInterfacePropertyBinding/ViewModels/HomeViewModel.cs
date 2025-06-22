using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace DemoXBindInterfacePropertyBinding.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        private IInterfaceWithObservableProperty interfaceWithObservableProperty;
        public IInterfaceWithObservableProperty InterfaceWithObservableProperty
        {
            get => interfaceWithObservableProperty;
            set => SetProperty(ref interfaceWithObservableProperty, value);
        }

        public HomeViewModel(IInterfaceWithObservableProperty interfaceWithObservableProperty)
        {
            this.interfaceWithObservableProperty = interfaceWithObservableProperty;
        }

        [RelayCommand]
        private async Task RunCalculateMethodAsync()
        {
            await InterfaceWithObservableProperty.ExecuteAsync();
        }

    }
}
