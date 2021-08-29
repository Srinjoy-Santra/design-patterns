package utils

// Decaf : Beverage
type Decaf struct {
	description string
	cost        float32
}

// NewDecaf : Constructor
func NewDecaf() Beverager {
	d := Decaf{"Decaf", 1.05}
	return &d
}

func (d *Decaf) Cost() float32 {
	return d.cost
}

func (d *Decaf) GetDescription() string {
	return d.description
}
