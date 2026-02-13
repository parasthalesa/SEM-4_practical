using System;
class Smethod{
	static public void func(){
		Console.WriteLine("function is calling");
	}
	static void Main(){
		func();
		Console.WriteLine("main function is calling");
		Console.ReadLine();
	}
}