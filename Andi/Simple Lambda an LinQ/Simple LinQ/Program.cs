// See https://aka.ms/new-console-template for more information
Console.WriteLine("LinQ - Language integrated Query!");

var alle = File.ReadAllLines(@"t:\installs\deutsch.txt");

//foreach (var w in alle.Where(DuBistDabei))
//foreach (var w in alle.Where(x=>x.StartsWith("x")).OrderByDescending(x=>x.Length))
//{
//        Console.WriteLine(w);
//}

//bool DuBistDabei(string x)
//{
//    return x.StartsWith("x");
//}

Console.WriteLine($"MW aller Wörter: {alle.Select(x => x.Length).Sum() / alle.Length}");

foreach (var z in alle
                    //.AsParallel()
                    .Select(x => x[0])
                    .GroupBy(x=>x)
                    .Select(x=>new {bs=x.Key, anz=x.Count() })
                    .OrderByDescending(x=>x.anz)
                    .Take(10)
                )
{
    Console.WriteLine($"{z.bs}: {z.anz}");
}

//var liste= from x in alle
//           where 
//           select x[0] as y
           
           
           


//Parallel.ForEach(alle
//                    //.AsParallel()
//                    .Select(x => x[0])
//                    .GroupBy(x => x)
//                    .Select(x => new { bs = x.Key, anz = x.Count() })
//                    .OrderByDescending(x => x.anz)
//                    .Take(10), x => Console.WriteLine(x));