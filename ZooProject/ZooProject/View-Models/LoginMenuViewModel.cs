using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ZooProject.Model;
using ZooProject.View;
using ZooProject.Data;
using System.Linq;

namespace ZooProject.View_Models
{
    class LoginMenuViewModel : ViewModelBase
    {
  

        public LoginMenuViewModel()
        {
            ViewModelBase viewModelBase;
            FillUsers();


        }



        public ZooDataContext dBContext = new ZooDataContext();
        private DelegateCommand commandNext;

        private List<User> users = new List<User>();



       
        private User user;

        public void FillUsers()
        {
            users = dBContext.user
            .Select(catAnim => catAnim).ToList();
        }

        public User SUser
        {
            get { return user; }
            set
            {
                user = value;

                OnPropertyChanged("SUser");
                Console.WriteLine();
            }
        }
        /* public List<User> Users
         {
             get { return users; }
             set
             {

                 if (users != value)
                 {
                     users = value;
                     OnPropertyChanged("Users");

                 }
             }

         }*/


        /*public string User
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
        }*/


        public ICommand CommandNext
        {
            get
            {
                return commandNext ?? (commandNext = new DelegateCommand(() =>
                {
                   
                  //  if (user.Equals(username))
                   // {
                        Window window = new MainMenuWindow();
                        window.Show();
                        System.Windows.Application.Current.Windows[0].Close();
                   // }
                   // else
                   // {
                     //   MessageBox.Show("Грешни данни");
                   // }
                    
                     
                   
                }));
            }
        }



    }
}
