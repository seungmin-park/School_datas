package 과제_및_실습.week3;

public class logicalOperator{
    public static void main(String[] args) {
        int charCode1 = 'A';
        if(charCode1 >= 65 & charCode1 <= 90){
            System.out.println((char)charCode1 + "는 알파벳 대문자 입니다.");
        }

        int charCode2 = 'b';
        if(charCode2 >= 97 && charCode2 <= 122){
            System.out.println((char)charCode2 + "는 알파벳 소문자 입니다.");
        }
        
        int charCode3 = '9';
        if(!(charCode3 < 48) && !(charCode3 >57)){
            System.out.println((char)charCode3 + "는 0~9 사이의 숫자 입니다.");
        }

        int iValue = 4;
        if( (iValue % 2 == 0) | (iValue % 3 == 0)){
            System.out.println(iValue + "는2 또는 3의 배수입니다.");
        }
    }
}