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
        // red
        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Red;
        }

        // verandert alle mouseleave naam naar terug grijs zodat je dit maar 1 keer moet veranderen
        private void GrijsOpnieuw(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.LightGray;
        }
        // geel
        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Yellow;
        }
        // groen
        private void Image_MouseEnter_2(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Green;
        }
        // blauw
        private void Image_MouseEnter_3(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Blue;
        }
        // rood
        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            KleurCodeBox.Text = "Rood: #FF0000";
            InformatieBox.Text = "Rood is de kleur van warmte";
        }
        // groen
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            KleurCodeBox.Text = "Groen: #008000";
            InformatieBox.Text = "Groen is de kleur van genezing";
        }
        // geel
        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            KleurCodeBox.Text = "Geel: #FFFF00";
            InformatieBox.Text = "Geel is de kleur van levenslust";
        }
        // blauw
        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            KleurCodeBox.Text = "Blauw: #0000FF";
            InformatieBox.Text = "Blauw is de kleur van intelligentie";
        }
        
    }
}