#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main() {

	char Students[8];
	int Kor = 0, Eng = 0, Mat = 0, sum = 0;
	double Avg = 0.0;
	FILE* fs = fopen("C:/in.txt", "r");

	printf("\t중간 고사 성적 알림표\n\n");
	printf("===============================================\n");
	printf(" 학번     국어  영어  수학   합계   평균\n\n");
	printf("===============================================\n");

	while (feof(fs) == 0) {
		fscanf(fs, "%s %d %d %d",Students, &Kor, &Eng, &Mat);
		sum = Kor + Eng + Mat;
		Avg = sum / 3;
		printf("%s    %d    %d    %d    %d    %.1f\n",Students, Kor, Eng, Mat, sum, Avg);
	}
	fclose(fs);

	return 0;
}