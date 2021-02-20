package main

import (
	"fmt"
	"strategy/utils"
)

func main() {
	mallardDuck := utils.NewMallardDuck()
	redheadDuck := utils.NewRedheadDuck()
	rubberDuck := utils.NewRubberDuck()
	decoyDuck := utils.NewDecoyDuck()

	ducks := [4]utils.IDuck{mallardDuck, redheadDuck, rubberDuck, decoyDuck}

	for _, duck := range ducks {
		fmt.Printf("\n%T\n", duck)
		duck.Display()
		duck.PerformFly()
		duck.PerformQuack()
		duck.Swim()
	}

}
