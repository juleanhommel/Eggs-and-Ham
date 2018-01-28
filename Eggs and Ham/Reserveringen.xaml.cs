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
        public static ListBox Reservering = new ListBox();
        public static string strResVan;
        public static StackPanel invoercheck = new StackPanel();
        public static Button invoeroke = new Button();
        public static TextBox invoerGroeptxt = new TextBox();
        public static Button Terug = new Button();

        public Reserveringen()
        {
            InitializeComponent();


            //alle properties van de listbox bij reserveringen
            Reservering.HorizontalAlignment = HorizontalAlignment.Left;
            Reservering.VerticalAlignment = VerticalAlignment.Top;
            Reservering.Margin = new Thickness(10, 10, 0, 0);
            Reservering.SelectionMode = SelectionMode.Single;
            Reservering.Items.Add("Reserveringen:");
            Reservering.SelectionChanged += Reservering_SelectionChanged;
            ReserveringMain.Children.Add(Reservering);

            //alle properties van button invoeroke
            invoeroke.Margin = new Thickness(0, 0, 0, 0);
            invoeroke.Width = 50;
            invoeroke.Content = "Add";
            invoeroke.Click += Addreservering;

            //alle properties Terugknop
            Terug.Width = 50;
            Terug.Content = "terug";
            Terug.Click += Back;

            //alle properties van textbox invoerGroep
            invoerGroeptxt.Margin = new Thickness(0, 0, 0, 0);
            invoerGroeptxt.Width = 150;


            //alle properties van de stackpanel invoercheck
            invoercheck.Orientation = Orientation.Horizontal;
            invoercheck.HorizontalAlignment = HorizontalAlignment.Right;
            invoercheck.VerticalAlignment = VerticalAlignment.Bottom;
            invoercheck.Margin = new Thickness(0, 0, 10, 10);
            ReserveringMain.Children.Add(invoercheck);
            invoercheck.Children.Add(Terug);
            invoercheck.Children.Add(invoerGroeptxt);
            invoercheck.Children.Add(invoeroke);

            //stackpanel.children.add de button erin. en de textbox
        }

        public void Back(object sender, RoutedEventArgs e)
        {
            ReserveringMain.Children.Clear();
            MainWindow.MainMenu.Navigate(new HoofdMenu());
        }

        public void Addreservering(object sender, RoutedEventArgs e)
        {
            Reservering.Items.Add(invoerGroeptxt.Text);
            invoerGroeptxt.Text = "";
        }

        private void Reservering_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            strResVan = ((ListBox)sender).SelectedItem.ToString();
            if (strResVan != "Reserveringen:")
            {
                MainWindow.MainMenu.Navigate(new MenuKaart());
                //Wanneer je op de reservering van een groep klikt ga je naar de menukaart om hun bestelling op te nemen.
            }
        }
    }
}
