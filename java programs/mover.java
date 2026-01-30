class vehical{
	void run(){
		System.out.println("vehical is running");
	}
}
class bike extends vehical{
	void run(){
		System.out.println("bike is running");
	}
}
public class mover{
	
	public static void main(String[] args){
		vehical v=new vehical();
		v.run();
		bike obj=new bike();
		obj.run();
	}
}