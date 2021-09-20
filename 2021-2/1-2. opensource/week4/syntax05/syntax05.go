package main

import "fmt"

// shadowing
func main() {
	var test1 float64 = 9.1
	var test2 float64 = 7.9
	var univ string = "inha"

	var f1 string = "functions"
	var f2 = append([]string{},"함수")

	fmt.Println(test1 + test2)
	fmt.Println(univ)
	fmt.Println(f1)
	fmt.Println(f2)

}

//package main
//
//import (
//	"fmt"
//	"log"
//	"os"
//)
//// 입력(0과 1처리)된 수의 소수 판정 프로그램 v0.9
//func main() {
//	var number int
//	fmt.Print("정수 입력 : ")
//
//	_, err := fmt.Scanln(&number)
//
//	if err != nil {
//		log.Fatal(err)
//	}
//	for number < 2 {
//		fmt.Println(number,"는(은) 소수가 아닙니다!")
//		os.Exit(1)
//	}
//	isPrime := true
//
//	fmt.Println("임의로 추출된 수 : ",number)
//
//	for i := 2; i < number; i++ {
//		if number%i == 0 {
//			isPrime = false
//			break
//		}
//	}
//
//	if isPrime {
//		fmt.Println(number,"는(은) 소수입니다!")
//	}else {
//		fmt.Println(number,"는(은) 소수가 아닙니다!")
//	}
//}

//package main
//
//import (
//	"fmt"
//	"log"
//)
//// 입력(fmt 패키지의 Scanln())된 수의 소수 판정 프로그램 v0.8
//func main() {
//	var number int
//	fmt.Print("정수 입력 : ")
//
//	_, err := fmt.Scanln(&number)
//
//	if err != nil {
//		 log.Fatal(err)
//	}
//
//	isPrime := true
//
//	fmt.Println("임의로 추출된 수 : ",number)
//
//	for i := 2; i < number; i++ {
//		if number%i == 0 {
//			isPrime = false
//			break
//		}
//	}
//
//	if isPrime {
//		fmt.Println(number,"는(은) 소수입니다!")
//	}else {
//		fmt.Println(number,"는(은) 소수가 아닙니다!")
//	}
//}


//package main
//
//import (
//	"bufio"
//	"fmt"
//	"log"
//	"os"
//	"strconv"
//	"strings"
//
//	//"time"
//)
//// 입력된 수의 소수 판정 프로그램 v0.7
//func main() {
//
//	fmt.Print("정수 입력 : ")
//
//	rd := bufio.NewReader(os.Stdin)
//	in, err := rd.ReadString('\n')
//
//	if err != nil {
//		log.Fatal(err)
//	}
//
//	in = strings.TrimSpace(in)
//	number,err := strconv.Atoi(in)
//	if err != nil {
//		log.Fatal(err)
//	}
//
//	isPrime := true
//
//	fmt.Println("임의로 추출된 수 : ",number)
//
//	for i := 2; i < number; i++ {
//		if number%i == 0 {
//			isPrime = false
//			break
//		}
//	}
//
//	if isPrime {
//		fmt.Println(number,"는(은) 소수입니다!")
//	}else {
//		fmt.Println(number,"는(은) 소수가 아닙니다!")
//	}
//}
