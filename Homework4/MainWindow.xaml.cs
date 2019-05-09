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

namespace Homework4
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

        private void UxInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            uxButton.IsEnabled = false;
            if (CheckZipCode(uxInput.Text))
                uxButton.IsEnabled = true;
        }

        private bool CheckZipCode(string zipCode)
        {
            var usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
            var caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";

            var isValidZipCode = true;
            if ((!Regex.Match(zipCode, usZipRegEx).Success) && (!Regex.Match(zipCode, caZipRegEx).Success))
            {
                isValidZipCode = false;
            }
            return isValidZipCode;
        }
    }
}

