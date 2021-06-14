package week13;

public class ThreadABEx {
    public static void main(String[] args) {
        Thread mainThread = Thread.currentThread();
        System.out.println("프로그램 시작 스레드 이름: "+mainThread);

        ThreadA threadA = new ThreadA();
        threadA.start();
        System.out.println("작업 스레드 이름 - "+ threadA.getName());

        ThreadB threadB = new ThreadB();
        threadB.start();
        System.out.println("작업 스레드 이름 - "+ threadB.getName());
    }
}
