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
	return &DecoyDuck{Duck{flyer: FlyNoWay{}, quacker: MuteQuack{}}}
}

// Display :
func (m *DecoyDuck) Display() {
	fmt.Println("I'm a duck decoy")
}
