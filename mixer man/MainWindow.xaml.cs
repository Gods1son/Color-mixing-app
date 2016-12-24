using System;
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

namespace mixer_man
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

        private void sldRed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        { 
            var r = (byte)sldRed.Value;
            var g = (byte)sldGreen.Value;
            var b = (byte)sldBlue.Value;
            var color = Color.FromRgb(r, g, b);
            if (cnvColor != null)
            {
                cnvColor.Background = new SolidColorBrush(color);
            }
        }
    }
}
