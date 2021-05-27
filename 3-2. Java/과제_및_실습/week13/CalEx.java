package week13;

public class CalEx {
    public static void main(String[] args) {
        Calculator calculator = new Calculator();

        CalUser1 user1 = new CalUser1();
        user1.setCalculator(calculator);
        user1.start();

        CalUser2 user2 = new CalUser2();
        user2.setCalculator(calculator);
        user2.start();
    }
}
