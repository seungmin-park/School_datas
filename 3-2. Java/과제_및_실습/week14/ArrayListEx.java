package week14;

import java.util.ArrayList;
import java.util.List;

public class ArrayListEx {
	public static void main(String[] args) {
		List<String> list = new ArrayList<String>();
		int idx = 0;
		
		//����Ʈ�� String Ÿ�� ��ü �߰�
		list.add("Java");
		list.add("Database");
		list.add("��ü�������α׷���");
		
		//����Ʈ�� ��ü�� �� �� �� ���ִ��� Ȯ��
		int size = list.size();
		System.out.println("�� ��ü �� : "+ size);
		System.out.println();
		
		//����Ʈ�� �ε��� 2���� �ִ� ��ü ��, ����Ʈ�� 3��° ��ġ�� �����ϴ� ��ü�� �������� ��ü �� Ȯ��
		String item = list.get(2);
		System.out.println("2 : "+ item);
		System.out.println();
		
		//����Ʈ�� �� �ε��� ��ġ�� ��� ��ü ���� �����ϴ��� Ȯ��
		for(String s : list) {
			System.out.println(idx++ + " : " + s);
		}
		
		//����Ʈ�� 1�� �ε��� ��, 2��° ��ġ�� �ִ� ��ü 2�� ����
		list.remove(1);
		list.remove(1);
		System.out.println();
		
		//����Ʈ�� 1�� �ε��� ��ü 2�� ������ ����Ʈ �ȿ� �����ִ� ��ü Ȯ��
		idx = 0;
		for(String s : list) {
			System.out.println(idx++ + " : " + s);
		}
	}
}
