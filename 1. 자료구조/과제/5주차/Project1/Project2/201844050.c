#include <stdio.h>

int main() {

	int		  i, iData[2][2][3] = { {{0,1,2}, {3,4,5} }, { {6,7,8}, {9,10,11}} };
	float			fData[2][2][3] = { {{12,13,14}, {15,16,17} }, { {18,19,20}, {21,22,23}} };
	char			cData[2][2][3] = { {{'a','b','c'}, {'d','e','f'} }, { {'g','h','i'}, {'j','k','l'}} };
	double		dData[2][2][3] = { {{24,25,26}, {27,28,29} }, { {30,31,32}, {33,34,35}} };

	int* iptr = &iData[0][0][0];
	for (i = 0; i < 12; i++) {
		printf("\n address: %u  iData[%d]= %d", iptr, i, *iptr);
		iptr++;
	}
	float* fptr = &fData[0][0][0];
	for (i = 0; i < 12; i++) {
		printf("\n address: %u  fData[%d]= %.2f", fptr, i, *fptr);
		fptr++;
	}
	char* cptr = &cData[0][0][0];
	for (i = 0; i < 12; i++) {
		printf("\n address: %u  cData[%d]= %c", cptr, i, *cptr);
		cptr++;
	}
	double* dptr = &dData[0][0][0];
	for (i = 0; i < 12; i++) {
		printf("\n address: %u  dData[%d]= %.2f", dptr, i, *dptr);
		dptr++;
	}

	return 0;
}