
using SSP_3000_R3_BLACK;

Console.WriteLine("S S S!");

var s = new TheGame();

do
{
    Console.Write("Schere - 1 oder Stein - 2 oder Papier - 3 : ");
    var eingabeSpieler = int.Parse(Console.ReadLine());
    var eingabeRechner = s.WahlRechner();
    Console.WriteLine($"Der Rechner nimmt: {eingabeRechner}");
    s.ErgebnisErmitteln(eingabeRechner, eingabeSpieler);
    Console.WriteLine($"Rechner: {s.PunkteRechner} / Spieler: {s.PunkteSpieler}");

} while (!s.IstEnde);

if (s.PunkteSpieler>s.PunkteRechner)
{
    Console.WriteLine("Du hast gewonnen!!!");
}
else
{
    Console.WriteLine("Du hast verloren!!!");
}
