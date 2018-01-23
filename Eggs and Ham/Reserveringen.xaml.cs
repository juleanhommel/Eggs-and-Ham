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
        public Reserveringen()
        {
            InitializeComponent();
            Reservering.HorizontalAlignment = HorizontalAlignment.Left;
            Reservering.VerticalAlignment = VerticalAlignment.Top;
            Reservering.Margin = new Thickness(10, 10, 0, 0);
            ReserveringMain.Children.Add(Reservering);
            Reservering.SelectionMode = SelectionMode.Single;
            Reservering.Items.Add("Nieuwe reservering");
        }
    }
}
