// See https://aka.ms/new-console-template for more information
using De.Wortmann.Chat.Db;
using System.Text.Json;

Console.WriteLine("CHAT CONSOLE");

var h = new MsgHelper();

foreach (var m in h.AlleMessages)
{
    Console.WriteLine($"{m.Content} ({m.DateCreate})");
}

Console.WriteLine(JsonSerializer.Serialize(h.AlleMessages));