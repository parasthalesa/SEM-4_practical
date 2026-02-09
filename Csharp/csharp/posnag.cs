using System;
class dcemo{
	static void Main(){
		Console.Write("enter your numbr=");
		int val=Convert.ToInt32(Console.ReadLine());
		if(val>=0){
			if(val==0){
				Console.WriteLine("number is zero");
			}
			else{
				Console.WriteLine("tour number is positive");
			}
		}else{
			Console.WriteLine("number is nagative");
		}
	}
}