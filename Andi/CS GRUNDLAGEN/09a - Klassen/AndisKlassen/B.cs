using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09a___Klassen.AndisKlassen
{
    public class B //: Object
    {
        public B() : this("Unbekannt"){ //Defaultkonstruktor (keine Parameter!)
            Console.WriteLine("Ein B wird geboren...");
        }

        public B(string name)
        {
            Name = name;
        }

        ~B() //Destruktor
        {
            Console.WriteLine("Ein B stirbt...");
        }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
