package week13;

public class ThreadB extends Thread{
    public ThreadB(){
        setName("ThreadB");
    }

    @Override
    public void run(){
        for(int i = 0; i < 5; i ++){
            System.out.println(getName()+" 작동중");
        }
    }
}
