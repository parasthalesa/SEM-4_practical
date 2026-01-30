import java.util.Scanner;
public class demoarr{
    // Recursive function to find maximum
    static int findMax(int[] arr, int n) {
        // Base case
        if (n==1) {
            return arr[0];
        }
        // Recursive call
        int maxOfRest=findMax(arr, n-1);
        // Compare last element with max of rest
        return Math.max(arr[n-1],maxOfRest);
    }
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        // Input array size
        System.out.print("Enter array size: ");
        int n = sc.nextInt();
        int[] arr =new int[n];
        // Input array elements
        System.out.println("Enter array elements:");
        for (int i = 0; i < n; i++) {
            arr[i] = sc.nextInt();
        }
        // Find maximum element
        int max = findMax(arr, n);
        System.out.println("Maximum element in array: " + max);
        sc.close();
    }
}
