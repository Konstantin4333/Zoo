using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace ZooProject.View
{
    /// <summary>
    /// Interaction logic for MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();
           Main.Content = new AnimalsPage();
        }

       private void btnAnimal_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new AnimalsPage();
        }

        private void btnEvent_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Events();
        }

        private void btnTickets_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Tickets();
        }
    }
}
