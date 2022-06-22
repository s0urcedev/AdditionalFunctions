package main

import (
	"bufio"
	"fmt"
	"math"
	"os"
	"strconv"
	"strings"
)

func Heapify(array []int, n int, i int) {
	largest := i
	l := 2*i + 1
	r := 2*i + 2
	if l < n && array[i] < array[l] {
		largest = l
	}
	if r < n && array[largest] < array[r] {
		largest = r
	}
	if largest != i {
		array[i], array[largest] = array[largest], array[i]
		Heapify(array, n, largest)
	}
}

func Sort(array []int) {
	for i := int(math.Floor(float64(len(array) / 2))); i > -1; i-- {
		Heapify(array, len(array), i)
	}
	for j := len(array) - 1; j > 0; j-- {
		array[j], array[0] = array[0], array[j]
		Heapify(array, j, 0)
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
	Sort(a)
	fmt.Println(a)
}
