using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220915_Klassenhierachie
{
    class Program
    {
        static void Main(string[] args)
        {
            Lebewesen lebewesen = new Lebewesen();
            lebewesen.Fortbewegung();

            Saeugetiere saeugetiere = new Saeugetiere();
            saeugetiere.Fortbewegung();
            saeugetiere.Gebaeren();

            Nahrung nahrung = new Nahrung();
            nahrung.beschaffung();


            Console.ReadLine();
        }
    }
}
