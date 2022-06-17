package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
	"strings"
)

func Sort(array []int, m int) {
	mass := []int{}
	for i := 0; i < m; i++ {
		mass = append(mass, array[i])
	}
	if m <= 1 {
		array[0] = mass[0]
	} else {
		var l []int
		var r []int
		for i := 0; i < m; i++ {
			if i < m/2 {
				l = append(l, mass[i])
			} else {
				r = append(r, mass[i])
			}
		}
		Sort(l, m/2)
		Sort(r, m-(m/2))
		h := 0
		f := 0
		var c []int
		for h < m/2 && f < m-(m/2) {
			if l[h] < r[f] {
				c = append(c, l[h])
				h++
			} else {
				c = append(c, r[f])
				f++
			}
		}
		for h < m/2 {
			c = append(c, l[h])
			h++
		}
		for f < m-(m/2) {
			c = append(c, r[f])
			f++
		}
		for i := 0; i < m; i++ {
			array[i] = c[i]
		}
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
	Sort(a, len(a))
	fmt.Println(a)
}
