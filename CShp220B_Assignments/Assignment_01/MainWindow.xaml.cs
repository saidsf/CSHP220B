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

namespace Assignment_01
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableDisableButton();
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bingo!");
        }

        private void PasswordBox_TextChanged(object sender, RoutedEventArgs e)
        {
            EnableDisableButton();
        }

        private void EnableDisableButton()
        {
            if (uxName.Text != string.Empty && uxPassword.ToString() != string.Empty)
                uxSubmit.IsEnabled = true;
            else
                uxSubmit.IsEnabled = false;

        }
    }
}
