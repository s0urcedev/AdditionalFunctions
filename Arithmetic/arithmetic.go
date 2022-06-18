package main

import (
	"strconv"
)

func AdditionBigNumbers(a string, b string) string {
	for len(b) < len(a) {
		b = "0" + b
	}
	for len(a) < len(b) {
		a = "0" + a
	}
	result := ""
	c := 0
	for i := len(a) - 1; i >= 0; i-- {
		localResult := int(a[i]-48) + int(b[i]-48) + c
		c = 0
		if localResult > 9 {
			localResult -= 10
			c = 1
		}
		result += strconv.Itoa(localResult)
	}
	if c == 1 {
		result += "1"
	}
	fresult := ""
	for _, s := range result {
		fresult = string(s) + fresult
	}
	return fresult
}

func SubtractionBigNumbers(a string, b string) string {
	k := false
	if len(a) < len(b) {
		a, b = b, a
		k = true
	}
	ai, _ := strconv.Atoi(a)
	bi, _ := strconv.Atoi(b)
	if ai < bi {
		a, b = b, a
		k = true
	}
	for len(b) < len(a) {
		b = "0" + b
	}
	for len(a) < len(b) {
		a = "0" + a
	}
	result := ""
	c := 0
	for i := len(a) - 1; i >= 0; i-- {
		localResult := int(a[i]-48) - int(b[i]-48) - c
		c = 0
		if localResult < 0 {
			localResult += 10
			c = 1
		}
		result += strconv.Itoa(localResult)
	}
	if c == 1 {
		result += "1"
	}
	for result[len(result)-1] == '0' {
		result = result[:len(result)-1]
	}
	fresult := ""
	for _, s := range result {
		fresult = string(s) + fresult
	}
	if k {
		fresult = "-" + fresult
	}
	return fresult
}

func MultiplicationBigNumbers(a string, b string) string {
	result := ""
	c := 0
	for i := len(b) - 1; i >= 0; i-- {
		localResult := ""
		c = 0
		for j := len(a) - 1; j >= 0; j-- {
			localLocalResult := int(a[j]-48)*int(b[i]-48) + c
			c = 0
			for localLocalResult > 9 {
				localLocalResult -= 10
				c++
			}
			localResult += strconv.Itoa(localLocalResult)
		}
		if c > 0 {
			localResult += strconv.Itoa(c)
			c = 0
		}
		flocalResult := ""
		for _, s := range localResult {
			flocalResult = string(s) + flocalResult
		}
		for f := 0; f < len(b)-i-1; f++ {
			flocalResult += "0"
		}
		result = AdditionBigNumbers(result, flocalResult)
	}
	return result
}

func main() {

}
