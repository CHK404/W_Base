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
using System.Windows.Shapes;

namespace WpfApp_01_Base
{
    /// <summary>
    /// Interaction logic for ColorSlider.xaml
    /// </summary>
    public partial class ColorSlider : Window
    {
        public ColorSlider()
        {
            InitializeComponent();
        }
        int R, G, B;
        private void R_Value(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            R = Convert.ToInt32(e.NewValue);
            current_R.Content = R.ToString();
            UpdateBackgroundColor();
        }

        private void G_Value(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            G = Convert.ToInt32(e.NewValue);
            current_G.Content = G.ToString();
            UpdateBackgroundColor();
        }

        private void graytone_Checked(object sender, RoutedEventArgs e)
        {
            int C = (R + G + B) / 3;
            Background = new SolidColorBrush(Color.FromRgb((byte)C, (byte)C, (byte)C));
        }

        private void invert_Checked(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Color.FromRgb((byte)(255-R), (byte)(255-G), (byte)(255-B)));
        }

        private void original_Checked(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Color.FromRgb((byte)R, (byte)G, (byte)B));
        }

        private void B_Value(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            B = Convert.ToInt32(e.NewValue);
            current_B.Content = B.ToString();
            UpdateBackgroundColor();
        }
        private void UpdateBackgroundColor()
        {
            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb((byte)R, (byte)G, (byte)B));
            if (GrayTone.IsChecked == true)
            {
                int C = (R + G + B) / 3;
                brush = new SolidColorBrush(Color.FromRgb((byte)C, (byte)C, (byte)C));
            }
            else if (Invert.IsChecked == true)
            {
                brush = new SolidColorBrush(Color.FromRgb((byte)(255 - R), (byte)(255 - G), (byte)(255 - B)));
            }
            Background = brush;
        }

    }
}
