using System;
class userarray{
	static void Main(){
		int n;
		Console.Write("enter your array length");
		n=Convert.ToInt32(Console.ReadLine());
		int[] arr=new int[n];
		//get element from user
		Console.WriteLine("enter your array value/emenemt");
		for(int i=0;i<n;i++){
			
			arr[i]=Convert.ToInt32(Console.ReadLine());
		}
		//element printing
		Console.WriteLine("your element is");
		for(int i=0;i<arr.Length;i++){
			
			Console.WriteLine(arr[i]);
		}
		// print sum of element
		for(int i=0;i<arr.Length;i++){
			total=arr[i]+arr.Length-1;
			if(i<arr.length-1)
				Console.WriteLine("total sum of element="+total);

		}

	}
	

}

