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
	k := 0
	for k < len(a)-1 {
		k = 0
		for j := 0; j < len(a)-1; j++ {
			if a[j] > a[j+1] {
				a[j], a[j+1] = a[j+1], a[j]
			} else {
				k++
			}
		}
	}
	fmt.Println(a)
}
