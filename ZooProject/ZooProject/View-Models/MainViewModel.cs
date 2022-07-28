using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ZooProject.Command;


namespace ZooProject.View_Models
{
    public class MainViewModel : ViewModelBase
    {
        private string username;
        private string password;
      
       
        public string Username { get { return username; } set { username = value; } }
        private ViewModelBase _choisedViewModel;
        public ViewModelBase ChoisedViewModel
        {
            get { return _choisedViewModel; }
            set
            {
                _choisedViewModel = value;
                OnPropertyChanged(nameof(ChoisedViewModel));
            }
        }
        public ICommand NavigatePages { get; set; }
        public MainViewModel()
        {
            NavigatePages = new NavigatePages(this);
        }
    }
}
