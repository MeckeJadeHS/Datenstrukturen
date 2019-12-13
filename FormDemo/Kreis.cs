using System;
using System.Windows.Media;

namespace FormDemo
{

    public class Kreis : Form
    {

        private double x, y;
        private double radius;
        protected Brush farbe = Brushes.White;

        public Kreis()
        {
            radius = 0;
            x = 0;
            y = 0;
        }
        public Kreis(double a)
        {
            radius = a;
            x = 0;
            y = 0;
        }

        public void setMittelpunkt(
            double l_x, double l_y)
        {
            x = l_x;
            y = l_y;
        }

        public void setRadius(double r)
        {
            radius = r;
        }

        override public double getFlaeche()
        {
            return ((Math.Pow(radius, 2)) * Math.PI);
        }

    }


}