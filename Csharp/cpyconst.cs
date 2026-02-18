using System;
class demo{
    static void Main(){
        xyz obj1=new xyz(20);
        xyz obj2=new xyz(obj1);

        obj1.show();
        obj2.show();
        Console.ReadLine();
    }
}
class xyz{
    int x;
    public xyz(int a){
        x=a;
        Console.WriteLine("hello");
    }
    
    public xyz(xyz temp){
        Console.WriteLine("before copy"+x);
        x=temp.x;
        Console.WriteLine("after copy");
    }
    public void show(){
        Console.WriteLine("value:"+x);
    }
}