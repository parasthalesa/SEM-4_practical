using System;
class demo{
	static void Main(){
		xyz ch=new xyz();
		abc pr=new abc();
		ch.a=20;
		ch.disp();
		pr.a=30;
		pr.disp();
	}
}
public class abc{
	public int a;
	public void disp(){
		Console.WriteLine("hello"+a);
	}
}
public class xyz:abc{

}