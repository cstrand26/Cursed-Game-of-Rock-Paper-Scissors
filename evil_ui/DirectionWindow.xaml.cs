﻿using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace evil_ui
{
    /// <summary>
    /// Interaction logic for DirectionWindow.xaml
    /// </summary>
    public partial class DirectionWindow : Window
    {
        public DirectionWindow()
        {
            InitializeComponent();
        }
        private void Images(object sender, RoutedEventArgs e)
        {
            try
            {
                Direction_Img.Source = new BitmapImage(new Uri($@"{MainWindow.path}/images/Directions.jpg"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Whoops! Something went wrong:\n{0}", ex.Message);
            }
        }

        // close button just closes
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
