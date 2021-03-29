#include <stdio.h>

int main() {

	int		  i, iData[2][3] = { {0,1,2}, {3,4,5} };
	float			fData[2][3] = { {6,7,8}, {9,10,11} };
	char			cData[2][3] = { {'a','b','c'}, {'d','e','f'} };
	double		dData[2][3] = { {12,13,14}, {15,16,17} };

	int* iptr = &iData[0][0];
	for (i = 0; i < 6; i++) {
		printf("\n address: %u  iData[%d]= %d", iptr, i, *iptr);
		iptr++;
	}
	float* fptr = &fData[0][0];
	for (i = 0; i < 6; i++) {
		printf("\n address: %u  fData[%d]= %.3f", fptr, i, *fptr);
		fptr++;
	}
	char* cptr = &cData[0][0];
	for (i = 0; i < 6; i++) {
		printf("\n address: %u  cData[%d]= %c", cptr, i, *cptr);
		cptr++;
	}
	double* dptr = &dData[0][0];
	for (i = 0; i <6; i++) {
		printf("\n address: %u  dData[%d]= %.3f", dptr, i, *dptr);
		dptr++;
	}

	return 0;
}