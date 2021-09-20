// 과제 : 입력받은 두 정수 사이의 소수 출력
package main

import (
	"fmt"
	"log"
	"os"
)

func Prime(num1 int,num2 int) error {

	if num1 < 2{
		return fmt.Errorf("%d는(은) 소수가 아닙니다~",num1)
	} else if num2 < 2 {
		return fmt.Errorf("%d는(은) 소수가 아닙니다~",num2)
	}

	if num2 < num1 {
		temp := num1
		num1 = num2
		num2 = temp
	}

	for i := num1; i < num2; i++ {
		prime := true
		for j := 2; j < i; j++ {
			if i%j == 0 {
				prime = false
				break
			}
		}
		if prime {
			fmt.Printf("%d ",i)
		}
	}
	return nil // 소수 판정값 정상 데이터
}

func main() {
	var number1 int
	var number2 int
	fmt.Print("정수 입력 : ")

	_, err := fmt.Scanf("%d %d", &number1, &number2)

	if err != nil {
		log.Fatal(err)
	}

	err = Prime(number1,number2)
	if err != nil {
		fmt.Println(err)
		os.Exit(0)
	}

}