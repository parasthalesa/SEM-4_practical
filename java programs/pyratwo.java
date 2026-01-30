public class pyratwo{
    public static void main(String[] args){
        int rows=4;
        for (int i= 1;i<=rows;i++){
            System.out.print("1");
            for (int j=1;j<i;j++){
                System.out.print("0");
            }
            if (i>1){
                System.out.print("1");
            }
            System.out.println();
        }
    }
}