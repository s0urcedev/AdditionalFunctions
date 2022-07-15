package main

import (
	"math"
)

func IsPrime(n int) bool {
	result := []int{}
	d := 2
	for d*d <= n {
		if n%d == 0 {
			result = append(result, d)
			n = int(n / d)
		} else {
			d++
		}
	}
	if n > 1 {
		result = append(result, n)
	}
	if len(result) > 1 {
		return false
	} else {
		return true
	}
}

func NearestPrime(n int) int {
	if n%2 == 0 {
		n += 1
	}
	for !IsPrime(n) {
		n += 2
	}
	return n
}

type HashTable[T any] struct {
	Size  int
	Table []T
}

func NewHashTable[T any](size int) HashTable[T] {
	sz := NearestPrime(size)
	table := []T{}
	var def T
	for i := 0; i < size; i++ {
		table = append(table, def)
	}
	ht := HashTable[T]{sz, table}
	return ht
}

func (ht HashTable[T]) CountHash(s string) int {
	n := 7
	for i := 0; i < len(s); i++ {
		n = n*31 + int(s[i])
	}
	return int(float64(ht.Size) * (float64(n)*((math.Sqrt(5)-1)/2) - math.Floor(float64(n)*((math.Sqrt(5)-1)/2))))
}

func (ht HashTable[T]) Search(key string) T {
	return ht.Table[ht.CountHash(key)]
}

func (ht HashTable[T]) Insert(key string, value T) {
	ht.Table[ht.CountHash(key)] = value
}

func (ht HashTable[T]) Remove(key string) {
	var def T
	ht.Table[ht.CountHash(key)] = def
}

func main() {
}
