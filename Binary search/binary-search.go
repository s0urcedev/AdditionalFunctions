package main

import "math"

func BinarySearch(arr []int, value int) int {
	first := 0
	last := len(arr) - 1
	var middle int
	for first <= last {
		middle = int(math.Floor((float64(first) + float64(last)) / 2))
		if value < arr[middle] {
			last = middle - 1
		} else if value > arr[middle] {
			first = middle + 1
		} else {
			return middle
		}
	}
	return -1
}

func main() {

}
