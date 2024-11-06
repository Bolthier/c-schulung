using _09a___Klassen.AndisKlassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09a___Klassen
{
    public class A : B
    {
        public A() {
            Console.WriteLine("Ein A wird geboren...");
        }
    }

    public class C : A
    {
        public C()
        {
            Console.WriteLine("Ein C wird geboren...");
        }
    }
}
