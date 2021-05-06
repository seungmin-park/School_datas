package week10;

public class Parent {
    public String nation;
    public Parent(){
        this("대한민국");
        System.out.println("Parent() Call");
    }
    public Parent(String string){
        this.nation = "대한민국";
        System.out.println("Parent(String String) call");
    }
}
