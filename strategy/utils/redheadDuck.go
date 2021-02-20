package utils

import (
	"fmt"
)

// NewRedheadDuck : constructor
func NewRedheadDuck() IDuck {
	return &Duck{flyer: FlyWithWings{}, quacker: Quack{}}
}

// Display :
func (m *Duck) Display() {
	fmt.Println("I'm a real Red Headed duck")
}
