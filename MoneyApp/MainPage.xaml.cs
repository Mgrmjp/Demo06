using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MoneyApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void markat_Click(object sender, RoutedEventArgs e)
        {
            double number = double.Parse(amount.Text) * 5.94573;
            string value = number.ToString("0.00" + "mk");
            result.Text = value.ToString();     
        }

        private void eurot_Click(object sender, RoutedEventArgs e)
        {
            double number = double.Parse(amount.Text) / 5.94573;
            string value = number.ToString("0.00" + "€");
            result.Text = value.ToString();
        }
    }
}
