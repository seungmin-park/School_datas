package main

import (
	"fmt"
)

/*
* 시험 점수 변환 배점:5점단위 100점 만점
* 100점 - A+, 95점 - AO,
* 90점 - B+, 85점 - BO,
* 80점 - C+, 75점 - CO,
* 70점 - D+, 65점 - DO,
65점 미만 - F
 */

type realScore map[string]string
type gradeScore map[string]string


//백분율 점수를 등급으로 변환
func (r *realScore) scoreTransform() {
	fmt.Println(*r)
	temp := *r
	for key, value := range temp {
		if value == "100" {
			temp[key] = "A+"
		} else if value == "95" {
			temp[key] = "AO"
		} else if value == "90" {
			temp[key] = "B+"
		}else if value == "85" {
			temp[key] = "BO"
		} else if value == "80" {
			temp[key] = "C+"
		}else if value == "75" {
			temp[key] = "CO"
		} else if value == "70" {
			temp[key] = "D+"
		} else if value == "65" {
			temp[key] = "DO"
		} else {
			temp[key] = "F"
		}
	}
}

//등급을 백분율 점수로 변환
func (g *gradeScore) scoreTransform() {
	fmt.Println(*g)
	temp := *g
	for key, value := range temp {
		if value == "A+" {
			temp[key] = "100"
		} else if value == "AO" {
			temp[key] = "95"
		} else if value == "B+" {
			temp[key] = "90"
		}else if value == "BO" {
			temp[key] = "85"
		} else if value == "C+" {
			temp[key] = "80"
		}else if value == "CO" {
			temp[key] = "75"
		} else if value == "D+" {
			temp[key] = "70"
		} else if value == "DO" {
			temp[key] = "65"
		} else {
			temp[key] = "64"
		}
	}
}

func main() {
	Rstudents := make(realScore)

	Rstudents["홍길동"] = "100"
	Rstudents["홍길순"] = "90"

	Gstudents := make(gradeScore)

	Gstudents["홍길동"] = "A+"
	Gstudents["홍길순"] = "BO"

	Rstudents.scoreTransform()
	for key, value := range Rstudents {
		fmt.Println("변경 후 -> ",key,value)
	}
	
	Gstudents.scoreTransform()
	for key, value := range Gstudents {
		fmt.Println("변경 후 -> ",key,value)
	}
}