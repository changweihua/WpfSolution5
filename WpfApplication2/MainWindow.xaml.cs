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
using System.Media;
using System.IO;

namespace WpfApplication2
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

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "test.wav";

            try
            {
                player.Load();
                player.Play();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
