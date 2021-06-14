package week3;

public class BitShiftOperator {
    public static void main(String[] args) {
        System.out.println("1<<3       = " + (1<<3));
        System.out.printf(" 1         = %8s\n", Integer.toBinaryString(1));
        System.out.printf("(1<<3)     = %8s\n", Integer.toBinaryString(1<<3));

        System.out.println();   
        System.out.println("-8 >> 3     = " + (-8>>3));
        System.out.printf(" -8         = %8s\n", Integer.toBinaryString(-8));
        System.out.printf("(-8>>3)     = %8s\n", Integer.toBinaryString(-8>>3));

        System.out.println();   
        System.out.println("-9 >> 3      = " + (-9>>3));
        System.out.printf(" -9          = %8s\n", Integer.toBinaryString(-9));
        System.out.printf("(-9>>>>3)    = %8s\n", Integer.toBinaryString(-9>>>3));
    }
}