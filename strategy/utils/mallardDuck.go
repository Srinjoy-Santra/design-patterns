package utils

import (
	"fmt"
)

// MallardDuck : class
type MallardDuck struct {
	Duck
}

// NewMallardDuck : constructor
func NewMallardDuck() IDuck {
	return &MallardDuck{Duck{flyer: FlyWithWings{}, quacker: Quack{}}}
}

// Display :
func (m *MallardDuck) Display() {
	fmt.Println("I'm a real Mallard duck")
}
