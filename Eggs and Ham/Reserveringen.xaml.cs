﻿using System;
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
        public static string strResVan;
        public static StackPanel invoercheck = new StackPanel();
        public static Button invoeroke = new Button();
        public static TextBox invoerGroep = new TextBox();
        public Reserveringen()
        {
            InitializeComponent();
            //alle properties van de listbox bij reserveringen
            Reservering.HorizontalAlignment = HorizontalAlignment.Left;
            Reservering.VerticalAlignment = VerticalAlignment.Top;
            Reservering.Margin = new Thickness(10, 10, 0, 0);
            ReserveringMain.Children.Add(Reservering);
            Reservering.SelectionMode = SelectionMode.Single;
            Reservering.Items.Add("Nieuwe reservering");
            Reservering.SelectionChanged += Reservering_SelectionChanged;

            //alle properties van button invoeroke
            invoeroke.Margin = new Thickness(0, 0, 0, 0);
            invoeroke.Content = "ADD";

            //alle properties van textbox invoerGroep
            invoerGroep.Margin = new Thickness(0, 0, 0, 0);
            invoerGroep.Width = 150;


            //alle properties van de stackpanel invoercheck
            invoercheck.Orientation = Orientation.Horizontal;
            invoercheck.HorizontalAlignment = HorizontalAlignment.Right;
            invoercheck.VerticalAlignment = VerticalAlignment.Bottom;
            invoercheck.Margin = new Thickness(0, 0, 10, 10);
            ReserveringMain.Children.Add(invoercheck);
            invoercheck.Children.Add(invoerGroep);
            invoercheck.Children.Add(invoeroke);
            
            //stackpanel.children.add de button erin. en de textbox
        }

        private void Reservering_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            strResVan = ((ListBox)sender).SelectedItem.ToString();
            if (strResVan == "Nieuwe reservering")
            {

                //Wanneer je op nieuwe reservering klikt dan word er een nieuw item aangemaakt in de reserveringen lijst.
            }
            else
            {
                MainWindow.MainMenu.Navigate(new MenuKaart());
                //Wanneer je op de reservering van een groep klikt ga je naar de menukaart om hun bestelling op te nemen.
            }
        }
    }
}