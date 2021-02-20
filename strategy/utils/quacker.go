package utils

import (
	"fmt"
)

// Quacker : for quack beahvior
type Quacker interface {
	quack()
}

// Quack : Class for Quacking
type Quack struct {
}

func (q Quack) quack() {
	fmt.Println("quack")
}

// Squeak : Class for Squeaking
type Squeak struct {
}

func (s Squeak) quack() {
	fmt.Println("squeak")
}

// MuteQuack : Class for not Quacking
type MuteQuack struct {
}

func (m MuteQuack) quack() {
	fmt.Println("<< Silence >>")
}
