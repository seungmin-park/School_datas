package week14;

public class Util {
	public static <T> Box<T> Boxing(T t){
		Box<T> box = new Box<T>();
		box.setT(t);
		return box;
	}

}
class Box<T>{
	private T t;

	public T getT() {
		return t;
	}

	public void setT(T t) {
		this.t = t;
	}
	
}