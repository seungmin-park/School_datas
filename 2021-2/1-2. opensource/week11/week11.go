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
// 	fmt.Printf("수용량 : %d 길이 : %d\n", cap(aSlice), len(aSlice))
// 	aSlice = append(aSlice, -99)
// 	printSlice(aSlice)
// 	fmt.Printf("수용량 : %d 길이 : %d\n", cap(aSlice), len(aSlice))
// }

// package main

// import "fmt"

// func main() {
//    // var s1 []int
//    // s1 = make([]int, 5)

//    s1 := make([]int, 5)
//    reSlice := s1[1:3]

//    fmt.Println(s1)
//    fmt.Println(reSlice)

//    reSlice[0] = -100
//    reSlice[1] = 123456

//    fmt.Println(s1)
//    fmt.Println(reSlice)
// }

// package main

// import "fmt"

// func main() {
//    threeD := [2][2][2]int{{{1, 0}, {-2, 4}}, {{5, -1}, {7, 0}}}

//    for _, x := range threeD {
//       for _, y := range x {
//          for _, z := range y {
//             fmt.Print(z, " ")
//          }
//          fmt.Println()
//       }
//       fmt.Println()
//    }
// }

package main

import "fmt"

func main() {
   threeD := [2][2][2]int{{{1, 0}, {-2, 4}}, {{5, -1}, {7, 0}}}

   for i := 0; i < len(threeD); i++ {
      v := threeD[i]
      for j := 0; j < len(v); j++ {
         fmt.Print(v[j], " ")
      }
      fmt.Println()
   }
}

// package main

// import "fmt"

// func main() {
//    twoD := [4][4]int{{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}, {13, 14, 15, 16}}

//    for i := 0; i < len(twoD); i++ {
//       v := twoD[i]
//       for j := 0; j < len(v); j++ {
//          fmt.Print(v[j], " ")
//       }
//       fmt.Println()
//    }
// }

// package main

// import "fmt"

// func main() {
//    anArray := [4]int{1, 2, 4, -4}

//    for _, value := range anArray {
//       fmt.Print(value, " ")
//    }
// }