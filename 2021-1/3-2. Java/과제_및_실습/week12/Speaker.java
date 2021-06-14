package week12;

public class Speaker implements Volume {
    private boolean mute;
    private int VolLevel;

        public Speaker(){
            VolLevel = 0;
        }
    

    @Override
    public void volumeUp(int level){
        VolLevel += level;
        if(VolLevel > MAX_VOLUME){
            VolLevel = MAX_VOLUME;
        }
        System.out.println("스피커 볼륨을 올립니다. " + VolLevel);
    }

    @Override
    public void volumeDown(int level){
        VolLevel -= level;
        if(VolLevel < MIN_VOLUME){
            VolLevel = MIN_VOLUME;
        }
        System.out.println("스피커 볼륨을 내립니다." + VolLevel);
    }
    @Override
    public void setMute(boolean mute){//디폴트 메소드 재정의
        this.mute = mute;
        if (mute) {
            System.out.println("스키퍼 무음 처리합니다");
        }
        else{
            System.out.println("스피커 무음 해제합니다");
        }
    }
}
