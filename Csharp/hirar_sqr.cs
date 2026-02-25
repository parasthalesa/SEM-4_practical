using System;
class demo{
	static void Main(){
		child ch=new child();
		ch.vget();
	}
}
public class par{
	protected int squer(int a){
		
		return a*a;
	}
}
public class pchild:par{
	
	protected int pass(int n){
		int ret=squer(n);
		return ret;
	}
}
public class child: pchild{
	
	public void vget(){
		Console.Write("entrer your elenment=");
		int v=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("your element is="+v);
		int final=pass(v);
		Console.WriteLine("your squr is="+final);
	}
}