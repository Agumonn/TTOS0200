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

namespace LAB10_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void auto_Click(object sender, RoutedEventArgs e)
        {
            int count = int.Parse(txtblockauto.Text) +1;
            txtblockauto.Text = count.ToString();
        }

        private void rekka_Click(object sender, RoutedEventArgs e)
        {
            int count = int.Parse(txtblockrekka.Text) + 1;
            txtblockrekka.Text = count.ToString();
        }
    }
}