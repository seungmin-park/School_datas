package week6;

public class Reference1 {
    public static void main(String[] args) {
        //기본 데이터 타입의 변수는 스택영역에 생서되면서 값도 같이 저장된다.
        int iVal1 = 100;
        int iVal2 = 100;
        System.out.println("iVal1 == iVal2 : " + (iVal1 == iVal2));

        //참조 타입의 변수는 스택영역에 생성되면서 해당 객체의 주소를 저장한다.
        String sVal1 = "Java";
        String sVal2 = "Java";

        //자바는 무낮열 리터럴이 동일하다면 String 객체를 공유한다.
        System.out.println("sVal1 == sVal2 : " + (sVal1 == sVal2 ? "참조가 같음" : "참조가 다름"));

        //참조타입의 변수는 초기값으로 null을 사용할 수 있다.(스택영역에만 생성됨)
        String sVal5 = null;

        //참조타입의 변수가 null 값을 가지고 있을 때는 해당 변수를 사용할 수 없다.
        // =>NullPointException 에러 발생
        //System.out.println("Sval5.length = " + sVal5.length());

        //값을 대입하는 순간 힙영역에 객체가 생성되고 해당 주소가 스택영역의 변수값에 저장됨
        sVal5 ="Java";
        System.out.println("sVal5 = " + sVal5);
        System.out.println("sVal1 == sVal5" + (sVal1 == sVal5 ? "참조가 같음" : "참조가 다름"));
    }
}
