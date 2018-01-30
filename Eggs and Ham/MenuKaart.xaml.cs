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
            LoadMenu();
        }

        private void Terug_Click(object sender, RoutedEventArgs e)
        {
            MenuBox.Children.Clear();
            MainWindow.MainMenu.Navigate(new HoofdMenu());
        }

        public static void LoadMenu()
        {
            StreamReader sr = new StreamReader("../../List/Menu.txt");
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                MenuList.Items.Add(line);
            }

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
    }
}