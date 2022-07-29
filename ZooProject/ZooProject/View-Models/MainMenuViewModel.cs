using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ZooProject.View;

namespace ZooProject.View_Models
{
    class MainMenuViewModel : ViewModelBase
    {


        /*   private void Grid_Click(object sender, RoutedEventArgs e)
           {
               var ClickedButton = e.OriginalSource as NavButton;

               NavigationService.Navigate(ClickedButton.NavUri);
           }*/
        public MainMenuViewModel()
        {
            ViewModelBase viewModelBase;

        }
        private DelegateCommand commandNext;
        private object FrameWithinGrid;

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

       /* public ICommand CommandAnimals
        {
            get
            {
                return CommandAnimals ?? (CommandAnimals = new DelegateCommand(() =>
                {
                    FrameWithinGrid.Navigate(new System.Uri("Page1.xaml",
                    UriKind.RelativeOrAbsolute));

                }));
            }
        }*/

    }
}
