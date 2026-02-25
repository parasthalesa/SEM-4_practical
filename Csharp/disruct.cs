using System;
class distr
{
    static void Main()
    {
        xyz obj1=new xyz();
        xyz obj2=new xyz();
        Console.ReadLine();
        Console.WriteLine("main");
    }
}
public class xyz
{
    public xyz()
    {
        Console.WriteLine("hello normal");
    }
    ~xyz()
    {
        Console.WriteLine("hii");
    }
} 