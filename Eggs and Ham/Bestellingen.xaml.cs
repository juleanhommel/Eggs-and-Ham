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
            InitializeComponent();
            //alle properties voor alle tafels.
            Tafel_1.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_1.VerticalAlignment = VerticalAlignment.Top;
            Tafel_1.Height = 100;
            Tafel_1.Width = 100;
            Tafel_1.Margin = new Thickness(0, 0, 0, 0);
            BestelWindow.Children.Add(Tafel_1);

            Tafel_2.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_2.VerticalAlignment = VerticalAlignment.Top;
            Tafel_2.Height = 100;
            Tafel_2.Width = 100;
            Tafel_2.Margin = new Thickness(100, 0, 0, 0);
            BestelWindow.Children.Add(Tafel_2);

            Tafel_3.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_3.VerticalAlignment = VerticalAlignment.Top;
            Tafel_3.Height = 100;
            Tafel_3.Width = 100;
            Tafel_3.Margin = new Thickness(200, 0, 0, 0);
            BestelWindow.Children.Add(Tafel_3);

            Tafel_4.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_4.VerticalAlignment = VerticalAlignment.Top;
            Tafel_4.Height = 100;
            Tafel_4.Width = 100;
            Tafel_4.Margin = new Thickness(300, 0, 0, 0);
            BestelWindow.Children.Add(Tafel_4);

            Tafel_5.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_5.VerticalAlignment = VerticalAlignment.Top;
            Tafel_5.Height = 100;
            Tafel_5.Width = 100;
            Tafel_5.Margin = new Thickness(0, 100, 0, 0);
            BestelWindow.Children.Add(Tafel_5);

            Tafel_6.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_6.VerticalAlignment = VerticalAlignment.Top;
            Tafel_6.Height = 100;
            Tafel_6.Width = 100;
            Tafel_6.Margin = new Thickness(100, 100, 0, 0);
            BestelWindow.Children.Add(Tafel_6);

            Tafel_7.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_7.VerticalAlignment = VerticalAlignment.Top;
            Tafel_7.Height = 100;
            Tafel_7.Width = 100;
            Tafel_7.Margin = new Thickness(200, 100, 0, 0);
            BestelWindow.Children.Add(Tafel_7);

            Tafel_8.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_8.VerticalAlignment = VerticalAlignment.Top;
            Tafel_8.Height = 100;
            Tafel_8.Width = 100;
            Tafel_8.Margin = new Thickness(300, 100, 0, 0);
            BestelWindow.Children.Add(Tafel_8);

            Tafel_9.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_9.VerticalAlignment = VerticalAlignment.Top;
            Tafel_9.Height = 100;
            Tafel_9.Width = 100;
            Tafel_9.Margin = new Thickness(0, 200, 0, 0);
            BestelWindow.Children.Add(Tafel_9);

            Tafel_10.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_10.VerticalAlignment = VerticalAlignment.Top;
            Tafel_10.Height = 100;
            Tafel_10.Width = 100;
            Tafel_10.Margin = new Thickness(100, 200, 0, 0);
            BestelWindow.Children.Add(Tafel_10);

            Tafel_11.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_11.VerticalAlignment = VerticalAlignment.Top;
            Tafel_11.Height = 100;
            Tafel_11.Width = 100;
            Tafel_11.Margin = new Thickness(200, 200, 0, 0);
            BestelWindow.Children.Add(Tafel_11);

            Tafel_12.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_12.VerticalAlignment = VerticalAlignment.Top;
            Tafel_12.Height = 100;
            Tafel_12.Width = 100;
            Tafel_12.Margin = new Thickness(300, 200, 0, 0);
            BestelWindow.Children.Add(Tafel_12);

            Tafel_13.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_13.VerticalAlignment = VerticalAlignment.Top;
            Tafel_13.Height = 100;
            Tafel_13.Width = 100;
            Tafel_13.Margin = new Thickness(0, 300, 0, 0);
            BestelWindow.Children.Add(Tafel_13);

            Tafel_14.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_14.VerticalAlignment = VerticalAlignment.Top;
            Tafel_14.Height = 100;
            Tafel_14.Width = 100;
            Tafel_14.Margin = new Thickness(100, 300, 0, 0);
            BestelWindow.Children.Add(Tafel_14);

            Tafel_15.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_15.VerticalAlignment = VerticalAlignment.Top;
            Tafel_15.Height = 100;
            Tafel_15.Width = 100;
            Tafel_15.Margin = new Thickness(200, 300, 0, 0);
            BestelWindow.Children.Add(Tafel_15);

            Tafel_16.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_16.VerticalAlignment = VerticalAlignment.Top;
            Tafel_16.Height = 100;
            Tafel_16.Width = 100;
            Tafel_16.Margin = new Thickness(300, 300, 0, 0);
            BestelWindow.Children.Add(Tafel_16);

            Tafel_17.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_17.VerticalAlignment = VerticalAlignment.Top;
            Tafel_17.Height = 100;
            Tafel_17.Width = 100;
            Tafel_17.Margin = new Thickness(0, 400, 0, 0);
            BestelWindow.Children.Add(Tafel_17);

            Tafel_18.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_18.VerticalAlignment = VerticalAlignment.Top;
            Tafel_18.Height = 100;
            Tafel_18.Width = 100;
            Tafel_18.Margin = new Thickness(100, 400, 0, 0);
            BestelWindow.Children.Add(Tafel_18);

            Tafel_19.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_19.VerticalAlignment = VerticalAlignment.Top;
            Tafel_19.Height = 100;
            Tafel_19.Width = 100;
            Tafel_19.Margin = new Thickness(200, 400, 0, 0);
            BestelWindow.Children.Add(Tafel_19);

            Tafel_20.HorizontalAlignment = HorizontalAlignment.Left;
            Tafel_20.VerticalAlignment = VerticalAlignment.Top;
            Tafel_20.Height = 100;
            Tafel_20.Width = 100;
            Tafel_20.Margin = new Thickness(300, 400, 0, 0);
            BestelWindow.Children.Add(Tafel_20);

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
