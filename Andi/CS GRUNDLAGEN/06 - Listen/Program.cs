using Andi.Klassen.A;
using System.Text.Json;

Console.WriteLine("Listen!");

List<int> liste = new List<int>();

liste.Add(22);
liste.Add(33);
liste.Add(88);

int summe = 0;
foreach (var item in liste)
{
    summe += item;
}
Console.WriteLine(summe / liste.Count);
JsonSerializerOptions s;

