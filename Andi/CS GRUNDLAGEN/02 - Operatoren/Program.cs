
Console.WriteLine("Operatoren!");

// + - / * % =


Console.WriteLine(33+11);
int i = 0;
i = 12 * 4;

Console.WriteLine(i);

//++ -- += -= *=
i++;
i *= 5;  // i=i*5;

Console.WriteLine(i);

//logisch
//> < <= >= == != !  && || & |
Console.WriteLine(33>44);
i = 55;
var x=33 > i++ & 44 < i++;

Console.WriteLine(i);
Console.WriteLine(5<<2);

Console.WriteLine(DateTime.Now.Hour>13?"Guten Tag":"Guten Morgen");

int? w = null;
Console.WriteLine(w.HasValue ? w : 11 * 2);
Console.WriteLine(w ?? 11 * 2);

Console.WriteLine(sizeof(int));




