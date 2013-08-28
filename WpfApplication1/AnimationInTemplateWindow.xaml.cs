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
using System.Threading;
using System.Collections.ObjectModel;
using System.Collections;

namespace WpfApplication1
{
    /// <summary>
    /// AnimationInTemplateWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AnimationInTemplateWindow : Window
    {
        public AnimationInTemplateWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke((ThreadStart)delegate(){
                lixtBox1.ItemsSource = new ObservableCollection<int>(Enumerable.Range(1, 10));
            });
        }
    }
}
