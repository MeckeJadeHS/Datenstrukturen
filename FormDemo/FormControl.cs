using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FormDemo
{

    public class FormControl
    {
        FormControl()
        {
            Kreis k1 = new Kreis();
            k1.setMittelpunkt(20, 30);
            k1.setRadius(20);
            k1.setFarbe(Brushes.Red);

            Quadrat q1 = new Quadrat();
            q1.setMittelpunkt(100, 200);
            q1.setSeitenlaenge(40);
            q1.setFarbe(Brushes.Blue);

            Console.WriteLine("k1: " + k1.getFlaeche() + " - " + k1.getFarbe() );
            Console.WriteLine("q1: " + q1.getFlaeche() + " - " + q1.getFarbe() );
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            new FormControl();
        }
    }

}
