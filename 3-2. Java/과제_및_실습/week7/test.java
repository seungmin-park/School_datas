package week7;

public class test {
    public static void main(String[] args) {
        int[] intArray = {0,1,2,4,5};
        int max = 0;

        for(int i = 0; i < intArray.length; i++){
            if(intArray[i] > max){
                max = intArray[i];
            }
        }
        System.out.println(max);
    }
}
