using System;

namespace FormDemo
{
    public class Quadrat : Form
    {
        private double x, y;
        private double seitenlaenge;

        public Quadrat()
        {
            seitenlaenge = 0;
            x = 0;
            y = 0;
        }

        public Quadrat(double a)
        {
            seitenlaenge = a;
            x = 0;
            y = 0;
        }

        public void setMittelpunkt(double l_x, double l_y)
        {
            x = l_x;
            y = l_y;
        }

        public void setSeitenlaenge(double s)
        {
            seitenlaenge = s;
        }
        
        override public double getFlaeche()
        {
            return Math.Pow(seitenlaenge, 2);
        }
    }
}
