using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FormDemo
{
    public abstract class Form
    {
        protected Brush farbe = Brushes.White;

        public void setFarbe(Brush lokaleFarbe )
        {
            farbe = lokaleFarbe;
        }

        internal string getFarbe()
        {
            return farbe.ToString();
        }

        abstract public double getFlaeche();

    }
}
