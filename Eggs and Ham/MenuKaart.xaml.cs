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
    /// Interaction logic for MenuKaart.xaml
    /// </summary>
    public partial class MenuKaart : Page
    {
        public static ListBox MenuKaartLB = new ListBox();
        public static StackPanel terugPanel = new StackPanel();
        public static Button terugknop = new Button();

        public static Button invoeroke = new Button();
        public static TextBox invoerGroeptxt = new TextBox();
        public MenuKaart()
        {
            InitializeComponent();
            //terugknop
            terugknop.Width = 50;
            terugknop.Content = "terug";
            terugknop.Click += Terug;

            //button invoeroke

            invoeroke.Margin = new Thickness(0, 0, 0, 0);
            invoeroke.Width = 50;
            invoeroke.Content = "Add";
            invoeroke.Click += MenuItem;

            //de textbox
            invoerGroeptxt.Margin = new Thickness(0, 0, 0, 0);
            invoerGroeptxt.Width = 150;


            //stackpanel properties
            terugPanel.Orientation = Orientation.Horizontal;
            terugPanel.HorizontalAlignment = HorizontalAlignment.Right;
            terugPanel.VerticalAlignment = VerticalAlignment.Bottom;
            terugPanel.Margin = new Thickness(0, 0, 10, 10);
            Menu_kaart.Children.Add(terugPanel);
            terugPanel.Children.Add(terugknop);
            terugPanel.Children.Add(invoerGroeptxt);
            terugPanel.Children.Add(invoeroke);

            

            MenuKaartLB.Items.Add("Menu Kaart");
            MenuKaartLB.Items.Add("Eggs");
            MenuKaartLB.HorizontalAlignment = HorizontalAlignment.Left;
            MenuKaartLB.VerticalAlignment = VerticalAlignment.Top;
            MenuKaartLB.Margin = new Thickness(10, 10, 0, 0);
            Menu_kaart.Children.Add(MenuKaartLB);
            MenuKaartLB.SelectionChanged += AddGerecht;

        }

        public void Terug(object sender, RoutedEventArgs e)
        {
            MainWindow.MainMenu.Navigate(new HoofdMenu());
        }

        public void MenuItem(object sender, RoutedEventArgs e)
        {
            //een item toevoegen aan de menukaart.
            MenuKaartLB.Items.Add(invoerGroeptxt.Text);
            invoerGroeptxt.Text = "";
        }

        public void AddGerecht(object sender, SelectionChangedEventArgs e)
        {
            if (((ListBox)sender).SelectedItem.ToString() != "Menu Kaart")
            {
                //Reserveringen.strResVan
                
            }
        }
    }
}
