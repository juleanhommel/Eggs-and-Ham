using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Eggs_and_Ham
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame MainMenu = new Frame();
        public MainWindow()
        {
            InitializeComponent();
            Screen.Children.Add(MainMenu);
            MainMenu.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainMenu.HorizontalAlignment = HorizontalAlignment.Stretch;
            MainMenu.VerticalAlignment = VerticalAlignment.Stretch;
            MainMenu.Navigate(new HoofdMenu());
        }
    }
}
