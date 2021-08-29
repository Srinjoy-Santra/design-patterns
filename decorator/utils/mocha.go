package utils

// Mocha : Condiment
type Mocha struct {
	beverage    Beverager
	description string
	cost        float32
}

// NewMocha : Constructor
func NewMocha(b Beverager) Beverager {
	m := Mocha{b, "Mocha", 0.20}
	return &m
}

func (m *Mocha) Cost() float32 {
	return m.beverage.Cost() + m.cost
}

func (m *Mocha) GetDescription() string {
	return m.beverage.GetDescription() + ", " + m.description
}
