package 과제_및_실습.week3;

public class OneOperand3{
    public static void main(String[] args) {
        int var1 = 10;
        int var2 = ~var1;
        int var3 = ~var1 + 1;

        System.out.printf("십진수(%d)  :%32s\n",var1, Integer.toBinaryString(var1));
        System.out.printf("십진수(%d):%32s\n",var2, Integer.toBinaryString(var2));
        System.out.printf("십진수(%d):%32s\n",var3, Integer.toBinaryString(var3));
    }
}