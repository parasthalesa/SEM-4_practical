using System;
class demo{
	static void Main(){
		//defaul constuctor call automaticlt
		xyz obj1=new xyz();//static
		xyz obj2=new xyz(10);//peraiter
	}
}
class xyz{
	public xyz(){
		Console.WriteLine("this is default");
	}
	
	static xyz(){
		Console.WriteLine("this is static");
	}
	
	public xyz(int a){
		Console.WriteLine("this is peramiter"+a);
	}
}