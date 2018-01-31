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
using System.IO;

namespace Eggs_and_Ham
{
    /// <summary>
    /// Interaction logic for Bestellingen.xaml
    /// </summary>
    public partial class Bestellingen : Page
    {
        public static ListBox MenuSelect = new ListBox();
        public static string Table;

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

        public static String TafelNaam;

        public Bestellingen()
        {
            InitializeComponent();
            BestelMenu.Children.Clear();
            BestelMenu.Children.Add(MenuKaart.MenuList);
            MenuKaart.Dummydata();
        }

        public void ShowList(object sender, RoutedEventArgs e)
        {
            StackList.Children.Clear();
            if (((Button)sender).Content.ToString() == "Tafel 1")
            {
                StackList.Children.Add(Tafel_1);
                Table = "Tafel_1";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 2")
            {
                StackList.Children.Add(Tafel_2);
                Table = "Tafel_2";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 3")
            {
                StackList.Children.Add(Tafel_3);
                Table = "Tafel_3";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 4")
            {
                StackList.Children.Add(Tafel_4);
                Table = "Tafel_4";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 5")
            {
                StackList.Children.Add(Tafel_5);
                Table = "Tafel_5";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 6")
            {
                StackList.Children.Add(Tafel_6);
                Table = "Tafel_6";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 7")
            {
                StackList.Children.Add(Tafel_7);
                Table = "Tafel_7";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 8")
            {
                StackList.Children.Add(Tafel_8);
                Table = "Tafel_8";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 9")
            {
                StackList.Children.Add(Tafel_9);
                Table = "Tafel_9";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 10")
            {
                StackList.Children.Add(Tafel_10);
                Table = "Tafel_10";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 11")
            {
                StackList.Children.Add(Tafel_11);
                Table = "Tafel_11";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 12")
            {
                StackList.Children.Add(Tafel_12);
                Table = "Tafel_12";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 13")
            {
                StackList.Children.Add(Tafel_13);
                Table = "Tafel_13";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 14")
            {
                StackList.Children.Add(Tafel_14);
                Table = "Tafel_14";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 15")
            {
                StackList.Children.Add(Tafel_15);
                Table = "Tafel_15";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 16")
            {
                StackList.Children.Add(Tafel_16);
                Table = "Tafel_16";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 17")
            {
                StackList.Children.Add(Tafel_17);
                Table = "Tafel_17";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 18")
            {
                StackList.Children.Add(Tafel_18);
                Table = "Tafel_18";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 19")
            {
                StackList.Children.Add(Tafel_19);
                Table = "Tafel_19";
            }
            else if (((Button)sender).Content.ToString() == "Tafel 20")
            {
                StackList.Children.Add(Tafel_20);
                Table = "Tafel_20";
            }
            //dit is de titel label
            TafelSelected.Content = ((Button)sender).Content.ToString();
            DataOver();
        }

        private void Terug_Click(object sender, RoutedEventArgs e)
        {
            BestelMenu.Children.Clear();
            StackList.Children.Clear();
            MainWindow.MainMenu.Navigate(new HoofdMenu());
        }

        private void Toevoegen_Click(object sender, RoutedEventArgs e)
        {
            if (TafelSelected.Content.ToString() != "Tafel" && MenuKaart.MenuList.SelectedIndex != -1)
            {
                if (Table == "Tafel_1")
                {
                    Tafel_1.Items.Add(MenuKaart.MenuList.SelectedItem);
                }
                WriteText();
            }
        }

        public void DataOver()
        {
            string[] regels = LoadMenu();
            if (Table == "Tafel_1")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_1.Items.Add(line);
                }
            }
            else if (Table == "Tafel_2")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_2.Items.Add(line);
                }
            }
            else if (Table == "Tafel_3")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_3.Items.Add(line);
                }
            }
            else if (Table == "Tafel_4")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_4.Items.Add(line);
                }
            }
            else if (Table == "Tafel_5")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_5.Items.Add(line);
                }
            }
            else if (Table == "Tafel_6")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_6.Items.Add(line);
                }
            }
            else if (Table == "Tafel_7")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_7.Items.Add(line);
                }
            }
            else if (Table == "Tafel_8")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_8.Items.Add(line);
                }
            }
            else if (Table == "Tafel_9")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_9.Items.Add(line);
                }
            }
            else if (Table == "Tafel_10")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_10.Items.Add(line);
                }
            }
            else if (Table == "Tafel_11")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_11.Items.Add(line);
                }
            }
            else if (Table == "Tafel_12")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_12.Items.Add(line);
                }
            }
            else if (Table == "Tafel_13")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_13.Items.Add(line);
                }
            }
            else if (Table == "Tafel_14")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_14.Items.Add(line);
                }
            }
            else if (Table == "Tafel_15")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_15.Items.Add(line);
                }
            }
            else if (Table == "Tafel_16")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_16.Items.Add(line);
                }
            }
            else if (Table == "Tafel_17")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_17.Items.Add(line);
                }
            }
            else if (Table == "Tafel_18")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_18.Items.Add(line);
                }
            }
            else if (Table == "Tafel_19")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_19.Items.Add(line);
                }
            }
            else if (Table == "Tafel_20")
            {
                Tafel_1.Items.Clear();
                foreach (string line in regels)
                {
                    Tafel_20.Items.Add(line);
                }
            }
        }

        public static string[] LoadMenu()
        {
            string path = "../../List/" + Table + ".txt";
            StreamReader sr = new StreamReader(path);
            String line;
            String[] lines = new string[0];
            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                Array.Resize(ref lines, lines.Length + 1);
                lines[i] = line;
                i++;
            }
            sr.Close();
            return lines;
        }

        public static void WriteText()
        {
            string path = "../../List/" + Table + ".txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                if (Table == "Tafel_1")
                {
                    foreach (string line in Tafel_1.Items)
                    {
                        sw.WriteLine(line);
                    }
                }
                sw.Close();
            }
        }
    }
}
