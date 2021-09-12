//syntax

package main

import (
	"fmt"
	"math"
	"strings"
)

func main() {

	var c rune = '가'
	var a int16 = 7

	fmt.Println(math.Ceil(2.41))
	fmt.Println("Hello Go ~")
	fmt.Println(strings.Title("go git github java"))
	fmt.Println(c) // 유니코드값 출력 UTF-8
	fmt.Printf("%c\n",c) // 한 글자 출력
	fmt.Printf("%T\n",c) // 타입 출력 int32 alias
	fmt.Println(a)
}
