package week7;

public class Car {
        //Car 클래스 선언
        String company = "현대자동차";
        String model;
        String color;
        int  maxSpped;

        Car(){
        }

        Car(String model){
            this(model,"은색",250);
        }

        Car(String model, String color){
            this(model, color,250);
        }

        Car(String model, String color, int maxSpped){
            this.model = model;
            this.color = color;
            this.maxSpped = maxSpped;
        }
}
