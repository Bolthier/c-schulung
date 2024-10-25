// See https://aka.ms/new-console-template for more information
using Patchwork_Decke;

Console.WriteLine("Ich geh an die Decke!");

var decke = new List<IFigur>();

decke.Add(new Quadrat(4));
decke.Add(new Kreis(2));
decke.Add(new Dreieck() { Breite = 4, Hoehe = 2 });

double summe = 0;
foreach (var figur in decke)
{
    summe += figur.GetFlächeninhalt();
}
Console.WriteLine($"Flächeninhalt (A) der Decke: {summe:0.000}");