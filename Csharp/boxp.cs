using System;
class boxp{
	static void Main(){
		int a=20;
		object n=a;
		Console.WriteLine("boxing");
		Console.WriteLine(a);
		Console.WriteLine(n);
		Console.WriteLine("unboxing");
		n=30;
		a=(int)n;
		Console.WriteLine(a);
		Console.WriteLine(n);
		Console.ReadLine();
	}
}