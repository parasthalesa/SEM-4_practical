class book{
	
	String title;
	book (String title){
		this.title=title;
	}
	public boolean equals(Object obj){ 
		book b=(book)obj;
		return this.title.equals(b.title);
	}
	public static void main(String[] args){
		book b1=new book("java");
		book b2=new book("java");
		System.out.println(b1.equals(b2));
	}
	
}