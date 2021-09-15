package main

import (
	"bufio"
	"fmt"
	"log" //Fatal function
	"os"
	"strconv" // ParseInt
	"strings" // TrimSpace
)

func main() {

	fmt.Print("단 입력 : ")
	rd := bufio.NewReader(os.Stdin)
	in, err := rd.ReadString('\n')
	if err != nil { //에러가 발생할 시
		log.Fatal(err)
	}

	in = strings.TrimSpace(in)
	dan, err := strconv.ParseInt(in,10,32)
	//dan, err := strconv.Atoi(in)
	if err != nil {
		log.Fatal(err)
	}

	i := 1
	//다른 언어의 while문 구현
	for i < 10 {
		fmt.Println(dan," * ", i, " = ",int(dan) * i)
		i++
	}


//	for i := 1; i < 10; i++ {
//		fmt.Println(dan," * ", i, " = ",int(dan) * i)
		//fmt.Println(dan," * ", i, " = ",dan * i)
//	}


}
