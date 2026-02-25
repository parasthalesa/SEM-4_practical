using System;
class demo{
	static void Main(){
		
		child cho=new child();
		cho.jarr=new int[cho.lengt][];

		cho.jarr[0]=new int[5];
		cho.jarr[1]=new int[1];
		cho.jarr[2]=new int[3];
		cho.jarr[3]=new int[1];
		cho.jarr[4]=new int[5];
		
		int num = 1;

		for (int i = 0; i < cho.lengt; i++)
		{
			for (int j = 0; j < cho.jarr[i].Length; j++)
			{
				if (i == 3)   // 4th row
				{
				cho.jarr[i][j] = 0;
			}
			else if (i == 4)  // last row restart from 1
			{
				cho.jarr[i][j] = j + 1;
			}
			else
			{
				cho.jarr[i][j] = num;
				num++;
			}
    }
}
	
		cho.print();
	Console.ReadLine();
	}
}
public class parant{
	public int lengt=5;
	public int [][]jarr=new int[5][];
}
public class child:parant{
	
	
	public void print(){
		
		for(int i=0;i<lengt;i++)
        {
            for (int j=0;j<jarr[i].Length;j++)
            {
                Console.Write(jarr[i][j]);
            }
            Console.WriteLine();
        }
	}
}
