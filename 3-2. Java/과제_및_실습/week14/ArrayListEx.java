package week14;

import java.util.ArrayList;
import java.util.List;

public class ArrayListEx {
	public static void main(String[] args) {
		List<String> list = new ArrayList<String>();
		int idx = 0;
		
		//리스트에 String 타입 객체 추가
		list.add("Java");
		list.add("Database");
		list.add("객체지향프로그래밍");
		
		//리스트에 객체가 총 몇 개 들어가있는지 확인
		int size = list.size();
		System.out.println("총 객체 수 : "+ size);
		System.out.println();
		
		//리스트의 인덱스 2번에 있는 객체 즉, 리스트의 3번째 위치에 존재하는 객체가 무엇인지 객체 값 확인
		String item = list.get(2);
		System.out.println("2 : "+ item);
		System.out.println();
		
		//리스트의 각 인덱스 위치에 어떠한 객체 값이 존재하는지 확인
		for(String s : list) {
			System.out.println(idx++ + " : " + s);
		}
		
		//리스트의 1번 인데스 즉, 2번째 위치에 있는 객체 2번 삭제
		list.remove(1);
		list.remove(1);
		System.out.println();
		
		//리스트의 1번 인덱스 객체 2번 지운후 리스트 안에 남아있는 객체 확인
		idx = 0;
		for(String s : list) {
			System.out.println(idx++ + " : " + s);
		}
	}
}
