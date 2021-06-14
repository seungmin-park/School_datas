package week6;

public class studentsScore {
	public static void main(String[] args) {
		int[][] score = {{49, 80, 20, 100, 80},
						{43, 60, 85, 30, 90},
						{49, 82, 48, 50, 100}};
		char[] student = {'A', 'B', 'C', 'D', 'E'};
		int[] sum = new int[5];
		double[] avg = new double[5];

		for(int i = 0; i < score[0].length; i++) {
			for(int j = 0; j < score.length; j++) {
				sum[i] = sum[i] + score[j][i];
			}
			avg[i] = sum[i] / 3;
			System.out.printf("%c 학생 총점 : %d점, 평균  : %.1f점\n",student[i],sum[i],avg[i]);
		}

	}
}
