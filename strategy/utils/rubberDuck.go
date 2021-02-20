package utils

import (
	"fmt"
)

// RubberDuck : class
type RubberDuck struct {
	Duck
}

// NewRubberDuck : constructor
func NewRubberDuck() IDuck {
	return &RubberDuck{Duck{flyer: FlyNoWay{}, Quacker: Squeak{}}}
}

// Display :
func (m *RubberDuck) Display() {
	fmt.Println("I'm a rubber duckie")
}
