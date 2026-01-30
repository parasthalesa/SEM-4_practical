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
		System.out.pritln("C-three");
	}
}
class 