import java.util.Scanner;
public class MaxArrayRecursive {
    static int findMax(int[] arr,int n) {
        if (n==1){
            return arr[0];
        }
        int maxOfRest=findMax(arr,n-1);
        return Math.max(arr[n - 1], maxOfRest);
    }
    public static void main(String[] args){
		Scanner sc=new Scanner(System.in);
		System.out.println("enter size of array");
		int n=sc.nextInt();
        int[] arr=new int[n];
		System.out.println("enter your number");
		for(int i=0;i<n;i++){
			arr[i]=sc.nextInt();
		}
        int max = findMax(arr, arr.length);
        System.out.println("Maximum element: "+max);
    }
}
