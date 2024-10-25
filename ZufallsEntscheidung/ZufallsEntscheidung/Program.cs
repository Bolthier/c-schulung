// See https://aka.ms/new-console-template for more information
using ZufallsEntscheidung;

Console.WriteLine("Du musst dich nicht entscheiden!");
Console.Write("Titel: ");
FreieOptionen freieOptionen = new FreieOptionen();
freieOptionen.Titel = Console.ReadLine();
Console.Write("Anzahl der Optionen: ");
freieOptionen.AnzahlOptionen = int.Parse(Console.ReadLine());
freieOptionen.Optionens = new string[freieOptionen.AnzahlOptionen];
for (int i = 0;i < freieOptionen.Optionens.Length;i++)
{
    Console.Write($"Option {i+1}: ");
    freieOptionen.Optionens[i] = Console.ReadLine();
}
Console.WriteLine($"Ihr Ergebnis: { freieOptionen.Entscheidung()}");