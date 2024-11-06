using IchKannMichNichtEntscheiden_Console;

Console.WriteLine("Entscheidungs-Hilfe!");
Console.Write("Titel: ");
var h = new Helper() { Titel = Console.ReadLine() };
int anz = LeseZahl("Anzahl der Optionen: ");

int LeseZahl(string v)
{
    Console.Write(v);
    try
    {
        return int.Parse(Console.ReadLine());
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
        return LeseZahl(v);
    }
}

for (int i = 0; i < anz; i++)
{
    Console.Write($"{i+1}. Option: ");
    try
    {
        h.AddOption(Console.ReadLine());
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
        i--;
    }
}

Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"DU MACHST: {h.Options[h.Entscheide()]}");
Console.ResetColor();

