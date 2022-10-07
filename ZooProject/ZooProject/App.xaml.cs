
using System.Threading.Tasks;
using System.Windows;
using ZooProject.View;

namespace ZooProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /* private void Application_Startup(object sender, StartupEventArgs e)
         {
             ContainerBuilder builder = new Autofac.ContainerBuilder();
             builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                 .InNamespace("ZooProject.ViewModel")
                 .SingleInstance();
         }*/
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            
            var splashScreen = new SplashScreenWindow();
            this.MainWindow = splashScreen;
            splashScreen.Show();

            
            Task.Factory.StartNew(() =>
            {
                
                for (int i = 1; i <= 100; i++)
                {
                    
                    System.Threading.Thread.Sleep(30);

                    
                    splashScreen.Dispatcher.Invoke(() => splashScreen.Progress = i);
                }

              
                this.Dispatcher.Invoke(() =>
                {
                    
                    var mainWindow = new LoginMenu();
                    this.MainWindow = mainWindow;
                    mainWindow.Show();
                    splashScreen.Close();
                });
            });
        }
    }
}
