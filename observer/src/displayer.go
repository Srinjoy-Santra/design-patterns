package src

// Displayer :
type Displayer interface {
	display()
}

type displayerObserver interface {
	Displayer
	Observer
}
