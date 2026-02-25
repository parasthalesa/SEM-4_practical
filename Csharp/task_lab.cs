using System;
class demo{
	static void Main(){
		
		child cho=new child();
		
		cho.jarr[0]=new int[5];
		cho.jarr[1]=new int[1];
		cho.jarr[2]=new int[3];
		cho.jarr[3]=new int[1];
		cho.jarr[4]=new int[5];
		
		cho.print();
		
	Console.ReadLine();
	}
}
public class parant{
	public int lengt=5;
	public int col;
	public int [][]jarr=new int[5][];
	
}
public class child:parant{
	
	public void print(){
		for(int i=0;i<lengt;i++){
				for(int j=0;j<jarr[i].Length;j++){
					//Console.Write(jarr[i][j]+" ");
					Console.Write("1 ");
				}
			Console.WriteLine();
		}
	}
	
}