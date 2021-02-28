package src

import (
	"fmt"
)

// CurrCondDisplay : Current Conditions Display
type CurrCondDisplay struct {
	temperature float32
	humidity    float32
	//weatherData WeatherData
}

// NewCurrCondDisplay : Constructor
func NewCurrCondDisplay(wd WeatherData) Observer {
	ccd := CurrCondDisplay{}
	return &ccd
}

func (ccd *CurrCondDisplay) update(temperature float32, humidity float32, pressure float32) {
	ccd.temperature = temperature
	ccd.humidity = humidity
	ccd.display()
}

func (ccd *CurrCondDisplay) display() {
	fmt.Printf("Current conditions: %0.1fF degrees and %0.1f%% humidity.\n", ccd.temperature, ccd.humidity)
}
