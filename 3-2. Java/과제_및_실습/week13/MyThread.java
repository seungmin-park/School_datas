package week13;

public class MyThread extends Thread {
    private int x;

    public MyThread(int x){
        this.x = x;
    }

    @Override
    public void run(){
        System.out.println(x +"번째 스레드 입니다.");
    }
}
