package main

import (
	"decorator/utils"
	"fmt"
)

func main() {
	es := utils.NewEspresso() // can be assigned to a Beverager instance too
	print(es)

	var b utils.Beverager
	b = utils.NewDarkRoast()
	b = utils.NewMocha(b)
	b = utils.NewMocha(b)
	b = utils.NewWhip(b)
	print(b)

	hbmw := utils.NewWhip(
		utils.NewMocha(
			utils.NewSoy(
				utils.NewHouseBlend(),
			),
		),
	)
	print(hbmw)
}

func print(b utils.Beverager) {
	fmt.Println(b.GetDescription(), "= \u20b9", b.Cost())
}
