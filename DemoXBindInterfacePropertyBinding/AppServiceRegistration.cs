using DemoXBindInterfacePropertyBinding.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace DemoXBindInterfacePropertyBinding
{
    public static class AppServiceRegistration
    {
        public static void AddAppServices(this IServiceCollection services)
        {
            services.AddTransient<HomeView>();
            services.AddTransient<HomeViewModel>();
            services.AddTransient<IInterfaceWithObservableProperty, CalculateValueUseCase>();
        }
    }
}
