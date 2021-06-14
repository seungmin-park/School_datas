package week6;

public class TwoDimension {
    public static void main(String[] args) {
        int[][] math = new int[2][3];
        for(int i = 0; i < math.length; i ++){
            for(int j = 0; j < math[i].length; j++){
                System.out.printf("math[%d][%d] = %d\n",i ,j ,math[i][j]);
            }
        }
        System.out.println();

        int[][] eng = new int[2][];
        eng[0] = new int[2];
        eng[1] = new int[3];
        for(int i = 0; i < eng.length; i ++){
            for(int j = 0; j < eng[i].length; j++){
                System.out.printf("eng[%d][%d] = %d\n",i ,j ,eng[i][j]);
            }
        }
        System.out.println();

        int[][] kor = {{95, 80}, {92, 96, 80}};
        for(int i = 0; i < kor.length; i ++){
            for(int j = 0; j < kor[i].length; j++){
                System.out.printf("kor[%d][%d] = %d\n",i ,j ,kor[i][j]);
            }
        }
        System.out.println();
    }
}
