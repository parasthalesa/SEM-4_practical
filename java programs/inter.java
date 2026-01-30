interface A{
	void display();
}
class B implements A{
	public void display(){
		System.out.println("interface method is display");
	}
	void two(){
		System.out.println("B-two");
	}
}
class C extends B{
	void three(){
		System.out.println("C-three");
	}
}
class inter{
	public static void main(String[] args){
		B b=new B();
		b.two();
		b.display();
		C c=new C();
		c.three();
	}
}