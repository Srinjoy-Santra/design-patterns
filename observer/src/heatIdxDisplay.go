package src

import "fmt"

// HeatIdxDisplay : Forecast Display
type HeatIdxDisplay struct {
	heatIdx float32
	//weatherData  WeatherData
}

// NewHeatIdxDisplay : Constructor
func NewHeatIdxDisplay(wd WeatherData) Observer {
	hd := HeatIdxDisplay{}
	return &hd
}

func (hd *HeatIdxDisplay) display() {
	fmt.Printf("Heat index is %f\n", hd.heatIdx)
}

func (hd *HeatIdxDisplay) update(temperature float32, humidity float32, pressure float32) {
	hd.heatIdx = calculateHeatIndex(temperature, humidity)
	//d := hd.(Displayer) // invalid type assertion: hd.(Displayer) (non-interface type *HeatIdxDisplay on left)
	hd.display()
}

// UTILITY FUNCTION
func calculateHeatIndex(t float32, rh float32) float32 {
	return ((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh) +
		(0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) +
		(0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
		(0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
		(rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
		(0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
		0.000000000843296*(t*t*rh*rh*rh)) -
		(0.0000000000481975 * (t * t * t * rh * rh * rh)))
}
