package main

import "fmt"

func main() {
	//anArray := [4]int{1, 2, 4, -4}
	//twoD := [4][4]int{{1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16}}
	threeD := [2][2][2]int{{{1, 0},{-2, 4}},{{5, -1},{7, 0}}}

	for i := 0; i<len(threeD); i++{
		v := threeD[i]
		for j := 0; j<len(v); j++{
			m := v[j]
			for k := 0; k<len(m); k++{
				fmt.Print(m[k], " ")
			}
			fmt.Println()
		}
		fmt.Println("\n")
	}
	//fmt.Println("Hello, 世界")
}

// package main

// import "fmt"

// func main() {
// 	anArray := [4]int{1, 2, 4, -4}

// 	for _, v := range anArray {
// 		fmt.Printf("%d ", v)
// 	}
// 	//for k := 0; k<len(anArray); k++{
// 	//	fmt.Printf("%d ",anArray[k])
// 	//}
// }

// package main

// import "fmt"

// func main() {
// 	//var s1 []int
// 	//s1 = make([]int, 5)

// 	s1 := []int{1,2,3,4,5}
// 	reSlice := s1[1:3]
// 	fmt.Println(s1)
// 	fmt.Println(reSlice)

// 	reSlice[0] = -100
// 	reSlice[1] = 123456
// 	fmt.Println(s1)
// 	fmt.Println(reSlice)

// }

// package main

// import "fmt"

// func printSlice(numbers []int) {
// 	for _, number := range numbers {
// 		fmt.Print(number, " ")
// 	}
// 	fmt.Println()
// }

// func main() {
// 	aSlice := []int{-1, 0, 4, 100}

// 	printSlice(aSlice)
// 	fmt.Printf("수용량 : %d, 길이: %d\n", cap(aSlice), len(aSlice))
// 	aSlice = append(aSlice, -99)
// 	printSlice(aSlice)
// 	fmt.Printf("수용량 : %d, 길이: %d\n", cap(aSlice), len(aSlice))
// 	aSlice = append(aSlice, 1)
// 	aSlice = append(aSlice, 2)
// 	aSlice = append(aSlice, 3)
// 	aSlice = append(aSlice, 4)
// 	printSlice(aSlice)
// 	fmt.Printf("수용량 : %d, 길이: %d\n", cap(aSlice), len(aSlice))

// }


// package main

// import "fmt"

// func plus(p1, p2, p3 *int) {
// 	*p3 = *p1 + *p2
// }

// func main() {
// 	a := 11
// 	b := 2
// 	c := 0

// 	plus(&a, &b, &c)
// 	fmt.Print(c)
// }


// package main

// import "fmt"

// type Soldier struct {
// 	Name  string
// 	Id    int
// 	Grade string
// }

// func NewSoldier(name string, id int, grade string) *Soldier {
// 	// 여러분이 작성할 코드가 여기에 ...

// 	// Solution03
// 	return &Soldier{name, id, grade}

// 	// Solution 02
// 	//var a = Soldier{name, id, grade}
// 	//return &a

// 	// Solution 01
// 	//ns := new(Soldier)
// 	//ns.Name = name
// 	//ns.Id = id
// 	//ns.Grade = grade
// 	//return ns
// }

// func main() {
// 	var s1 = NewSoldier("성윤모", 1234, "이병")
// 	var s2 = NewSoldier("박민석", 1221, "일병")

// 	fmt.Println(s2.Name)
// 	fmt.Println(s2.Id)

// 	fmt.Println(s1.Name)
// 	fmt.Println(s1.Grade)
// }

