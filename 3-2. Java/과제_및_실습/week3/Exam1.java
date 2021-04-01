package 과제_및_실습.week3;

public class Exam1{
    public static void main(String[] args) {
        int distance = 100;
        int second = 5;

        double velocity = (double)distance / (second*60);

        System.out.println("5분동안 100m를 이동하는 물체의 속력은");
        System.out.printf("%.4fm/s입니다.",velocity);
    }
}