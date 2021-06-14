package week12;

public class Radio implements Volume {
    private int VolLevel;

    public Radio(){
        VolLevel = 0;
    }

    @Override
    public void volumeUp(int level){
        VolLevel += level;
        if(VolLevel > Volume.MAX_VOLUME){
            VolLevel = Volume.MAX_VOLUME;
        }
        System.out.println("라디오 볼륨을 올립니다. " + VolLevel);
    }

    @Override
    public void volumeDown(int level){
        VolLevel -= level;
        if(VolLevel < Volume.MIN_VOLUME){
            VolLevel = Volume.MIN_VOLUME;
        }
        System.out.println("라디오 볼륨을 내립니다. " + VolLevel);
    }
}
