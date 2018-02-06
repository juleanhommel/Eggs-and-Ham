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
    /// Interaction logic for Reserveringen.xaml
    /// </summary>
    public partial class Reserveringen : Page
    {
        public int vrij = 20;
        public Reserveringen()
        {
            InitializeComponent();
            this.LoadRes();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (vrij > 0)
            {
                vrij--;
                ResList.Items.Add(InvoerReservering.Text);
                InvoerReservering.Text = "";
                this.WriteText();
            }
            UpdatePlaatsen();
        }

        public void WriteText()
        {
            using (StreamWriter sw = new StreamWriter("../../List/Reservering.txt"))
            {
                foreach (string line in ResList.Items)
                {
                    sw.WriteLine(line);
                }
                sw.Close();
            }
        }

        public void LoadRes()
        {
            vrij = 20;
            ResList.Items.Clear();
            string[] regels = LoadMenu();
            foreach (string line in regels)
            {
                ResList.Items.Add(line);
                vrij--;
            }
            UpdatePlaatsen();
        }

        public static string[] LoadMenu()
        {
            StreamReader sr = new StreamReader("../../List/Reservering.txt");
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

        private void Terug_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainMenu.Navigate(new HoofdMenu());
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (ResList.SelectedIndex != -1)
            {
                int index = ResList.SelectedIndex;
                ResList.Items.RemoveAt(index);
                this.WriteText();
                vrij++;
            }
            UpdatePlaatsen();
        }
        public void UpdatePlaatsen()
        {
            plaatsen.Content = "Beschikbare plaatsen: " + vrij;
        }
    }
}
