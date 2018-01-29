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
    /// Interaction logic for Bestellingen.xaml
    /// </summary>
    public partial class Bestellingen : Page
    {
        public static ListBox Tafel_1 = new ListBox();
        public static ListBox Tafel_2 = new ListBox();
        public static ListBox Tafel_3 = new ListBox();
        public static ListBox Tafel_4 = new ListBox();
        public static ListBox Tafel_5 = new ListBox();
        public static ListBox Tafel_6 = new ListBox();
        public static ListBox Tafel_7 = new ListBox();
        public static ListBox Tafel_8 = new ListBox();
        public static ListBox Tafel_9 = new ListBox();
        public static ListBox Tafel_10 = new ListBox();
        public static ListBox Tafel_11 = new ListBox();
        public static ListBox Tafel_12 = new ListBox();
        public static ListBox Tafel_13 = new ListBox();
        public static ListBox Tafel_14 = new ListBox();
        public static ListBox Tafel_15 = new ListBox();
        public static ListBox Tafel_16 = new ListBox();
        public static ListBox Tafel_17 = new ListBox();
        public static ListBox Tafel_18 = new ListBox();
        public static ListBox Tafel_19 = new ListBox();
        public static ListBox Tafel_20 = new ListBox();

        public static StackPanel Back = new StackPanel();
        public static Button Terug = new Button();

        public static bool FirstLoad = true;

        public Bestellingen()
        {
            //properties terug button
            Terug.Width = 50;
            Terug.Content = "terug";
            Terug.Click += MainMenu;
        }
        public void MainMenu(object sender, RoutedEventArgs e)
        {
            Back.Children.Clear();
            BestelWindow.Children.Clear();
            MainWindow.MainMenu.Navigate(new HoofdMenu());
        }
    }
}
