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

namespace ZooProject.View_Models
{
    class LoginMenuViewModel : ViewModelBase
    {


        public LoginMenuViewModel()
        {
            Password = "1";
            Username = "1";


        }
        public ZooDataContext dBContext = new ZooDataContext();
        private List<String> list = new List<string>();
        private string username;
        private string password;
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


                OnPropertyChanged("User");

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
        #endregion

        private DelegateCommand commandNext;


        public ICommand CommandNext
        {
            get
            {
                return commandNext ?? (commandNext = new DelegateCommand(() =>
                {


                    if (FillName() != null)
                    {

                     
                        var splashScreen = new SplashScreenWindow();
                       
                        splashScreen.Show();
                        System.Threading.Thread.Sleep(30);
                  

                        Task.Factory.StartNew(() =>
                        {
                            for (int i = 1; i <= 100; i++)
                        {
                            System.Threading.Thread.Sleep(30);

                          
                            splashScreen.Dispatcher.Invoke(() => splashScreen.Progress = i);
                        }

                       
                        splashScreen.Dispatcher.Invoke(() =>
                        {
                       
                        var mainWindow = new MainMenuWindow();
                    

                        mainWindow.Show();
                        splashScreen.Close();
                       
                       
                        });
                        });

                    }
                    else
                    {
                        MessageBox.Show("Грешни данни!");
                    }


                }));
            }
        }

      

        
    }
}
