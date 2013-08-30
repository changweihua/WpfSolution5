using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication3
{
    /// <summary>
    /// CustomControlsWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CustomControlsWindow : Window
    {
        public CustomControlsWindow()
        {
            InitializeComponent();
        }

        private void colorPicker_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {
            if (e.NewValue != null)
            {
                tbColor.Text = "新颜色" + e.NewValue.ToString();
            }
        }
    }
}
