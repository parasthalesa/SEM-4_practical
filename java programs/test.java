import java.util.Scanner;
class test{
	public static void main(String[] args){
		Scanner nc=new Scanner(System.in);
		System.out.println("enter your array lenth");
		int n=nc.nextInt();
		int[] arr=new int[n];
		System.out.println("enter your values:");
		for(int i=0;i<n;i++){
			arr[i]=nc.nextInt();
		}
		int sum=sumofarr(arr,n);
		System.out.println("sum of array is="+sum);
	}
	static int sumofarr(int[] arr, int a){
		if(a==0)
			return 0;
		return arr[a-1]+sumofarr(arr,a-1);
		//return arr[n-1]+sumArray(arr,n-1);

	}
}