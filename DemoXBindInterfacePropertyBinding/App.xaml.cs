using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml;
using System;


namespace DemoXBindInterfacePropertyBinding
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        private Window? _window;
        public IHost Host
        {
            get;
        }

        public App()
        {
            InitializeComponent();

            Host = Microsoft.Extensions.Hosting.Host
             .CreateDefaultBuilder()
             .UseContentRoot(AppContext.BaseDirectory)
             .ConfigureServices((context, services) =>
             {
                 services.AddAppServices();

             }).Build();
        }


        public static T GetService<T>()
          where T : class
        {
            if ((App.Current as App)!.Host.Services.GetService(typeof(T)) is not T service)
            {
                throw new ArgumentException($"{typeof(T)} needs to be registered in ConfigureServices within App.xaml.cs.");
            }

            return service;
        }

        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            base.OnLaunched(args);
            var mainWindow  = new MainWindow();
            mainWindow.Content = App.GetService<HomeView>();
            mainWindow.Activate();
        }
    }
}
