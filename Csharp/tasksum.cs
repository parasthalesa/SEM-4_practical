using System;
class demo{
	static void Main(){
		sum s1=new sum();
		sum s2=new sum(10,20);
		sum s3=new sum(s2);
		Console.ReadLine();
	}
	
}
class sum{
	int x,y;
	public sum(){
		Console.WriteLine("default");
	}
	public sum(int a,int b){
		x=a;
		y=b;
		Console.WriteLine("sum :"+(a+b));
	}
	public sum(sum temp){
		x=temp.x;
		y=temp.y;
		Console.WriteLine("a="+x);
		Console.WriteLine("b="+y);
	}
	/*public void show(){
        Console.WriteLine("value:"+x);
    }*/
}