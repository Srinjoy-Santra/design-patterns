package utils

// Soy : Condiment
type Soy struct {
	beverage    Beverager
	description string
	cost        float32
}

// NewSoy : Constructor
func NewSoy(b Beverager) Beverager {
	s := Soy{b, "Soy", 0.15}
	return &s
}

func (s *Soy) Cost() float32 {
	return s.beverage.Cost() + s.cost
}

func (s *Soy) GetDescription() string {
	return s.beverage.GetDescription() + ", " + s.description
}
