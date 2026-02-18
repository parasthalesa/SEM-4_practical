using System;
class vote{
	static void Main(String[] args){
		Console.Write("enter Your birth year: ");
		int year=Convert.ToInt32(Console.ReadLine());
		Console.Write("enrter cutent year: ");
		int currentyear=Convert.ToInt32(Console.ReadLine());
		int final=currentyear-year;
		if(final>18){
			Console.WriteLine("you are able to voting");
		}else{
			Console.WriteLine("you are not able to voting");
		}
	}
}