using System.Windows;


namespace ZooProject.ScreenSplashWindows
{
    /// <summary>
    /// Interaction logic for SplashBetweenWindows.xaml
    /// </summary>
    public partial class SplashBetweenWindows : Window
    {
        public SplashBetweenWindows()
        {
            InitializeComponent();
        }
        public double Progress
        {
            get { return progressBar1.Value; }
            set { progressBar1.Value = value; }
        }
    }
}
