// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Extension - Method!");

string s = "333";

Console.WriteLine( s.ToZahl()*2);
public static class MyExtensions
{
    public static int ToZahl(this string s)
    {
        int i = 0;
        int.TryParse(s, out i);
        return i;
    }
    public static void WerBistDu(this object o)
    {
        ;
    }
}

