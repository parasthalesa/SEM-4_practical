using System;
class demo{
	static void Main(){
		Console.Write("enter array length");
		int n=Convert.ToInt32(Console.ReadLine());
		int[] arr=new int[n];
		Console.WriteLine("enter your element");
	for(int i=0;i<n;i++){
		arr[i]=Convert.ToInt32(Console.ReadLine());
	}
	int total=sum(arr,n);
	Console.WriteLine("total sum="+total);
	}
	static int sum(int[] arr,int n){
		int stor=0;
		if(n<=1){
				return n;
			}
		else{
			for(int i=0;i<n;i++){
				stor=arr[i]+stor;
				//stor=stor+stor;
			}
			return stor;
		}
	}
}