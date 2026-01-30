class Student{
	String name="paras";
	int age=18;
	public String toString(){
		return this.name+" "+age;
	}
	public static void main(String[] args){
		Student s=new Student();
		System.out.println(s.toString());
	}
}
