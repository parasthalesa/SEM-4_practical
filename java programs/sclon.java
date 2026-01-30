class abc {
	int i,j;
	public String toString(){
		return "abc i="+ i+"abc j="+j;
	}
}
class sclon{
	public static void main(String[] args){
		abc o=new abc();
		o.i=5;
		o.j=6;
		abc o1=o;
		System.out.println(o);
		System.out.println(o1);
	}
}