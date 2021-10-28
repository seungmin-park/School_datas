public class Thread3Demo {
    public static void main(String[] args) {
        Runnable task = () ->{
            for (int i = 0; i <5; i++) {
                System.out.println("잘가. ");
            }
            try {
                Thread.sleep(500);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        };
        new Thread(task).start();

        for (int i = 0; i < 5; i++) {
            System.out.println("안녕. ");
            try {
                Thread.sleep(500);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }

}
