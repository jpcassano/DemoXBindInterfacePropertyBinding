using CommunityToolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;

namespace DemoXBindInterfacePropertyBinding
{
    internal class CalculateValueUseCase : ObservableObject, IInterfaceWithObservableProperty
    {
        private string status = "Not Started";

        public string Status
        {
            get => status;
            set => SetProperty(ref status, value);
        }

        public async Task ExecuteAsync()
        {
            Status = "Starting";

            await Task.Delay(1000);

            Status = "Processing";

            await Task.Delay(1000);

            Status = "Complete";
        }
    }
}
