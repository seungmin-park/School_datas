package week12;

public class SmartTV implements Volume,Searchable {
    @Override
    public void search(String url){
        System.out.println(url + "을 검색합니다.");
    }

    @Override
    public void volumeUp(int level){
        System.out.println("TV 볼륨을 올립니다. " + level);
    }

    @Override
    public void volumeDown(int level){
        System.out.println("TV 볼륨을 내립니다. " + level);
    }
}
