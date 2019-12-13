using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormDemo;

namespace ReferenzDatentypen
{
    class DatenTypenDemo
    {
		DatenTypenDemo()
		{
			// Variablen initialisieren
			int zahl = 1;
			int[] zahlArray = new int[] { 1 };

			// Addiere 10 
			addiere10zuInt(zahl);
			addiere10zuIntArray(zahlArray);

			Console.WriteLine(zahl);
			Console.WriteLine(zahlArray[0]);
			Console.ReadKey();

            VL11();
            VL11_getGesamtflaeche();
            Console.ReadKey();
        }


        private static void addiere10zuIntArray(int[] zahlArray)
        {
                zahlArray[0] += 10; 
        }

        private static void addiere10zuInt(int zahl)
        {
            zahl += 10;
        }


        #region VL11
        public void VL11()
        {

            /// Array mit for
            int[] intArray;
            intArray = new int[5];

            intArray[0] = 7;
            intArray[1] = 3;
            intArray[2] = 1;

            // Alles in einer Zeile
            int[] intArray2 = new int[] { 7, 3, 1, 2, 6 };

            foreach (int kk in intArray)
            {
                Console.WriteLine("Array: " + kk);
            }

            for (int ii = 0; ii < intArray.Length; ii++)
            {
                Console.WriteLine("Array: " + intArray[ii]);
            }
            // Ausgabe :
            // Array: 7
            // Array: 3
            // Array: 1
            // Array: 0
            // Array: 0

            /// System.Collections.Generic.List 
            List<int> intListe = new List<int>();
            intListe.Add(7);
            intListe.Add(3);
            intListe.Add(1);

            List<int> intListe2 = new List<int>() { 7, 3, 1 };

            foreach (int zahl in intListe)
            {
                Console.WriteLine("Liste: " + zahl);
            }
            // Ausgabe :
            // Liste: 7
            // Liste: 3
            // Liste: 1

            /// System.Collections.Queue
            Queue q = new Queue();
            q.Enqueue("A");
            q.Enqueue("B");
            q.Enqueue("C");

            Console.WriteLine("Queue: " + q.Dequeue());
            Console.WriteLine("Queue: " + q.Dequeue());
            // Ausgabe :
            // Queue: A
            // Queue: B

            /// System.Collections.Stack
            Stack s = new Stack();
            s.Push("A");
            s.Push("B");
            s.Push("C");

            Console.WriteLine("Stack: " + s.Pop());
            Console.WriteLine("Stack: " + s.Pop());
            // Ausgabe :
            // Stack: C
            // Stack: B

            /// System.Collections.Generic.SortedDictionary
            SortedDictionary<String, String> sortDict =
                new SortedDictionary<String, String>();
            sortDict.Add("A", "Albert Albatros");
            sortDict.Add("B", "Berta Bison");
            sortDict.Add("PLM", "Product Lifecycle Management");
            sortDict.Add("TLA", "Three Letter Acronym");
            sortDict.Add("C", "Carl Chamäleon");
            if (!sortDict.ContainsKey("B"))
            {
                sortDict.Add("B", "oiuhihsdf");
            }

            foreach (KeyValuePair<String, String> kvp in sortDict)
            {
                Console.WriteLine("SortedDict: " + kvp.Key + " - " + kvp.Value);
            }
            // Ausgabe :
            // SortedDict: A - Albert Albatros
            // SortedDict: B - Berta Bison
            // SortedDict: C - Carl Chamäleon
            // SortedDict: PLM - Product Lifecycle Management
            // SortedDict: TLA - Three Letter Acronym

            // Suche
            String sucheStr = "PLM";
            Console.WriteLine("Suche im SortedDict: " + sucheStr + " - " + sortDict[sucheStr]);

            // Suche Besser
            sucheStr = "C";
            if (sortDict.ContainsKey(sucheStr))
            {
                Console.WriteLine("Suche im SortedDict: " + sucheStr + " - " + sortDict[sucheStr]);
            }

            // Suche Besser Schneller
            String result;
            if (sortDict.TryGetValue("TLA", out result))
            {
                Console.WriteLine("Suche im SortedDict: " + result);
            }
            // Ausgabe :
            // Suche im SortedDict: PLM - Product Lifecycle Management
            // Suche im SortedDict: C - Carl Chamäleon
            // Suche im SortedDict: Three Letter Acronym

            List<String> collection = new List<string>();

            foreach (var item in collection)
            {
                // Anweisung für einzelne items
            }

        }

        public  double VL11_getGesamtflaeche()
        {
            double gesamtsumme = 0;     // Rückgabewert Gesamtfläche
            double a = 10;              // Seitenlaenge oder Radius...

            // Eine Liste von Formen - egal ob Kreis oder Quadrat
            List<Form> meineFormen = new List<Form>();
            meineFormen.Add(new Quadrat(a));
            meineFormen.Add(new Kreis(a));

            // Summe der einzelnen (unterschiedlichen) Flächenberechnungen 
            foreach (Form einzelneForm in meineFormen)
            {
                gesamtsumme += einzelneForm.getFlaeche();
            }

            return gesamtsumme; // Rückgabe
        }

        #endregion


        static void Main(string[] args)
		{
			DatenTypenDemo demo = new DatenTypenDemo();
		}


	}
}
