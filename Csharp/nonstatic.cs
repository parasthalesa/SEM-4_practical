using System;
class demo{
	void fun(){
		Console.WriteLine("non static fun");
	}
	static void Main(){
		demo obj=new demo();
		obj.fun();
		Console.ReadLine();
	}
}