package Java.week3;

public class OneOperand2{
    public static void main(String[] args) {
        int x = 10;
        int y = 10;
        int z;

        //++연산자는 피연산자의 기존 값에 1을 더해서 그 결과를 다시 피연산자에 저장한다.
        //++ 기호가 피연산자의 뒤에 있으면 문장을 수행한 뒤에 1을 더한다.
        System.out.println("x++ = " + x++);
        System.out.println("--------------------");

        //++ 기호가 피연산자의 앞에 있으면 문장을 수행하기 전에 1을 먼저 더한다.
        System.out.println("++x = " + ++x);
        System.out.println("--------------------");

        z = x++;
        System.out.println("z = " + z + ", x =" + x);
        System.out.println("--------------------");

        //--연산자는 피연산자의 기존 값에 1을 빼서 그 결과를 다시 피연산자에 저장한다.
        z = ++x + y--;
        System.out.println("z = " + z);
        System.out.println("x = " + x);
        System.out.println("y = " + y);
    }
}