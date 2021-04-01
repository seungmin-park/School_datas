package 과제_및_실습.week5;

import java.util.Scanner;

public class DoWhile {
    public static void main(String[] args) {
        System.out.println("메세지를 입력하세요");
        System.out.println("프로그램을 종료하려면 q를 입력하세요");

        Scanner scanData = new Scanner(System.in);
        String inputStr;

        do{
            System.out.print(">");
            inputStr = scanData.nextLine();
            System.out.println(inputStr);
        }while(!inputStr.equals("q"));

            System.out.println();
            System.out.println("프로그램 종료");
    scanData.close();
    }
}
