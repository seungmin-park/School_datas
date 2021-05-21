package week12;

public class ClassC implements InterfaceA,InterfaceB {
    @Override
    public void methodA() {
        System.out.println("methodA");
    }
    
    @Override
    public void methodB(){
        System.out.println("methodB");
    }
}
