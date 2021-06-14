package week13;

public class WaitNotifyExample {
    public static void main(String[] args) {
        DataBox dataBox = new DataBox();

        ProducerThread prodThread = new ProducerThread(dataBox);
        ConsumerThread consThread = new ConsumerThread(dataBox);

        prodThread.start();
        consThread.start();
    }
}
