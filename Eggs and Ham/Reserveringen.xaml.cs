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
    /// 
    /// ik kan de hele tijd op knoppen drukken deze zullen dan van kleur veranderen als ze niet rood zijn.
    /// ik wou ze naar oranje laten veranderen en weer terug wanneer je er nog een keer op klikt.
    /// wanneer ik op toevoegen klik verander ik alle oranje buttons in rode en schrijf ik
    /// in bezet.txt de reserveringsnaam op de juiste regel.
    /// </summary>
    public partial class Reserveringen : Page
    {
        public int vrij = 20;
        public Reserveringen()
        {
            InitializeComponent();
            ResList.SelectionMode = SelectionMode.Single;
            this.LoadRes();
            this.TafelGrijs();
        }

        public void TafelGrijs()
        {
            Tafel1.Background = Brushes.LightGray;
            Tafel2.Background = Brushes.LightGray;
            Tafel3.Background = Brushes.LightGray;
            Tafel4.Background = Brushes.LightGray;
            Tafel5.Background = Brushes.LightGray;
            Tafel6.Background = Brushes.LightGray;
            Tafel7.Background = Brushes.LightGray;
            Tafel8.Background = Brushes.LightGray;
            Tafel9.Background = Brushes.LightGray;
            Tafel10.Background = Brushes.LightGray;
            Tafel11.Background = Brushes.LightGray;
            Tafel12.Background = Brushes.LightGray;
            Tafel13.Background = Brushes.LightGray;
            Tafel14.Background = Brushes.LightGray;
            Tafel15.Background = Brushes.LightGray;
            Tafel16.Background = Brushes.LightGray;
            Tafel17.Background = Brushes.LightGray;
            Tafel18.Background = Brushes.LightGray;
            Tafel19.Background = Brushes.LightGray;
            Tafel20.Background = Brushes.LightGray;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (vrij > 0)
            {
                string[] lines = LoadTafels();
                bool bestaat = false;
                //deze loop kijkt of er al een reservering bestaat onder deze naam.
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] == InvoerReservering.Text)
                    {
                        bestaat = true;
                    }
                }
                if (!bestaat)
                {
                    vrij--;
                    ResList.Items.Add(InvoerReservering.Text);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i] == "leeg")
                        {
                            lines[i] = InvoerReservering.Text;
                            i = lines.Length;
                        }
                    }
                }
                using (StreamWriter sw = new StreamWriter("../../List/bezet.txt"))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                    sw.Close();
                }
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

        public void SelectTable(object sender, RoutedEventArgs e)
        {
            /*
            //dit werkte nog niet vanwege het if statement
            if ((string)sender == "Tafel 1")
            {
                if (Tafel1.Background != Brushes.Red)
                {
                    Tafel1.Background = Brushes.Orange;
                }
            }
            else if ((string)sender == Tafel2.ToString())
            {
                if (Tafel2.Background != Brushes.Red)
                {
                    Tafel2.Background = Brushes.Orange;
                }
            }
            */
        }

        public string[] LoadTafels()
        {
            StreamReader sr = new StreamReader("../../List/bezet.txt");
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
        public void SelectReserve(object sender, SelectionChangedEventArgs e)
        {
            //ik selecteer een reservering uit de lijst
            string[] lines = LoadTafels();
            TafelGrijs();
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == ResList.SelectedItem.ToString())
                {
                    TafelGevonden(i);
                }
            }
        }
        //wanneer ik een tafel vind met de zelfde reserveringsnaam die ik geselecteerd heb.
        public void TafelGevonden(int i)
        {
            switch (i+1)
            {
                case 1:
                    Tafel1.Background = Brushes.Red;
                    break;
                case 2:
                    Tafel2.Background = Brushes.Red;
                    break;
                case 3:
                    Tafel3.Background = Brushes.Red;
                    break;
                case 4:
                    Tafel4.Background = Brushes.Red;
                    break;
                case 5:
                    Tafel5.Background = Brushes.Red;
                    break;
                case 6:
                    Tafel6.Background = Brushes.Red;
                    break;
                case 7:
                    Tafel7.Background = Brushes.Red;
                    break;
                case 8:
                    Tafel8.Background = Brushes.Red;
                    break;
                case 9:
                    Tafel9.Background = Brushes.Red;
                    break;
                case 10:
                    Tafel10.Background = Brushes.Red;
                    break;
                case 11:
                    Tafel11.Background = Brushes.Red;
                    break;
                case 12:
                    Tafel12.Background = Brushes.Red;
                    break;
                case 13:
                    Tafel13.Background = Brushes.Red;
                    break;
                case 14:
                    Tafel14.Background = Brushes.Red;
                    break;
                case 15:
                    Tafel15.Background = Brushes.Red;
                    break;
                case 16:
                    Tafel16.Background = Brushes.Red;
                    break;
                case 17:
                    Tafel17.Background = Brushes.Red;
                    break;
                case 18:
                    Tafel18.Background = Brushes.Red;
                    break;
                case 19:
                    Tafel19.Background = Brushes.Red;
                    break;
                case 20:
                    Tafel20.Background = Brushes.Red;
                    break;
            }
        }

        private void Terug_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainMenu.Navigate(new HoofdMenu());
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (ResList.SelectedIndex != -1)
            {
                string[] lines = LoadTafels();
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] == ResList.SelectedItems.ToString())
                    {
                        lines[i] = "leeg";
                    }
                }
                int index = ResList.SelectedIndex;
                ResList.Items.RemoveAt(index);
                this.WriteText();
                vrij++;
                using (StreamWriter sw = new StreamWriter("../../List/bezet.txt"))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                    sw.Close();
                }
            }
            UpdatePlaatsen();
        }
        public void UpdatePlaatsen()
        {
            plaatsen.Content = "Beschikbare plaatsen: " + vrij;
        }
    }
}
