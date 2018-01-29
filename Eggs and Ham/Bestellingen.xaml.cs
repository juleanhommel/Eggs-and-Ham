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

        public Bestellingen()
        {
            InitializeComponent();
            BestelMenu.Children.Clear();
            BestelMenu.Children.Add(MenuKaart.MenuList);
        }

        public void ShowList(object sender, RoutedEventArgs e)
        {
            StackList.Children.Clear();
            if (((Button)sender).Content.ToString() == "Tafel 1")
            {
                StackList.Children.Add(Tafel_1);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 2")
            {
                StackList.Children.Add(Tafel_2);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 3")
            {
                StackList.Children.Add(Tafel_3);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 4")
            {
                StackList.Children.Add(Tafel_4);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 5")
            {
                StackList.Children.Add(Tafel_5);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 6")
            {
                StackList.Children.Add(Tafel_6);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 7")
            {
                StackList.Children.Add(Tafel_7);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 8")
            {
                StackList.Children.Add(Tafel_8);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 9")
            {
                StackList.Children.Add(Tafel_9);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 10")
            {
                StackList.Children.Add(Tafel_10);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 11")
            {
                StackList.Children.Add(Tafel_11);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 12")
            {
                StackList.Children.Add(Tafel_12);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 13")
            {
                StackList.Children.Add(Tafel_13);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 14")
            {
                StackList.Children.Add(Tafel_14);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 15")
            {
                StackList.Children.Add(Tafel_15);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 16")
            {
                StackList.Children.Add(Tafel_16);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 17")
            {
                StackList.Children.Add(Tafel_17);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 18")
            {
                StackList.Children.Add(Tafel_18);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 19")
            {
                StackList.Children.Add(Tafel_19);
            }
            else if (((Button)sender).Content.ToString() == "Tafel 20")
            {
                StackList.Children.Add(Tafel_20);
            }
            TafelNaam.Content = ((Button)sender).Content.ToString();
        }

        private void Terug_Click(object sender, RoutedEventArgs e)
        {
            BestelMenu.Children.Clear();
            StackList.Children.Clear();
            MainWindow.MainMenu.Navigate(new HoofdMenu());
        }
    }
}
