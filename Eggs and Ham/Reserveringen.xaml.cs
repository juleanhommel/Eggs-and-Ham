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
    /// Interaction logic for Reserveringen.xaml
    /// </summary>
    public partial class Reserveringen : Page
    {

        public Reserveringen()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ResList.Items.Add(InvoerReservering.Text);
            InvoerReservering.Text = "";
        }

        private void Terug_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainMenu.Navigate(new HoofdMenu());
        }
    }
}
