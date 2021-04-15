package week5;

import java.util.Scanner;

public class Score {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        boolean run = true;
        
        System.out.println("    SCORE       GRADE");
        System.out.println("========================");
        while(run){
            int scanData = sc.nextInt();
            if(scanData <= 100 && scanData >= 90){
                System.out.println("    "+scanData+"       A");
            }else if(scanData >= 80){
                System.out.println("    "+scanData+"       B");
            }else if(scanData >= 70){
                System.out.println("    "+scanData+"       C");
            }else if(scanData >= 60){
                System.out.println("    "+scanData+"       D");
            }else if(scanData >= 50){
                System.out.println("    "+scanData+"       E");
            }else if(scanData >=0 && scanData <50){
                System.out.println(scanData+"       F");
            }

            if(scanData <0){
                run = false;
            }
        }
        System.out.println("프로그램 종료");
        sc.close();
    }
}
