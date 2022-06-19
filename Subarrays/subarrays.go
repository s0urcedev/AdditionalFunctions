package main

func maxSubarraySum(arr []int) int {
	result := arr[0]
	localResult := arr[0]
	for i := 1; i < len(arr); i++ {
		if localResult > 0 {
			localResult += arr[i]
		} else {
			localResult = arr[i]
		}
		if localResult > result {
			result = localResult
		}
	}
	return result
}

func minSubarraySum(arr []int) int {
	result := arr[0]
	localResult := arr[0]
	for i := 1; i < len(arr); i++ {
		if localResult < 0 {
			localResult += arr[i]
		} else {
			localResult = arr[i]
		}
		if localResult < result {
			result = localResult
		}
	}
	return result
}

func maxSubarrayProd(arr []int) int {
	result := arr[0]
	localResultPos := arr[0]
	localResultNeg := arr[0]
	for i := 1; i < len(arr); i++ {
		var localResultMax, localResultMin int
		if localResultPos*arr[i] > localResultNeg*arr[i] {
			localResultMax = localResultPos * arr[i]
			localResultMin = localResultNeg * arr[i]
		} else {
			localResultMax = localResultNeg * arr[i]
			localResultMin = localResultPos * arr[i]
		}
		if arr[i] > localResultMax {
			localResultPos = arr[i]
		} else {
			localResultPos = localResultMax
		}
		if arr[i] < localResultMin {
			localResultNeg = arr[i]
		} else {
			localResultNeg = localResultMin
		}
		if localResultPos > result {
			result = localResultPos
		}
	}
	return result
}

func minSubarrayProd(arr []int) int {
	result := arr[0]
	localResultPos := arr[0]
	localResultNeg := arr[0]
	for i := 1; i < len(arr); i++ {
		var localResultMax, localResultMin int
		if localResultPos*arr[i] > localResultNeg*arr[i] {
			localResultMax = localResultPos * arr[i]
			localResultMin = localResultNeg * arr[i]
		} else {
			localResultMax = localResultNeg * arr[i]
			localResultMin = localResultPos * arr[i]
		}
		if arr[i] > localResultMax {
			localResultPos = arr[i]
		} else {
			localResultPos = localResultMax
		}
		if arr[i] < localResultMin {
			localResultNeg = arr[i]
		} else {
			localResultNeg = localResultMin
		}
		if localResultNeg < result {
			result = localResultNeg
		}
	}
	return result
}

func maxCircularSubarraySum(arr []int) int {
	maxElem := arr[0]
	arrSum := 0
	for i := 0; i < len(arr); i++ {
		if arr[i] > maxElem {
			maxElem = arr[i]
		}
		arrSum += arr[i]
	}
	if maxElem < 0 {
		return maxElem
	}
	maxSimpleSum := maxSubarraySum(arr)
	maxCircleSum := arrSum - minSubarraySum(arr)
	if maxSimpleSum > maxCircleSum {
		return maxSimpleSum
	} else {
		return maxCircleSum
	}
}

func minCircularSubarraySum(arr []int) int {
	minElem := arr[0]
	arrSum := 0
	for i := 0; i < len(arr); i++ {
		if arr[i] < minElem {
			minElem = arr[i]
		}
		arrSum += arr[i]
	}
	if minElem > 0 {
		return minElem
	}
	minSimpleSum := minSubarraySum(arr)
	minCircleSum := arrSum - minSubarraySum(arr)
	if minSimpleSum < minCircleSum {
		return minSimpleSum
	} else {
		return minCircleSum
	}
}

func main() {

}
