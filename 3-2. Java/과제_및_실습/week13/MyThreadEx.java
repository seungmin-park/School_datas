package week13;

public class MyThreadEx {
    public static void main(String[] args) {
        for(int i = 0; i < 100; i++){
            MyThread myThread = new MyThread(i+1);
            
        }
    }
}
