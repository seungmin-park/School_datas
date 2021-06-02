package week14;

public class ProductEx {
	public static void main(String[] args) {
		Product<Tv,String> prod1 = new Product<>();
		prod1.setKind(new Tv());
		prod1.setModel("스마트TV");
		
		Tv tv = prod1.getKind();
		String tvModel = prod1.getModel();
		tv.tvPrn();
		System.out.println("===> "+ tvModel);
		
		Product<Car,String> prod2 = new Product<>();
		prod2.setKind(new Car());
		prod2.setModel("그랜져");
		
		Car car = prod2.getKind();
		String carModel = prod2.getModel();
		car.carPrn();
		System.out.println("===> "+ carModel);
	}
}
