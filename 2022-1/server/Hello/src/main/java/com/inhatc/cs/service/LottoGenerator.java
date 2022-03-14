package com.inhatc.cs.service;

import java.util.Random;

public class LottoGenerator {
    public int[] testNumber() {
        Random random = new Random();
        int lottoArr[] = new int[6];
        int index = 0;
        boolean flag = true;

        lottoArr[index] = random.nextInt(45)+1;
        index++;
        while (true){
            flag = true;
            if (lottoArr[5] != 0){
                break;
            }
            int ran = random.nextInt(45)+1;
            for (int i = 0; i < index; i++) {
                if (lottoArr[i] == ran){
                    flag = false;
                    break;
                }
            }
            if (flag){
                lottoArr[index] = ran;
                index++;
            }
        }
        return lottoArr;
    }
}
