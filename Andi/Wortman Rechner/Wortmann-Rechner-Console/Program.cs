// See https://aka.ms/new-console-template for more information
using De.Wortmann.Andi.Rechner;
using De.Wortmann.Ben.Rechner;
using De.Wortmann.Interfaces;

Console.WriteLine("Rechner");

IRechner r = new De.Wortmann.Andi.Rechner.MeinRechner();
r = new De.Wortmann.Ben.Rechner.MeinRechner();

Console.WriteLine(r.Plus(1).Plus(1).Plus(1).Plus(1).Plus(1).Plus(1).Plus(1).Plus(1).Summe);
