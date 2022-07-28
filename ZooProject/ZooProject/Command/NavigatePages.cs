using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using ZooProject.View_Models;

namespace ZooProject.Command
{
    public class NavigatePages : ICommand
    {

       // private LoginMenuViewModel loginViewModel;
        private MainViewModel mainViewModel;

        public NavigatePages(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

      /*  public NavigatePages(LoginMenuViewModel loginViewModel)
        {
            this.loginViewModel = loginViewModel;
        }*/



        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            switch (parameter)
            {
                case "Login":
                   // if (loginViewModel.Username == loginViewModel.User.Name)
                        mainViewModel.ChoisedViewModel = new LoginMenuViewModel();
                    //else MessageBox.Show("Грешни данни");
                    break;
               
            }
        }
    }
}
