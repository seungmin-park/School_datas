package 과제_및_실습.week5;

public class ForGugu {
    public static void main(String[] args) {
        
        for(int i = 2; i < 10; i ++){
            System.out.println("==========");
            System.out.println("구구단 : " + i + "단");
            System.out.println("==========");

            for(int j = 2; j <10; j ++){
                System.out.println(i + " * " + j + " = " + (i*j));
            }
        }
    }
}
