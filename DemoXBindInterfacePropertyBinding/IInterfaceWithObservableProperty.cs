using System.Threading.Tasks;

namespace DemoXBindInterfacePropertyBinding
{
    public interface IInterfaceWithObservableProperty
    {
        public string Status { get; set; }

        public Task ExecuteAsync();
    }
}
