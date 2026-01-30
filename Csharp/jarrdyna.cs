using System;
class demo{
	static void Main(){
		// creat and assign row size
		int [][]array=new int[4][];
		
		// assign colum size
		array[0]=new int[4];
		array[1]=new int[2];
		array[2]=new int[1];
		array[3]=new int[3];
		
		//assign array element
		array[0][0]=10;
		array[0][1]=11;
		array[0][2]=12;
		array[0][3]=15;
		array[1][0]=23;
		array[1][1]=13;
		array[2][0]=16;
		array[3][0]=17;
		array[3][1]=18;
		array[3][2]=19;
		
		// print all element in table formate
		Console.WriteLine("your element is table formate:");
		for(int i=0;i<array.Length;i++){
			for(int j=0;j<array[i].Length;j++){
				Console.Write(array[i][j]+" ");
			}
			Console.WriteLine();
		}
		Console.ReadLine();
	}
}