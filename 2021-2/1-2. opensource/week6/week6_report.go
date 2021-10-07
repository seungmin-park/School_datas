package main

import "fmt"

func main() {
	var a, b int
	s := []int{}

	fmt.Scan(&a,&b)

	//큰 수 판단 교환
	b, a = temp(b, a)
	//입력받은 두 수 사이의 수들 소수 판정
	s = primes(a, b, s)
	//슬라이스에 있는 수를 평균 구하기
	avg(s)
}

//숫자 교환 먼저 입력된 수가 더 클 경우 작은수가 앞에 오도록 변경
func temp(b int, a int) (int, int) {
	if b < a {
		temp := a
		a = b
		b = temp
	}
	return b, a
}

//소수 판정하여 슬라이스에 삽입 및 출력
func primes(a int, b int, s []int) []int {
	for i := a + 1; i < b; i++ {
		flag := true
		for j := 2; j < i; j++ {
			if i%j == 0 {
				flag = false
				break
			}
		}
		if flag {
			fmt.Print(i, " ")
			s = append(s, i)
		}
	}
	return s
}
//평균 구하기
func avg(s []int) {
	var sum float64
	for i := 0; i < len(s); i++ {
		sum += float64(s[i])
	}
	fmt.Printf("\n%.2f", sum/float64(len(s)))
}
