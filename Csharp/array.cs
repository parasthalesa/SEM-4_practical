using System;
class demo{
	static void Main(){
		int n;
		Console.WriteLine("enter your array length");
		n=Convert.ToInt64(Console.ReadLine());
		int[] a={4,5,7,3,4};
		for(int i=0;i<a.Length;i++){
			Console.WriteLine(a[i]);
		}
		Console.ReadLine();
	}
}