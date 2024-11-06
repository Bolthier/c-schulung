
Console.WriteLine("Zahlenraten (1..100)!");

int zufallszahl=new Random().Next(1,101);
int anzahlVersuche = 0;
int eingabe;
do
{
    anzahlVersuche++;
    Console.Write($"{anzahlVersuche}. Versuch: ");
    eingabe = int.Parse( Console.ReadLine()!);
    if(zufallszahl<eingabe)
    {
        Console.WriteLine("Die gesuchte Zahl ist kleiner");
    }
    else
    {
        Console.WriteLine("Die gesuchte Zahl ist größer");
    }
} //ENDE von WHILE
while(zufallszahl != eingabe);
Console.WriteLine($"HERZL. GLÜCKWUNSCH ({anzahlVersuche} Versuche)");