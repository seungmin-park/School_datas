package week14;

public class Product<T,M> {
	private T kind;
	public T getKind() {
		return kind;
	}
	public void setKind(T kind) {
		this.kind = kind;
	}
	public M getModel() {
		return model;
	}
	public void setModel(M model) {
		this.model = model;
	}
	private M model;
}

class Tv{
	public void tvPrn() {
		System.out.println("TV 종류");
	}
}

class Car{
	public void carPrn() {
		System.out.println("Car 종류");
	}
}