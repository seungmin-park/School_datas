package week13;

public class BeepTask implements Runnable {
    
    @Override
    public void run(){
        for(int i = 0; i < 5; i++){
            System.out.println("삐~");
            try {
                Thread.sleep(500);
            } catch (Exception e) {
                //TODO: handle exception
            }
        }
    }
}
