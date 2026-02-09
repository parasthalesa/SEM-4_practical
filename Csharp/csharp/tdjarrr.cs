using System;
class demo{
	static void Main(){
	int [][][]arr=new int[2][][];
	//column size
	arr[0]=new int[2][];
	arr[1]=new int[3][];
	
	//row size
	// first index
	arr[0][0]=new int[3];
	arr[0][1]=new int[1];
	//second index
	arr[1][0]=new int[2];
	arr[1][1]=new int[1];
	arr[1][2]=new int[3];
	
	//dimantion size
	Console.WriteLine(arr.Length);
	Console.WriteLine(arr.GetLength(0));
	
	//row size
	Console.WriteLine(arr[0].Length);
	Console.WriteLine(arr[1].Length);
	
	//column size
	Console.WriteLine(arr[0][0].Length);
	Console.WriteLine(arr[0][1].Length);
	
	Console.WriteLine(arr[1][0].Length);
	Console.WriteLine(arr[1][1].Length);
	Console.WriteLine(arr[1][2].Length);
	}
}