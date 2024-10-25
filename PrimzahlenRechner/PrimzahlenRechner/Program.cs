// See https://aka.ms/new-console-template for more information

using System.Security;

int ersteZahl;
int letzteZahl;

Console.WriteLine("Primzahlen Ausgabe!");
Console.Write("Erste Zahl: ");
ersteZahl = int.Parse(Console.ReadLine());
Console.Write("Zweite Zahl: ");
letzteZahl = int.Parse(Console.ReadLine());

for (int i = ersteZahl; i <= letzteZahl; i++)
{
    if (IstPrim(i))
    {
        Console.WriteLine(i);
    }
}

bool IstPrim(int i)
{
    if (i < 2) {
        return false; //beendet Fkt ---> nein
    }
    for (int teiler = 2; teiler < i; teiler++)
    {
        if (i % teiler == 0)
        return false;
    }
    return true;
}