package 과제_및_실습.week5;

import java.io.IOException;

public class KeyControl {
    public static void main(String[] args) throws IOException {
        int keyCode = 0;

        System.out.println("값을 입력하세요.");

        keyCode = System.in.read();

        System.out.println("입력된 값 : " + keyCode);
    }
}
