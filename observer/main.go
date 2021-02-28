package main

import (
	"observer/src"
)

func main() {

	wd := src.NewWeatherData()

	ccd := src.NewCurrCondDisplay(wd)
	wd.Register(ccd)
	sd := src.NewStatDisplay(wd)
	wd.Register(sd)
	fd := src.NewForecastDisplay(wd)
	wd.Register(fd)
	hd := src.NewHeatIdxDisplay(wd)
	wd.Register(hd)

	wd.SetMeasurements(80, 65, 30.4)
	wd.SetMeasurements(82, 70, 29.2)

	wd.Remove(hd)

	wd.SetMeasurements(78, 90, 29.2)

}
