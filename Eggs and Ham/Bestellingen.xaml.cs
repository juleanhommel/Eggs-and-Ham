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

            //properties stackpanel
            Back.Orientation = Orientation.Horizontal;
            Back.HorizontalAlignment = HorizontalAlignment.Right;
            Back.VerticalAlignment = VerticalAlignment.Bottom;
            Back.Margin = new Thickness(0, 0, 10, 10);
            BestelWindow.Children.Add(Back);
            Back.Children.Add(Terug);

            //properties terug button
            Terug.Width = 50;
            Terug.Content = "terug";
            Terug.Click += MainMenu;

            if (FirstLoad == true)
            {
                Tafel_1.Items.Add("tafel 1");
                Tafel_2.Items.Add("Tafel 2");
                Tafel_3.Items.Add("Tafel 3");
                Tafel_4.Items.Add("Tafel 4");
                Tafel_5.Items.Add("Tafel 5");
                Tafel_6.Items.Add("Tafel 6");
                Tafel_7.Items.Add("Tafel 7");
                Tafel_8.Items.Add("Tafel 8");
                Tafel_9.Items.Add("Tafel 9");
                Tafel_10.Items.Add("Tafel 10");
                Tafel_11.Items.Add("Tafel 11");
                Tafel_12.Items.Add("Tafel 12");
                Tafel_13.Items.Add("Tafel 13");
                Tafel_14.Items.Add("Tafel 14");
                Tafel_15.Items.Add("Tafel 15");
                Tafel_16.Items.Add("Tafel 16");
                Tafel_17.Items.Add("Tafel 17");
                Tafel_18.Items.Add("Tafel 18");
                Tafel_19.Items.Add("Tafel 19");
                Tafel_20.Items.Add("Tafel 20");
                FirstLoad = false;
            }
        }
        public void MainMenu(object sender, RoutedEventArgs e)
        {
            Back.Children.Clear();
            BestelWindow.Children.Clear();
            MainWindow.MainMenu.Navigate(new HoofdMenu());
        }
    }
}
