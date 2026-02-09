using System;
class demo{
	static void Main(){
		string[] foodname=new string[10];
		int[] price=new int[10];
		int[] fqty=new int[10];
		int[] total=new int[10];
		int count=0;
		string a;
		do{
			Console.WriteLine("enter your choice");
			Console.WriteLine("1. Gujrati=30");
			Console.WriteLine("2. punjabi=50");
			Console.WriteLine("3. chass=10");
			Console.WriteLine("4. pizza=100");
			int food=Convert.ToInt32(Console.ReadLine());
			
			switch (food){
				case 1:
				Console.WriteLine("enter quentity");
				int qty=Convert.ToInt32(Console.ReadLine());
				foodname[count]="Gujrati";
				price[count]=30;
				fqty[count]=qty;
				total[count]=30*qty;
				count++;
				break;
				
				case 2:
				Console.WriteLine("enter quentity");
				qty=Convert.ToInt32(Console.ReadLine()); 
				foodname[count]="punjabi";
				price[count]=50;
				fqty[count]=qty;
				total[count]=50*qty;
				count++;
				break;
				
				case 3: 
				Console.WriteLine("enter quentity");
				qty=Convert.ToInt32(Console.ReadLine());
				foodname[count]="chass";
				price[count]=10;
				fqty[count]=qty;
				total[count]=10*qty;
				count++;
				break;
				
				case 4:
				Console.WriteLine("enter quentity");
				qty=Convert.ToInt32(Console.ReadLine());				
				foodname[count]="pizza";
				price[count]=100;
				fqty[count]=qty;
				total[count]=100*qty;
				count++;
				break;
				
				default:
				Console.WriteLine("un define choice");
				break;
			}
			
			Console.WriteLine("Do You Want To Continue y/n");
			a=Console.ReadLine();
			
		}while(a=="y");
		Console.WriteLine("Food\tPrice\tQty\tTotal");
		int alltotal=0;
		for(int i=0;i<count;i++){
			Console.Write(foodname[i]+"\t");
			Console.Write(price[i]+"\t");
			Console.Write(fqty[i]+"\t");
			Console.WriteLine(total[i]);
			alltotal+=total[i];
		}
		Console.WriteLine("Grand alltotal:"+alltotal);
		Console.WriteLine("thankyou!");
		Console.ReadLine();
	}
}