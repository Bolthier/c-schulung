using Hangman_Console.Business;

Console.WriteLine("H A N G M A N");

var spiel = new Hangman();

do
{
    Console.WriteLine(spiel.TheView);
    Console.Write($"Eingabe ({spiel.ErrorCount} Fehler): ");
    spiel.Input(Console.ReadLine());
}
while (!spiel.IsWon && !spiel.IsDead);

if (spiel.IsWon)
{
    Console.WriteLine("GLÜCKWINSCH");
}
else
{
    Console.WriteLine("Du bist Tot, Digga");
}
Console.WriteLine(spiel.SecretWord);
