Console.WriteLine("Hello, World!");

int i = 666;
Console.WriteLine(i);
macheHalb(i);
Console.WriteLine(i);
A a=new A();
Console.WriteLine(a.i);
macheHalb2(a);
Console.WriteLine(a.i);


void macheHalb(int x)
{
    x = x / 2;
}
void macheHalb2(A x)
{
    x.i = x.i / 2;
}

class A
{
    public int i=666;
}

