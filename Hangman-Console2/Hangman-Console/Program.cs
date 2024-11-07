// See https://aka.ms/new-console-template for more information
using Hangman_Console.Business;

Console.WriteLine("H A N G M A N!");

var spiel = new Hangman();
do
{
    Console.WriteLine(spiel.TheView);
    Console.Write($"Ihre Eingabe ({spiel.ErrorCount} Fehler): ");
    spiel.Input(Console.ReadLine());
}
while (!spiel.IsWon && !spiel.IsDead);

if (spiel.IsWon)
{
    Console.WriteLine("Glückwünsche!");
}
else
{
    Console.WriteLine("Du bist tot, Digger");
}
Console.WriteLine(spiel.SecretWord);