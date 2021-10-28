public class Thread1 implements Runnable {

    @Override
    public void run() {
        System.out.println("Thread1 start");
        try {
            Thread.sleep(1000);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        System.out.println("Thread1 end");
    }

    public static void main(String[] args) {
        Thread t1 = new Thread(new Thread1());
        t1.start();
        System.out.println("main start");
        System.out.println("main end");
    }
}
