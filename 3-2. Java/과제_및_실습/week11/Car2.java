package week11;

public class Car2 {
    int     speed = 0;
    String color;

    void upSpeed(int speed){
        this.speed += speed;
    }
    abstract void work();
}
