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
    /// Interaction logic for Rekening.xaml
    /// </summary>
    public partial class Rekening : Page
    {
        public Rekening()
        {
            InitializeComponent();
        }
        public void Terug_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainMenu.Navigate(new HoofdMenu());
        }
    }
}
