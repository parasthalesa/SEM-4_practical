using System;
class demo{
	static void Main(){
		Console.Write("enter your array row:=");
		int r=Convert.ToInt32(Console.ReadLine());
		Console.Write("enter your array col:=");
		int c=Convert.ToInt32(Console.ReadLine());
		int [,]arr=new int[r,c];
		Console.WriteLine("enter your element:");
		for(int i=0;i<arr.GetLength(0);i++){
			for(int j=0;j<arr.GetLength(1);j++){
				arr[i,j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		Console.WriteLine("your total element length:="+arr.Length);	
		int total=sum(arr,r,c);
		Console.Write("your element sum is:="+total);
		Console.ReadLine();
	}
	static int sum(int [,]a,int r,int c){
		int total=0;
		if(r==0||c==0){
			return 0;
		}else{
			for(int i=0;i<a.GetLength(0);i++){
				for(int j=0;j<a.GetLength(1);j++){
					total=a[i,j]+total;
				}
			}
			return total;
		}
	}
}