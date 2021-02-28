package src

// Observer : common for all observers
type Observer interface {
	update(temperature float32, humidity float32, pressure float32)
}
