internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Funktionen!");

        Console.WriteLine(Plus(555, 111));
        Console.WriteLine(Plus(555.55, 111.11));
        Plus(444);  //666

    }

    static int Plus(int a, int b=222)  //Default
    {
        return a + b;
    }
    //überladene Fkt.
    static double Plus(double a, double b)
    {
        return a + b;
    }

}