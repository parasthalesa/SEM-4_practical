using System;
class  linkfun
{
    static void Main()
    {
        xyz obj1=new xyz();
        obj1.show();
		obj1.disp();
    }
}
public class abc{
	public void disp(){
		Console.WriteLine("display");
	}
}
class xyz : abc
{
    public void show()
    {
        Console.WriteLine("hello");
        hello();
		disp();
    }
    public void hello()
    {
        Console.WriteLine("hello");
    }
}