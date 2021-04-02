#include <stdio.h>

int main() {

    int        i, iData[2][2][3] = { {{0,1,2}, {3,4,5} }, { {6,7,8}, {9,10,11}} };
    float         fData[2][2][3] = { {{12,13,14}, {15,16,17} }, { {18,19,20}, {21,22,23}} };
    char         cData[2][2][3] = { {{'a','b','c'}, {'d','e','f'} }, { {'g','h','i'}, {'j','k','l'}} };
    double      dData[2][2][3] = { {{24,25,26}, {27,28,29} }, { {30,31,32}, {33,34,35}} };

    for (i = 0; i < 2; i++) {
        for (int j = 0; j < 2; j++) {
            for (int r = 0; r < 3; r++) {
                int* iptr = &iData[i][j][r];
                printf("\n address: %u  iData[%d][%d][%d]= %d", iptr, i, j, r, *iptr);
                iptr++;
            }
        }
    }
    for (i = 0; i < 2; i++) {
        for (int j = 0; j < 2; j++) {
            for (int r = 0; r < 3; r++) {
                float* fptr = &fData[i][j][r];
                printf("\n address: %u  fData[%d][%d][%d]= %.2f", fptr, i, j, r, *fptr);
                fptr++;
            }
        }
    }
    for (i = 0; i < 2; i++) {
        for (int j = 0; j < 2; j++) {
            for (int r = 0; r < 3; r++) {
                char* cptr = &cData[i][j][r];
                printf("\n address: %u  cData[%d][%d][%d]= %c", cptr, i, j, r, *cptr);
                cptr++;
            }
        }
    }
    for (i = 0; i < 2; i++) {
        for (int j = 0; j < 2; j++) {
            for (int r = 0; r < 3; r++) {
                double* dptr = &dData[i][j][r];
                printf("\n address: %u  dData[%d][%d][%d]= %.2f", dptr, i, j, r, *dptr);
                dptr++;
            }
        }
    }

    return 0;
}