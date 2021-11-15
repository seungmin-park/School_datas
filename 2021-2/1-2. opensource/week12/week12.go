package main

import (
	"errors"
	"fmt"
	"log"
)

type Date struct {
	Year int
	Month int
	Day int
}

func (d *Date) setYear(year int) error {
	if year < 1 {
		return errors.New("유효하지 않은 년도 입니다.")
	}
	d.Year = year
	return nil
}

func (d *Date) setMonth(month int) error {
	if month < 1 || month > 12 {
		return errors.New("유효하지 않은 월 입니다.")
	}
	d.Month = month
	return nil
}

func (d *Date) setDay(day int) error {
	if day < 1 || day > 31{
		return errors.New("유효하지 않은 일 입니다.")
	}
	d.Day = day
	return nil
}

func main() {
	date := Date{Year: 2021,Month: 11,Day: 15}

	fmt.Println(date)

	date.Year = -500
	err := date.setYear(2022)
	if err != nil {
		log.Fatal(err)
	}

	err = date.setMonth(13)
	if err != nil {
		log.Fatal(err)
	}
	err = date.setDay(20)
	if err != nil {
		log.Fatal(err)
	}
	fmt.Println(date)
}
