import java.util.Scanner;

public class PalindromeCheck {
	
    public static void main(String[] args){
        Scanner sc=new Scanner(System.in);
        System.out.print("Enter a string: ");
        String str=sc.nextLine();
        boolean isPalindrome=true;
        int start=0;
        int end=str.length()-1;
        while(start<end){
            if(str.charAt(start)!=str.charAt(end)){
                isPalindrome=false;
                break;
            }
            start++;
            end--;
        }
        if(isPalindrome){
            System.out.println("The string is a palindrome.");
        }
		else{
            System.out.println("The string is not a palindrome.");
        }

        sc.close();
    }
}
