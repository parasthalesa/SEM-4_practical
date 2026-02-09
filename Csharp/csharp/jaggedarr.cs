using System;
class demo{
	static void Main(){
		
		//get rowas size frome user
		Console.Write("enter your array row size=");
		int length=Convert.ToInt32(Console.ReadLine());
		int [][]jarr=new int[length][];
		
		//get colum size frome user
		Console.WriteLine("enter your column size:");
		int col;
		for(int i=0;i<jarr.Length;i++){
			col=Convert.ToInt32(Console.ReadLine());
			jarr[i]=new int[col];
		}
		
		//display total row size
		Console.WriteLine("this istotal lengtho of array="+jarr.Length);
		
		//int element;
		for(int i=0;i<jarr.Length;i++){
			for(int j=0;j<jarr[i].Length;j++){
				Console.Write("enter your element");
				jarr[i][j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		//print all element
		for(int i=0;i<jarr.Length;i++){
			for(int j=0;j<jarr[i].Length;j++){
				Console.Write(jarr[i][j]+" ");
			}
			Console.WriteLine();
		}
		Console.ReadLine();
	}
}