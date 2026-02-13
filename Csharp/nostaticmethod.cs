using System;
class nostaticm{
	public void func(){
		Console.WriteLine("function is calling");
	}
	static void Main(){
		nostaticm obj=new nostaticm();
		obj.func();
		Console.WriteLine("Main function");
	}
}