using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ZooProject.View;

namespace ZooProject.View_Models
{
    class LoginMenuViewModel : ViewModelBase
    {
  

        public LoginMenuViewModel()
        {
            ViewModelBase viewModelBase;
            
        }

        private DelegateCommand commandNext;
        private TextBox textBox;
        

        public TextBox Tbox
        {
            get { return textBox; }
            set
            {
                textBox = value;
                
                OnPropertyChanged("Tbox");
               // FillModelChoices();
            }
        }

        public ICommand CommandNext
        {
            get
            {
                return commandNext ?? (commandNext = new DelegateCommand(() =>
                {
                   // FillAutopartsList();
                    
                       Window window = new MainMenuWindow();
                    //   Page page = new AnimalsPage();
                    window.Show();
                    System.Windows.Application.Current.Windows[0].Close();
                    
                }));
            }
        }



    }
}
