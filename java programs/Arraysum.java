import java.util.Scanner;
class Arraysum{
    // Recursive method to calculate sum
    static int sumArray(int[] arr,int n){
        // Base case
        if (n==0)
            return 0;
        // Recursive case
        return arr[n-1]+sumArray(arr,n-1);
    }
    public static void main(String[] args){
		Scanner sc=new Scanner(System.in);
		System.out.println("enter size of array:");
		int n=sc.nextInt();
        int[] arr=new int[n];
		System.out.println("enter your number");
		for(int i=0;i<n;i++){
			arr[i]=sc.nextInt();
		}
        int sum=sumArray(arr,arr.length);
        System.out.println("Sum of array elements = "+sum);
    }
}
