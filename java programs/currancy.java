import java.util.Scanner;

class curancy1{
    public static void main(String[] args){
        double ind=89.81;
        double total;
        Scanner sc= new Scanner(System.in);
        System.out.println("enter your amount in dollar");
        double dollar = sc.nextInt();
        total=ind*dollar;
        System.out.println("your total indian rupes is="+ total);
    }
}