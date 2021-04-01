package 과제_및_실습.week3;

public class OneOperand1{
    public static void main(String[] args) {
        int     iValue1 = +100;
        int     iValue2 = -100;
        double  dValue1 = +3.14;
        double  dValue2 = -10.5;

        int     result1 = +iValue1;
        int     result2 = -iValue1;
        System.out.printf("result1 = %d\n",result1);
        System.out.printf("result2 = %d\n",result2);

        short   sValue = 100;
        //int보다 크기가 작은 경우 부호 연산자의 결과는 int 타입이 된다.
        //short sResult = -sValue                   //에러발생
        int sResult = -sValue;
        System.out.println("sResult = " + sResult);

        byte    bValue  = -100;
        int     bResult = -bValue;
        System.out.println("bResult = " + bResult);

        long    lValue  = 100;
        long    lResult = -lValue;
        System.out.println("lResult = "+ lResult);

        double  dResult = -dValue1;
        System.out.println("dResult = "+ dResult);
    }
}