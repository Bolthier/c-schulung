// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zahlenraten (1 ... 100!");

int zufallszahl = new Random().Next(1,101);
int anzahlVersuche = 0;
while (true)
{
    anzahlVersuche++;
    Console.Write($"{anzahlVersuche}. Versuch: ");
    int eingabe = int.Parse(Console.ReadLine()!);
    if (zufallszahl == eingabe)
    {
        break; //beendet while Schleife
    }
    else if (zufallszahl < eingabe)
    {
        Console.WriteLine("Die gesuchte Zahl ist kleiner");
    }
    else
    {
        Console.WriteLine("Die gesuchte Zahl ist größer");
    }
} // ENDE von WHILE
Console.WriteLine($"Herzlichen Glückwunsch. Sie haben {anzahlVersuche}. Versuche gebraucht um die Zahl {zufallszahl} zu erraten!");