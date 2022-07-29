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


        private ViewModelBase selectedViewModle;

        public ViewModelBase SelectedViewModel
        {
            get { return selectedViewModle; }
            set { selectedViewModle = value; OnPropertyChanged(nameof(SelectedViewModel)); }
        }
        public ICommand NavigatePages { get; set; }
        public MainViewModel()
        {
            NavigatePages = new NavigatePages(this);
        }
    }
}
