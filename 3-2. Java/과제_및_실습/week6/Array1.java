package week6;

public class Array1 {
    public static void main(String[] args) {
        //값  목록으롤 배열을 생성하는 방법
        int[]   score = {70, 90, 65, 83, 50};
        String[] pNames = {"Java", "C", "Python", "C#"};
        double[] dArray1;
        dArray1 = new double[] {0.1, 0.2, 0.3, 0.4};

        //new 연산자로 배열을 생성하면 자동적으로 기본값으로 초기화 된다.
        int[] intArray = new int[5];
        System.out.println("intArray[0] = " + intArray[0]);

        double[] dArray2 = new double[5];
        System.out.println("dArray2[0] = " + dArray2[0]);

        String[] sArray = new String[4];
        System.out.println("sArray[0] = " + sArray[0]);

        //배열에 새로운 값을 저장하려면 대입 연산자를 이용한다.
        for(int i = 0; i <4 ; i ++){
            sArray[i] = pNames[i];
            System.out.printf("sArray[%d] = %s\n",i,sArray[i]);
        }
    }
}
