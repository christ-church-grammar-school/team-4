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
using System.IO;

namespace Maths_Formula_App
{
    /// <summary>
    /// Interaction logic for SinCosTan.xaml
    /// </summary>
    public partial class SinCosTan : Page
    {
        public SinCosTan()
        {
            InitializeComponent();
        }

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            if (___inputBoxa__.Text == "")
            {
                MessageBox.Show("Enter value for a. ");
            }


            else if (___inputBoxb__.Text == "")
            {
                MessageBox.Show("Enter value for b. ");
            }
            else
            {
                
            }
        }

        private void backClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new geometry());
            this.Frame.Navigate(new Uri("geometry.xaml", UriKind.Relative));
        }

        private void helpClick(object sender, RoutedEventArgs e)
        {
            
            Frame.Navigate(new Help());
            this.Frame.Navigate(new Uri("Help.xaml", UriKind.Relative));
            
        }

        private void ___create_file__Click(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("SinCosTanInfo.txt");//puts the file in the bin, debug. 
            File.Write(___informationBox_.Text);
            File.Close();
        }

        private void ___FillButtonClick_(object sender, RoutedEventArgs e)
        {
            ___informationBox_.Text = File.ReadAllText("SinCosTanInfo.txt");
        }
    }
}
