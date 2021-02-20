package utils

import (
	"fmt"
)

// DecoyDuck : class
type DecoyDuck struct {
	Duck
}

// NewDecoyDuck : constructor
func NewDecoyDuck() IDuck {
	return &DecoyDuck{Duck{flyer: FlyNoWay{}, Quacker: MuteQuack{}}}
}

// Display :
func (m *DecoyDuck) Display() {
	fmt.Println("I'm a duck decoy")
}
