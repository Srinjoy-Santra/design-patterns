package utils

import (
	"fmt"
)

// IDuck : Duck interface
type IDuck interface {
	Display()
	PerformFly()
	PerformQuack()
	Swim()
}

// Duck :
type Duck struct {
	flyer   Flyer
	quacker Quacker
}

// PerformFly : allow fly
func (d *Duck) PerformFly() {
	d.flyer.fly()
}

// PerformQuack : allow quack
func (d *Duck) PerformQuack() {
	d.quacker.quack()
}

// Swim :
func (d *Duck) Swim() {
	fmt.Println("All ducks float, even decoys!")
}
