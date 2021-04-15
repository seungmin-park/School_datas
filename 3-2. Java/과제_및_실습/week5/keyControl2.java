package week5;

import java.io.IOException;

public class keyControl2 {
    public static void main(String[] args) throws IOException {
        int keyCode = 0;
        int count = 0;
        boolean run = true;

        System.out.println("값을 입력하세요.");
        while(run){
    
            keyCode = System.in.read();
        if(keyCode !=13 && keyCode != 10){
            System.out.println("입력된 값은 " + (char)keyCode + "입니다.");
            System.out.println("숫자를 입력하세요(0~9)");

            count++;
            if(count >=5){
                run = false;
                }
            }
        }

        System.out.println("프로그램 종료");
    }
}
