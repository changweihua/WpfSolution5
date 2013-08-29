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

namespace WpfApplication2
{
    /// <summary>
    /// MediaElementWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MediaElementWindow : Window
    {
        public MediaElementWindow()
        {
            InitializeComponent();
        }

        private void media_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("文件加载失败" + e.ErrorException.Message);
        }
    }
}
