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
        public static ListBox MenuList = new ListBox();
        public MenuKaart()
        {
            InitializeComponent();
            MenuBox.Children.Clear();
            MenuBox.Children.Add(MenuList);
            Dummydata();
        }
        public void Dummydata()
        {
            MenuList.Items.Clear();
            MenuList.Items.Add("Eggs");
            MenuList.Items.Add("Ham");
            MenuList.Items.Add("Steak");
            MenuList.Items.Add("Cola");
            MenuList.Items.Add("Fanta");
            MenuList.Items.Add("7-Up");
        }
    }
}
