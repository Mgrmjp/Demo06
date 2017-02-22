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

namespace WindowApp
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

        private void laskeButton_click(object sender, RoutedEventArgs e)
        {
            int leveys = int.Parse(leveystextBox.Text);
            int korkeus = int.Parse(korkeustextBox.Text);
            int ikkuna_pinta_ala = (leveys * korkeus) / 10;
            ikkunapintatextBox.Text = ikkuna_pinta_ala.ToString() + " cm^2";

            int lasi_leveys = int.Parse(leveystextBox.Text) - int.Parse(karmitextBox.Text) * 2;
            int lasi_korkeus = int.Parse(korkeustextBox.Text) - int.Parse(karmitextBox.Text) * 2;
            int lasi_pinta_ala = (lasi_leveys * lasi_korkeus) / 10;
            lasipintatextBox.Text = lasi_pinta_ala.ToString() + " cm^2";

            int karmipiiri =  ((leveys + korkeus) * 2 ) / 10;
            karmipiiritextBox.Text = karmipiiri.ToString() + " cm";

        }
    }
}
