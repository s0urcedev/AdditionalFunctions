package main

func Factorial(n int) int {
	if n == 0 {
		return 1
	} else {
		return n * Factorial(n-1)
	}
}

func CountCombinations(n int, k int) int {
	return Factorial(n) / (Factorial(k) * Factorial(n-k))
}

func CountPermutations(n int, k int) int {
	return Factorial(n) / Factorial(n-k)
}

func GenerateCombinations(arr []int, k int) [][]int {
	result := [][]int{}
	for i := 0; i < CountCombinations(len(arr), k); i++ {
		localResult := []int{0}
		n := len(arr)
		s := 0
		for j := 1; j <= k; j++ {
			t := localResult[j-1] + 1
			for (t < (n - k + j)) && (s+CountCombinations(n-t, k-j) <= i) {
				s += CountCombinations(n-t, k-j)
				t++
			}
			localResult = append(localResult, t)
		}
		for l := 1; l < len(localResult); l++ {
			localResult[l] = arr[localResult[l]-1]
		}
		result = append(result, localResult[1:])
	}
	return result
}

func GeneratePermutations(arr []int, k int) [][]int {
	result := [][]int{}
	m := GenerateCombinations(arr, k)
	for _, a := range m {
		localResult := [][]int{}
		for i := 0; i < Factorial(len(a)); i++ {
			ind := i + 1
			localLocalResult := []int{}
			localLocalArr := []int{}
			for _, r := range a {
				localLocalArr = append(localLocalArr, r)
			}
			n := len(localLocalArr)
			for j := 1; j <= n; j++ {
				f := Factorial(n - j)
				g := (ind + f - 1) / f
				localLocalResult = append(localLocalResult, localLocalArr[g-1])
				localLocalArr = append(localLocalArr[:g-1], localLocalArr[g:]...)
				ind -= (g - 1) * f
			}
			if len(localLocalArr) > 0 {
				localLocalResult = append(localLocalResult, localLocalArr[0])
			}
			localResult = append(localResult, localLocalResult)
		}
		for _, u := range localResult {
			result = append(result, u)
		}
	}
	return result
}

func main() {

}
