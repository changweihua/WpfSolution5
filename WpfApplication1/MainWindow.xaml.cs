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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.From = button1.ActualWidth;
            widthAnimation.To = this.Width - 30;
            widthAnimation.Duration = TimeSpan.FromSeconds(5);
            widthAnimation.DecelerationRatio = 0.7;
            button1.BeginAnimation(Button.WidthProperty, widthAnimation);
        }
    }
}
