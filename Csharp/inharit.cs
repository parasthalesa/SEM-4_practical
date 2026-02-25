using System;
class demo{
	static void Main(){
		xyz obj1=new xyz();
		abc obj2=new abc();
		obj1.disp();
		obj2.show();
		obj2.disp();
	}
}
public class xyz{
	public void disp(){
		Console.WriteLine("disp");
	}
}
public class abc : xyz{
	public void show(){
		Console.WriteLine("show");
	}
}