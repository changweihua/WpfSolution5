using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public class EllipseInfo
    {
        public Ellipse Ellipse { get; set; }

        public double VelocityY { get; set; }

        public EllipseInfo()
        {

        }

        public EllipseInfo(Ellipse ellipse, double velocityY)
        {
            Ellipse = ellipse;
            VelocityY = velocityY;
        }

    }
}
