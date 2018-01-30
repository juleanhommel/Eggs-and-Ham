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
    /// Interaction logic for MenuKaart.xaml
    /// </summary>
    public partial class MenuKaart : Page
    {
        public static ListBox MenuList = new ListBox();
        public MenuKaart()
        {
            InitializeComponent();
            MenuBox.Children.Clear();
            MenuBox.Children.Add(MenuList);
            Dummydata();
        }
        public static void Dummydata()
        {
            MenuList.Items.Clear();
            string[] regels = LoadMenu();
            foreach (string line in regels)
            {
                MenuList.Items.Add(line);
            }
        }

        private void Terug_Click(object sender, RoutedEventArgs e)
        {
            MenuBox.Children.Clear();
            MainWindow.MainMenu.Navigate(new HoofdMenu());
        }

        public static string[] LoadMenu()
        {
            StreamReader sr = new StreamReader("../../List/Menu.txt");
            String line;
            String[] lines = new string[0];
            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                Array.Resize(ref lines, lines.Length + 1);
                lines[i] = line;
                i++;
            }
            return lines;
        }


        public static void WriteText()
        {
            using (StreamWriter sw = new StreamWriter("../../List/Menu.txt"))
            {
                foreach (string line in MenuList.Items)
                {
                    sw.WriteLine(line);
                }
            }
        }

        private void Toevoegen_Click(object sender, RoutedEventArgs e)
        {
            MenuList.Items.Add(NextItem.Text);
            WriteText();
            NextItem.Text = "";
        }

        private void Vervangen_Click(object sender, RoutedEventArgs e)
        {
            if (MenuList.SelectedIndex != -1)
            {
                int index = MenuList.SelectedIndex;
                MenuList.Items.RemoveAt(index);
                MenuList.Items.Insert(index, NextItem.Text);
                WriteText();
                NextItem.Text = "";
            }
        }
    }
}