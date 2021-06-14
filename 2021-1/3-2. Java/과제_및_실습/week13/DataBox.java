package week13;

public class DataBox {
    private String data;

    public synchronized String getData(){
        if(this.data == null){
            try{
                wait();
            }catch (InterruptedException e){ }
        }
        String returnVlaue = data;
        System.out.println("ConsumerThread가 읽은 데이터 : "+returnVlaue);
        data = null;
        notify();
        return returnVlaue;
    }

    public synchronized void setData(String data){
        if(this.data != null){
            try{
                wait();
            }catch (InterruptedException e) {}
        }
        this.data = data;
        System.out.println("Producer Thread가 생성한 데이터 : " + data);
        notify();
    }

}
