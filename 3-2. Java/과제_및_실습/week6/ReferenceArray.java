package week6;

public class ReferenceArray {
    public static void main(String[] args) {
        String[] sArray = new String[3];
        sArray[0] = "Java";
        sArray[1] = "Java";
        sArray[2] = new String("Java");

        //자바는 문자열 리터럴이 동일하다면 String 객체를 공유한다.
        boolean bVal = (sArray[0] == sArray[1]);
        System.out.println("sArray[0], [1] : " + (bVal ? "참조가 같다": "참조가 다르다"));

        //new 연산자를 이용하여 생성된 객체는 힙 영역에 새로운 Stirng 객체를  생성한다.
        bVal = (sArray[0] == sArray[2]);
        System.out.println("sArray[0], [2] : " + (bVal ? "참조가 같다": "참조가 다르다"));

        //String 객체가 동일한 문자열을 가지고 있는지 비교할 경우에는 equals() 메소드를 사용한다.
        if(sArray[0].equals(sArray[2])){
            System.out.println("sArray[0]와 sArray[2]의 문자열은 동일하다.");
        }else{
            System.out.println("sArray[0]와 sArray[2]의 문자열은 다르다.");
        }
    }
}
