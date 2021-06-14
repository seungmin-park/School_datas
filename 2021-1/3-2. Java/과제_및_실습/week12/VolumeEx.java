package week12;

public class VolumeEx {
    public static void main(String[] args) {
        // 구현 클래스를 이용한 객체 생성
        Radio radio = new Radio();
        TV tv = new TV();

        //생성된 객체를 이용한 매소드 호출
        radio.volumeUp(3);
        radio.volumeDown(5);
        tv.volumeUp(6);
        tv.volumeDown(4);
        System.out.println("--------------------------");

        //인터페이스를 이용한 메소드 호출
        Volume[] vol = new Volume[3];
        vol[0] = radio;
        vol[1] = tv;
        vol[2] = new Speaker();

        for(int i = 0; i < vol.length; i++){
            vol[i].volumeUp(3);
            vol[i].setMute(true);
        }
    }
}
