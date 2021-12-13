package main

import (
	"fmt"
	"week11/calendar"
	"log"
)

func main() {
	//date := calendar.Date{Year: 2021, Month: 11, Day: 15}
	date := calendar.Date{}
	fmt.Println(date)

	err := date.SetYear(2022)
	if err != nil {
		log.Fatal(err)
	}
	err = date.SetMonth(11)
	if err != nil {
		log.Fatal(err)
	}
	err = date.SetDay(15)
	if err != nil {
		log.Fatal(err)
	}
	// date.Month = 13
	// date.Day = 33
	fmt.Println(date)
	//fmt.Println(date.day)
	fmt.Println(date.GetDay())
}
