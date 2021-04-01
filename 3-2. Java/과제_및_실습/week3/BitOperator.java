package Java.week3;

public class BitOperator{
    public static void main(String[] args) {
        byte num1   = 45;
        byte num2   = 25;
        int result  = num1 & num2 ;

        System.out.println("num1 = " + num1);
        System.out.println("num2 = " + num2);
        System.out.println("result = " + result);

        System.out.printf("num1 = %6s\n", Integer.toBinaryString(num1));
        System.out.printf("num2 = %6s\n", Integer.toBinaryString(num2));

        System.out.printf("result = %6s\n", Integer.toBinaryString(result));

        result = num1| num2;
        System.out.printf("result = %6s\n", Integer.toBinaryString(result));

        result = num1^num2;
        System.out.printf("result = %6s\n", Integer.toBinaryString(result));

        result = ~ num1;
        System.out.printf("result = %6s\n", Integer.toBinaryString(result));

    }
}