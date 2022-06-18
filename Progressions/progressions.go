package main

import (
	"math"
)

type Progression interface {
	Nth(int) float64
	ToNth(int) []float64
	SumToNth(int) float64
}

type ArithmeticProgression struct {
	Start      float64
	Difference float64
}

func (ap ArithmeticProgression) Nth(n int) float64 {
	return ap.Start + float64(n-1)*ap.Difference
}

func (ap ArithmeticProgression) ToNth(n int) []float64 {
	a := []float64{ap.Start}
	for i := 1; i < n; i++ {
		a = append(a, a[len(a)-1]+ap.Difference)
	}
	return a
}

func (ap ArithmeticProgression) SumToNth(n int) float64 {
	return float64(n) * (ap.Start + ap.Nth(n)) / 2
}

type GeometricProgression struct {
	Start float64
	Ratio float64
}

func (gp GeometricProgression) Nth(n int) float64 {
	return gp.Start * math.Pow(gp.Ratio, float64(n-1))
}

func (gp GeometricProgression) ToNth(n int) []float64 {
	b := []float64{gp.Start}
	for i := 1; i < n; i++ {
		b = append(b, b[len(b)-1]*gp.Ratio)
	}
	return b
}

func (gp GeometricProgression) SumToNth(n int) float64 {
	if gp.Ratio == 1 {
		return float64(n) * gp.Start
	} else {
		return gp.Start*math.Pow(gp.Ratio, float64(n)) - 1/(gp.Ratio-1)
	}
}

type HarmonicProgression struct {
	Start      float64
	Difference float64
}

func (hp HarmonicProgression) Nth(n int) float64 {
	return math.Pow((math.Pow(hp.Start, -1) + float64(n-1)*hp.Difference), -1)
}

func (hp HarmonicProgression) ToNth(n int) []float64 {
	c := []float64{hp.Start}
	for i := 1; i < n; i++ {
		c = append(c, math.Pow((math.Pow(c[len(c)-1], -1)+float64(n-1)*hp.Difference), -1))
	}
	return c
}

func (hp HarmonicProgression) SumToNth(n int) float64 {
	sum := 0.0
	c := hp.ToNth(n)
	for _, i := range c {
		sum += i
	}
	return sum
}

func main() {
}
