// See https://aka.ms/new-console-template for more information
using STP;
using System.ComponentModel.Design;

Console.WriteLine("Schere, Stein, Papier!");

var s = new SchereSteinPapier();

do {

    Console.Write("Schere - 1 oder Stein - 2 oder Papier - 3: ");
    var eingabeSpieler = int.Parse(Console.ReadLine());
    var eingabeRechner = s.WahlRechner();
    Console.WriteLine($"Der Rechner nimmt: {eingabeRechner}");
    s.ErgebnisErmitteln(eingabeRechner, eingabeSpieler);
    Console.WriteLine($"Rechner: {s.PointsRobot} / Spieler: {s.PointsHuman}");
} while (!s.IstEnde);
if (s.PointsHuman > s.PointsRobot)
{
    Console.WriteLine("Du hast gewonnen!");
}
else
{
    Console.WriteLine("Du hast verloren!");
    Console.WriteLine("Du hast verloren!");
}