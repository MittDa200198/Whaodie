using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220915_Klassenhierachie
{
    class Lebewesen
    {
        private string lebensraum;
        private int lebenserwartung;
        private double koerpergroesse;
        private double gewicht;
        private bool komunikation;
        private double koerpertemperatur;

        public void Fortbewegung()
        {
            string fortbewegung;

            Console.WriteLine("Wie bewegt sich das Lebewesen Fort");
            fortbewegung = Console.ReadLine();
            Console.WriteLine("Es bewegt sich auf: " + fortbewegung + " fort");
            Console.WriteLine();
        }

        public void Fortpflanzung()
        {
            string fortpflanzung;

            Console.WriteLine("Wie Pflanzt sich das Lebewesen Fort:");
            fortpflanzung = Console.ReadLine();
            Console.WriteLine("Es Pflanzt sich durch" + fortpflanzung + "fort");
            Console.WriteLine();
        }

        public void Kommunizieren()
        {
            string komunizieren;

            Console.WriteLine("Wie Komuniziert das Lebewesen:");
            komunizieren = Console.ReadLine();
            Console.WriteLine("Es komuniziert durch" + komunizieren);
            Console.WriteLine();
        }

        public void Fühlen()
        {
            string fühlen;

            Console.WriteLine("Durch welche form Fühlt das Lebewesen:");
            fühlen = Console.ReadLine();
            Console.WriteLine("Es fühlt durch" + fühlen);
            Console.WriteLine();
        }

        public void Paarung()
        {
            string fortbewegung;

            Console.WriteLine("Wie Paart sich das Lebewesen:");
            fortbewegung = Console.ReadLine();
            Console.WriteLine("Es Paart sich duch: " + fortbewegung);
            Console.WriteLine();
        }
    }

    //Sauegetiere --- beginn

    class Saeugetiere : Lebewesen
    {
        private double schwangerschaftsdauer;

        public void Gebaeren()
        {
            Console.WriteLine("Das Sauegetier Gebaert jetzt"); Console.WriteLine();
        }
    }

    class Nahrung : Saeugetiere
    {
        private bool pflanzen;
        private bool fleisch;

        public void beschaffung()
        {
            Console.WriteLine("Das Sauegetier besort sich jetzt Nahrung"); Console.WriteLine();
        }
    }

    //Sauegetiere --- ende

    class Reptilien : Lebewesen
    {
       public void häuten()
        {
            Console.WriteLine("Das Reptiel hauetet sich");
        }

        // nichts bekannt das man nicht auch in die Mainclass schreiben könnte
    }

    class Insecten : Lebewesen
    {
        // nichts bekannt das man nicht auch in die Mainclass schreiben könnte
    }
}
