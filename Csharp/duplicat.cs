using System;
class duplicat
{
    static void Main()
    {
        Console.Write("Enter row size: ");
        int r=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter column size: ");
        int c=Convert.ToInt32(Console.ReadLine());

        int[,] arr=new int[r,c];

        Console.WriteLine("Enter total "+arr.Length+" elements");

        for(int i=0;i<r;i++)
        {
            for(int j=0;j<c;j++)
            {
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Duplicate Elements and their count:");
		int count=0;
        for (int i=0;i<r;i++)
        {
            for (int j=0;j<c;j++)
            { 
				count=0;
                bool Counted=false;
                for(int x=0;x<i;x++)
                {
                    for(int y=0;y<c;y++)
                    {
                        if(arr[x,y]==arr[i,j])
                        {
                            Counted=true;
                            break;
                        }
                    }
                    if(Counted)break;
                }
                if(Counted)continue;
                for(int x=0;x<r;x++)
                {
                    for(int y=0;y<c;y++)
                    {
                        if(arr[x,y]==arr[i,j])
                        {
                            count++;
                        }
                    }
                }

                if(count>1)
                {
                    Console.WriteLine(arr[i,j]+" : "+count);
				}
				
            }
        }
		if(count==1){
		Console.WriteLine("any Element do not repetad");
		}
    }
}
