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

	donaldDuck := utils.Duck{}
	donaldDuck.Display()
	fmt.Printf("%#v\n", donaldDuck)

	donaldDuck.SetFlyer(utils.FlyNoWay{})
	donaldDuck.Quacker = utils.MuteQuack{}
	fmt.Printf("%#v\n", donaldDuck)
	donaldDuck.PerformQuack()

	fly := utils.FlyNoWay{NoOfWings: 2}         // I don't remember seeing him fly, despite having 2 wings.
	speak := utils.Speak{Speech: "Aw, phooey!"} // One of his catch phrases
	donaldDuck.SetFlyer(fly)
	donaldDuck.Quacker = speak
	fmt.Printf("%#v\n", donaldDuck)
	donaldDuck.PerformQuack()

}
