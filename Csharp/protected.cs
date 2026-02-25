using System;
class demo{
	static void Main(){
		xyz obj1=new xyz();
		obj1.show();
		obj1.show();
	}
}
public class abc{
	protected void disp(){
		Console.WriteLine("display");
	}
}
public class xyz:abc{
	public void show(){
		Console.WriteLine("this is show");
		disp();
	}
}