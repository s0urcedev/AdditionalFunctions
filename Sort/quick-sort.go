package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
	"strings"
)

func Sort(array []int, b int, e int) {
	l := b
	r := e
	p := array[int((l+r)/2)]
	for l <= r {
		for array[l] < p {
			l++
		}
		for array[r] > p {
			r--
		}
		if l <= r {
			if l < r {
				array[l], array[r] = array[r], array[l]
			}
		}
		l++
		r--
	}
	if b < r {
		Sort(array, b, r)
	}
	if e > l {
		Sort(array, l, e)
	}
}

func main() {
	scanner := bufio.NewScanner(os.Stdin)
	scanner.Scan()
	s := scanner.Text()
	var a []int
	for _, value := range strings.Split(s, " ") {
		x, _ := strconv.Atoi(value)
		a = append(a, x)
	}
	Sort(a, 0, len(a)-1)
	fmt.Println(a)
}
