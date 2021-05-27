package week13;

public class ThreadA extends Thread {
    public ThreadA(){
        setName("ThreaA");
    }

    @Override
    public void run(){
        for(int i = 0; i <5; i++){
            System.out.println(getName()+" 작동중");
        }
    }
}
