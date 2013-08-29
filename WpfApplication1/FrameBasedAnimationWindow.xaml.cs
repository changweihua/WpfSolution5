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

namespace WpfApplication1
{
    /// <summary>
    /// FrameBasedAnimationWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FrameBasedAnimationWindow : Window
    {
        private List<EllipseInfo> ellipses = new List<EllipseInfo>();

        private double accelerationY = 2;
        private int minStartingSpeed = 1;
        private int maxStartingSpeed = 50;
        private double speedRatio = 0.1;
        private int minEllipses = 20;
        private int maxEllipses = 100;
        private int ellipseRadius = 10;

        private bool rendering = false;

        public FrameBasedAnimationWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if(!rendering)
            {
                ellipses.Clear();
                canvas.Children.Clear();

                CompositionTarget.Rendering += CompositionTarget_Rendering;
                rendering = true;
            }
        }

        void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            if (ellipses.Count == 0)
            {
                int halfCanvasWidth = (int)canvas.ActualWidth / 2;

                Random rnd = new Random();

                int count = rnd.Next(minEllipses, maxEllipses);

                for (int i = 0; i < count; i++)
                {
                    Ellipse ellipse = new Ellipse();
                    ellipse.Fill = Brushes.LimeGreen;
                    ellipse.Width = ellipseRadius;
                    ellipse.Height = ellipseRadius;

                    Canvas.SetLeft(ellipse, halfCanvasWidth + rnd.Next(-halfCanvasWidth, halfCanvasWidth));
                    Canvas.SetTop(ellipse, 0);

                    canvas.Children.Add(ellipse);

                    EllipseInfo info = new EllipseInfo(ellipse, speedRatio * rnd.Next(minStartingSpeed, maxStartingSpeed));

                    ellipses.Add(info);

                }

            }
            else
            {
                for (int i = 0; i < ellipses.Count-1; i++)
                {
                    EllipseInfo info = ellipses[i];
                    double top = Canvas.GetTop(info.Ellipse);
                    Canvas.SetTop(info.Ellipse, top + 1 * info.VelocityY);

                    if(Top >= (canvas.ActualHeight-ellipseRadius*2))
                    {
                        ellipses.Remove(info);
                    }
                    else
                    {
                        info.VelocityY += accelerationY;
                    }
                }

                if(ellipses.Count==0)
                {
                    CompositionTarget.Rendering -= CompositionTarget_Rendering;
                    rendering = false;
                }

            }
        }

        private void EndButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
