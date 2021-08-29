package utils

// DarkRoast : Beverage
type DarkRoast struct {
	description string
	cost        float32
}

// NewDarkRoast : Constructor
func NewDarkRoast() Beverager {
	dr := DarkRoast{description: "Dark Roast", cost: 0.99}
	return &dr
}

func (dr *DarkRoast) Cost() float32 {
	return dr.cost
}

func (dr *DarkRoast) GetDescription() string {
	return dr.description
}
