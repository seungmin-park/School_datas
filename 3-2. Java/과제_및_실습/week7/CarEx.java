package week7;

public class CarEx {
    public static void main(String[] args) {
        
        Car car1 = new Car();
        System.out.println(car1.company);
        System.out.println(car1.model);
        System.out.println(car1.color);
        System.out.println(car1.maxSpped);

        Car car2 = new Car("그랜저");
        System.out.println(car2.company);
        System.out.println(car2.model);
        System.out.println(car2.color);
        System.out.println(car2.maxSpped);

        Car car3 = new Car("소나타", "흰색");
        System.out.println(car3.company);
        System.out.println(car3.model);
        System.out.println(car3.color);
        System.out.println(car3.maxSpped);
    }


}
