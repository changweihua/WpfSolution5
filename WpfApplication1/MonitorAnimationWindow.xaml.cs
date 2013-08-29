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
using System.Windows.Media.Animation;

namespace WpfApplication1
{
    /// <summary>
    /// MonitorAnimationWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MonitorAnimationWindow : Window
    {
        public MonitorAnimationWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 动画时钟向前移动
        /// </summary>
        /// <param name="sender">Clock 对象</param>
        /// <param name="e"></param>
        private void fadeStoryboard_CurrentTimeInvalidated(object sender, EventArgs e)
        {
            Clock clock = (Clock)sender;
            if(clock.CurrentProgress==null)
            {
                tbTime.Text = "[[ Stoped !]]";
                pbTime.Value = 0;
                timeSlider.Value = 0;
            }
            else
            {
                tbTime.Text = clock.CurrentTime.ToString();
                pbTime.Value = (double)clock.CurrentProgress;
                timeSlider.Value = (double)clock.CurrentProgress;
            }
        }
    }
}
