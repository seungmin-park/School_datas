package main

import (
	"fmt"
	"log"
	"os"
)

func isPrime(n int) (bool, error) {
	prime := true

	if n < 2 {
		fmt.Println()
		prime = false
		return prime, fmt.Errorf("%d는(은) 소수가 아닙니다!",n)
	}

	for i := 2; i < n; i++ {
		if n%i == 0 {
			prime = false
			break
		}
	}
	return prime, nil // 소수 판정값 정상 데이터
}

// 소수 판정 프로그램 v1.1 : 함수적용, error 리턴
func main() {
	var number int
	fmt.Print("정수 입력 : ")

	_, err := fmt.Scanln(&number)

	if err != nil {
		log.Fatal(err)
	}

	p, err := isPrime(number)
	if err != nil {
		fmt.Println(err)
		os.Exit(0)
	}

	if p {
		fmt.Println(number,"는(은) 소수입니다!")
	}else {
		fmt.Println(number,"는(은) 소수가 아닙니다!")
	}
}

//package main
//
//import (
//	"fmt"
//	"log"
//	"os"
//)
//
//func isPrime(n int) bool {
//	prime := true
//
//	for i := 2; i < n; i++ {
//		if n%i == 0 {
//			prime = false
//			break
//		}
//	}
//	return prime // true 리턴이면 소수 ,false 소수 x
//}
//
//// 소수 판정 프로그램 v1.0 : 함수적용
//func main() {
//	var number int
//	fmt.Print("정수 입력 : ")
//
//	_, err := fmt.Scanln(&number)
//
//	if err != nil {
//		log.Fatal(err)
//	}
//	if number < 2 {
//		fmt.Println(number,"는(은) 소수가 아닙니다!")
//		os.Exit(0)
//	}
//
//	if isPrime(number) {
//		fmt.Println(number,"는(은) 소수입니다!")
//	}else {
//		fmt.Println(number,"는(은) 소수가 아닙니다!")
//	}
//}

// After(multi return)
//package main
//
//import "fmt"
//
//func processScore(kor int, eng int, math int) (int, int) {
//	totalScore := kor + eng + math
//	avg := totalScore/3.0
//
//	return totalScore,avg
//	//fmt.Printf("%s의 총점은 %d 평균은 %d점 입니다.\n",name,totalScore,avg)
//}
//
//func main() {
//	t,a := processScore(100,90,93)
//	fmt.Printf("%s의 총점은 %d 평균은 %d점 입니다.\n","홍길동",t,a)
//	t,a = processScore(89,91,92)
//	fmt.Printf("%s의 총점은 %d 평균은 %d점 입니다.\n","홍길순",t,a)
//
//
//}

//After
//package main
//
//import "fmt"
//
//func processScore(name string,kor int, eng int, math int) {
//	totalScore := kor + eng + math
//	avg := totalScore/3.0
//
//	fmt.Printf("%s의 총점은 %d 평균은 %d점 입니다.\n",name,totalScore,avg)
//}
//
//func main() {
//	processScore("홍길동",100,90,93)
//	processScore("홍길순",89,91,92)
//}

// Before
//package main
//
//import "fmt"
//
//func main() {
//	kor := 100
//	eng := 90
//	math := 93
//	name := "홍길동"
//
//	fmt.Println(name,"의 총점은 ",(kor+eng+math),"입니다. 평균은 ",(kor+eng+math)/3.0)
//
//	kor = 100
//	eng = 90
//	math = 93
//	name = "홍길순"
//
//	fmt.Println(name,"의 총점은 ",(kor+eng+math),"입니다. 평균은 ",(kor+eng+math)/3.0)
//}

//package main
//
//import "fmt"
//
//func sayHello() {
//	fmt.Println("Hello~")
//}
//
//func main() {
//	sayHello()
//}