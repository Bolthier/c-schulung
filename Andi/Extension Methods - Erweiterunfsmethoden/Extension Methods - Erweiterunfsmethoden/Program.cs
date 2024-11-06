
// See https://aka.ms/new-console-template for more information
using Fabius;

Console.WriteLine("Extension - Method");

string s = "333";

var r=new StreamReader(s);
r.WerBistDu();


Console.WriteLine(s.ToZahl()*2);

namespace Fabius
{
    static class MyExtensions
    {
        /// <summary>
        /// Wandelt Zahl 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int ToZahl(this string s)
        {
            int i = 0;
            int.TryParse(s, out i);
            return i;
        }
        public static void WerBistDu(this object o)
        {
            Console.WriteLine("Ich bin der Klaus..");
        }
    }
}
