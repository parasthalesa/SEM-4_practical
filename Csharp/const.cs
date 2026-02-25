using System;
class taskconst
{
    static void Main()
    {
        demo d=new demo();
        d.a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("demo object="+d.a);   
    }
}
public class demo
{
    public int a;
}