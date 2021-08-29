package utils

// Espresso : Beverage
type Espresso struct {
	description string
	cost        float32
}

// NewEspresso : Constructor
func NewEspresso() Beverager {
	e := Espresso{"Espresso", 1.99}
	return &e
}

func (e *Espresso) Cost() float32 {
	return e.cost
}

func (e *Espresso) GetDescription() string {
	return e.description
}
