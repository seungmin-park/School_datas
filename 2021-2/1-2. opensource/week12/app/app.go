package main

import (
	"fmt"
	"log"
	"week12/calender"
)

func main() {
	date := calender.Date{}
	err := date.SetYear(2222)
	if err != nil {
		log.Fatal(err)
	}
	err = date.SetMonth(12)
	if err != nil {
		log.Fatal(err)
	}

	err = date.SetDay(30)
	if err != nil {
		log.Fatal(err)
	}
	fmt.Println(date)
	fmt.Println(date.GetYear())
	fmt.Println(date.GetMonth())
	fmt.Println(date.GetDay())
}

