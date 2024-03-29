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
    /// Interaction logic for logarithms.xaml
    /// </summary>
    public partial class logarithms : Page
    {
        public logarithms()
        {
            InitializeComponent();

            ___informationBox_.Text = File.ReadAllText("LogarithmInfo.txt");
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
                double a = Convert.ToDouble(___inputBoxa__.Text);
                double b = Convert.ToDouble(___inputBoxb__.Text);

                double power = Math.Log(b, a);

                ___endProductBox_.Text = Convert.ToString(power);
            }
            

        }



        private void helpClick(object sender, RoutedEventArgs e)
        {

        }

        private void backClick(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("LogarithmInfo.txt"); 
            File.Write(___informationBox_.Text);
            File.Close();

            Frame.Navigate(new Individual_formula_page_template());
            this.Frame.Navigate(new Uri("Individual_formula_page_template.xaml", UriKind.Relative));
        }

        private void ___create_file__Click(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("LogarithmInfo.txt"); 
            File.Write(___informationBox_.Text);
            File.Close();
        }


        private void ___FillButtonClick_(object sender, RoutedEventArgs e)
        {
            ___informationBox_.Text = File.ReadAllText("LogarithmInfo.txt");
        }
    }
}
