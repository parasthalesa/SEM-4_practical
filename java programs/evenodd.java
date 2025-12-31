import java.util.Scanner;

class evenodd{
    public static void main(String[] args){

        Scanner sc= new Scanner(System.in);

        System.out.println("enter number");

        int num = sc.nextInt();

        if(num  % 2 == 0)
            System.out.println("number is even");
        else
            System.out.println("number is odd");
    }
}