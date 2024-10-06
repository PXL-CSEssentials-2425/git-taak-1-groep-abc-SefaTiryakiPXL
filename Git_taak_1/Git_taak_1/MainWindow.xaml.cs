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

namespace Git_taak_1
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
        // onderste 2 zijn de hover effect
        private void PXLpng_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = PxlPhoto.Source != null ? new SolidColorBrush(Colors.LightBlue) : new SolidColorBrush(Colors.LightGray);
        }

        // MouseLeave = event for the PXL Image (Achtergrond)
        private void PXLpng_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.LightGray);
        }
        private void KleurButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender == roodButton)
            {
                ShowColorInfo("#FF0000", "Rood is de kleur van warmte.", "Rood.png");
            }
            else if (sender == groenButton)
            {
                ShowColorInfo("#008000", "Groen is de kleur van genezing.", "Groen.png");
            }
            else if (sender == blauwButton)
            {
                ShowColorInfo("#0000FF", "Blauw is de kleur van intelligentie.", "Blauw.png");
            }
            else if (sender == geelButton)
            {
                ShowColorInfo("#FFFF00", "Geel is de kleur van levenslust.", "Geel.png");
            }

        }

        // Help functie voor de kleuren te updaten en informatie 
        private void ShowColorInfo(string colorCode, string colorInfo, string imagePath)
        {
            ColorCodeText.Text = $"Kleurcode: {colorCode}";
            ColorInfoText.Text = colorInfo;
            ColorImageDisplay.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
        }
    }
}