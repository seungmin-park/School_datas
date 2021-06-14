package week6;

public class Reference2 {
    public static void main(String[] args) {
        //자바는 문자열 리터럴이 동일하다면 String 객체를 공유한다.
        String sVal1 = "Java";
        String sVal2 = "Java";
        System.out.println("sVal1 == sVal2 : "+ (sVal1 == sVal2 ? "참조가 같음" : "참조가 다름"));

        //new 연산자를 이용하는 경우에는 힙 영역에 새로운 String 객체가 생성된다.
        String sVal3 = new String("Java");
        String sVal4 = new String("Java");
        System.out.println("sVal3 == sVal4 : "+ (sVal3 == sVal4 ? "참조가 같음" : "참조가 다름"));

        //String 객체가 동일한 문자열을 가지고 있는지 비교할 경우에는
        //반드시 equals() 메소드를 사용한다.
        if(sVal3.equals(sVal4)){
            System.out.println("sVal3 와 sVal4의 문자열은 동일하다.");
        }
        else{
            System.out.println("sVal3 와 sVal4의 문자열은 다르다.");
        }
    }
}
