package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
	"strings"
)

func main() {
	scanner := bufio.NewScanner(os.Stdin)
	scanner.Scan()
	s := scanner.Text()
	var a []int
	for _, value := range strings.Split(s, " ") {
		x, _ := strconv.Atoi(value)
		a = append(a, x)
	}
	for i := 0; i < len(a)-1; i++ {
		imin := i
		for j := i + 1; j < len(a); j++ {
			if a[j] < a[imin] {
				imin = j
			}
		}
		if imin != i {
			a[i], a[imin] = a[imin], a[i]
		}
	}
	fmt.Println(a)
}
