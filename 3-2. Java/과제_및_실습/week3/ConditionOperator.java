package week3;

public class ConditionOperator{
    public static void main(String[] args) {
        

        int num1 = 35;
        int num2 = 47;
        String result;

        result = (num1 > num2) ? "num1이 num2보다 큽니다" : "num1이 num2보다 작습니다";
        System.out.printf("num1 = %d, num2 = %d\n", num1, num2);
        System.out.printf("두 수를 비교한 결과는 %s\n\n",result);

        System.out.printf("%d가 %d보다 큽니까? %b\n\n",num1, num2, (num1> num2));

        boolean bResult;
        bResult = (num1 > num2) ? true : false;
        System.out.printf("num1 = %d, num2 = %d\n", num1, num2);
        System.out.printf("num1이 num2보다 큽니까? %b\n\n",bResult);
    }
}