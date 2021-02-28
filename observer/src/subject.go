package src

// Subject :
type Subject interface {
	Register(ob Observer)
	Remove(ob Observer)
	notifyAll()
}

// WeatherData :
type WeatherData struct {
	observers   []Observer
	temperature float32
	humidity    float32
	pressure    float32
}

// NewWeatherData : Constructor
func NewWeatherData() WeatherData {
	wd := WeatherData{}
	return wd
}

// Register : When an observer registers, we append it to the observers array
func (w *WeatherData) Register(ob Observer) {
	w.observers = append(w.observers, ob)
}

// Remove : When an observer unregisters, we remove it from the observers array
func (w *WeatherData) Remove(ob Observer) {
	i := search(&w.observers, ob)
	w.observers = remove(w.observers, i)
}

// notifyAll : We tell all the observers about state
func (w *WeatherData) notifyAll() {
	for _, observer := range w.observers {
		observer.update(w.temperature, w.humidity, w.pressure)
	}
}

// we notify observers when we get updated measurements from the weather station
func (w *WeatherData) measurementChanged() {
	w.notifyAll()
}

// SetMeasurements :
func (w *WeatherData) SetMeasurements(temperature float32, humidity float32, pressure float32) {
	w.temperature = temperature
	w.humidity = humidity
	w.pressure = pressure
	w.measurementChanged()
}

// UTILITY FUNCTIONS
// Order is not important
// https://stackoverflow.com/questions/37334119/how-to-delete-an-element-from-a-slice-in-golang
func remove(obs []Observer, i int) []Observer {
	obs[len(obs)-1], obs[i] = obs[i], obs[len(obs)-1]
	return obs[:len(obs)-1]
}
func search(obs *[]Observer, key Observer) int {
	for id, ob := range *obs {
		if ob == key {
			return id
		}
	}
	// Case of finding non-exisiting observer very rare
	return -1
}
