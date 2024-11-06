// See https://aka.ms/new-console-template for more information
using PachWorkDecke;

Console.WriteLine("DECKE!");


var decke = new List<IFigur>();

decke.Add(new Quadrad(4)); 
decke.Add(new Kreis(2));
decke.Add(new Dreieck() { Breite=4, Hoehe=4});



double summe = 0;
foreach (var figur in decke)
{
    summe += figur.GetFlaecheninhalt();
}
Console.WriteLine($"Flächeninhalt (A) der Decke: {summe:0.000} cm²");
