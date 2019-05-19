using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Assignment_04
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

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bingo");
        }


        private void ZipCodeBox_TextChanged(object sender, RoutedEventArgs e)
        {
            EnableDisableButton();
        }

        private void EnableDisableButton()
        {

            if (IsValidUSOrCanadianZipCode(uxZipCode.Text))
                uxSubmit.IsEnabled = true;
            else
                uxSubmit.IsEnabled = false;

        }

        private bool IsValidUSOrCanadianZipCode(string zipCode)
        {

            var _usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
            var _caZipRegEx = @"^([A-Y]\d[A-Z])\ {0,1}(\d[A-Z]\d)$";

            var validZipCode = true;
            if ((!Regex.Match(zipCode, _usZipRegEx).Success) && (!Regex.Match(zipCode, _caZipRegEx).Success))
            {
                validZipCode = false;
            }
            return validZipCode;
        }
    }
}
