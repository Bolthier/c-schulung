// See https://aka.ms/new-console-template for more information
using System.Transactions;

Console.WriteLine("Hello, World!");


Action funktion;

funktion = huhu;  //benannten Funktion
funktion();

funktion = () => Console.WriteLine("HALLLLOOOOOOO...."); // annonym
funktion();

Action<int> functWith1Par=x1;
functWith1Par(333);
Action<int, double, string> fw3p;
fw3p = (i, d, s) => Console.WriteLine($"{s}: {d*i} --> {d} --> {i}");
fw3p(10, 2.0, "10 mal 2=");

Func<int, int, double> fwp;
fwp = plus;

double plus(int a, int b)
{
    return a + b;
}

void x1(int i)
{
    Console.WriteLine(i*2);
}

void huhu()
{
    Console.WriteLine("huhu");
}

//delegate void FunktionsTyp();
