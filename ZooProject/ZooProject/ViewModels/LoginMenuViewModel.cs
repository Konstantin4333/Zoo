using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Linq;
using System.Data;
using ZooProject.View;
using ZooProject.Commands;
using Prism.Commands;
using DataBaseServicee.Model;
using DataBaseServicee.DataContext;
using System.Threading.Tasks;
using ZooProject.ScreenSplashWindows;
using System.ComponentModel;

namespace ZooProject.View_Models
{
   public class LoginMenuViewModel : ViewModelBase
    {


        public LoginMenuViewModel()
        {
            Password = "Username";
            Username = "Password";


        }
        public ZooDataContext dBContext = new ZooDataContext();
        private List<String> list = new List<string>();
        private string username;
        private string password;
        public bool isVisible = false;
        private List<User> users = new List<User>();

        public User FillName()
        {
            return dBContext.user
                 .Where(us => us.Name == username && us.Password == password)
                .Select(u => u).FirstOrDefault();
        }




        #region Properties
        public string Username
        {
            get { return username; }
            set
            {
                username = value;

                
                OnPropertyChanged(nameof(Username));
              

            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;


                OnPropertyChanged("Password");

            }
        }

        public bool IsVisible
        {
            get { return isVisible; }
            set
            {
                isVisible = value;


                OnPropertyChanged(nameof(IsVisible));

            }
        }
        private double progress;
        public double Progress
        {
            get { return progress; }
            private set
            {
                progress = value;
                OnPropertyChanged(nameof(Progress));
            }
        }


        #endregion
        #region Commands
        private DelegateCommand commandNext;

        public ICommand CommandNext
        {
            get
            {
                return commandNext ?? (commandNext = new DelegateCommand(() =>
                {

                    IsVisible = true;
                    if (FillName() != null)
                    {

                        Loadingbar();
                                               
                    }
                    else
                    {
                        MessageBox.Show("Грешни данни!");
                    }


                }));
            }
        }
        private DelegateCommand commandNextss;

        public ICommand CommandNextss
        {
            get
            {
                return commandNextss ?? (commandNextss = new DelegateCommand(() =>
                {

                    Username = null;


                }));
            }
        }

        public LoginMenu MainWindow { get; private set; }


        #endregion
        #region Functions
        public void Loadingbar()
        {

            var logWindow = new LoginMenu();
            System.Threading.Thread.Sleep(30);

            Task.Factory.StartNew(() =>
{
    for (int i = 1; i <= 100; i++)
    {
        System.Threading.Thread.Sleep(30);


        logWindow.Dispatcher.Invoke(() => Progress = i);

    }
    logWindow.Dispatcher.Invoke(() =>
{

    var mainWindow = new MainMenuWindow();
    mainWindow.Show();
    logWindow.Close();
    App.Current.Windows[0].Close();



});
});
        }
        #endregion


    }
}
