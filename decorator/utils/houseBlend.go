package utils

// HouseBlend : Beverage
type HouseBlend struct {
	description string
	cost        float32
}

// NewHouseBlend : Constructor
func NewHouseBlend() Beverager {
	hb := HouseBlend{"House Blend", 0.89}
	return &hb
}

func (hb *HouseBlend) Cost() float32 {
	return hb.cost
}

func (hb *HouseBlend) GetDescription() string {
	return hb.description
}
