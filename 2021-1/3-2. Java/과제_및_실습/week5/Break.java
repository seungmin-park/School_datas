package week5;

public class Break {
    public static void main(String[] args) {
        int count = 0;
        
        while(true){
            int num = (int) (Math.random() * 10);

            System.out.println("랜덤 숫자 = " + num);
            
            count++;
            if(num == 7){
                break;
            }
        }
        System.out.println();
        System.out.println("반복 횟수 : " + count);
        System.out.println("프로그램 종료");
    }
}
