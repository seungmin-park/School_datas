package week14;

public class UtilEx {
	public static void main(String[] args) {
		Box<Integer> box1 = Util.Boxing(100);
		int intVal1 = box1.getT();
		System.out.println("box1 = "+ intVal1);
		
		Box<String> box2 = Util.Boxing("ȫ�浿");
		String strVal = box2.getT();
		System.out.println("box2 = " + strVal);
	}
}
