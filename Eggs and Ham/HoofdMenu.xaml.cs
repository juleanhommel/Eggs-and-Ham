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
    /// Interaction logic for HoofdMenu.xaml
    /// </summary>
    public partial class HoofdMenu : Page
    {
        public HoofdMenu()
        {

            InitializeComponent();
        }

        private void btnReserveringen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainMenu.Navigate(new Reserveringen());
        }

        private void btnMenuKaart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainMenu.Navigate(new MenuKaart());
        }

        private void btnBestellingen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainMenu.Navigate(new Bestellingen());
        }
    }
}
