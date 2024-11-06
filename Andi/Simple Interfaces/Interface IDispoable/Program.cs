Console.WriteLine("Hello, World!");

using (var a = new A())
{

} //Ende

using (var file=new StreamReader(@"t:\installs\deutsch.txt"))
{
    string zeile = null;
    while ((zeile = file.ReadLine())!=null)
    {
        Console.WriteLine(zeile);
    }
}




class A : IDisposable
{
    public A()
    {
        Console.WriteLine("Ein A wird geboren");
    }

    public void Dispose()
    {
        Console.WriteLine("Ein A stibt...");
    }
}
