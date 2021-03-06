package src

// Displayer :
type Displayer interface {
	display()
}

// One way of achieving multiple inheritance
type displayerObserver interface {
	Displayer
	Observer
}
