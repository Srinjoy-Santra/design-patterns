package utils

// SteamedMilk : Condiment
type SteamedMilk struct {
	beverage    Beverager
	description string
	cost        float32
}

// NewSteamedMilk : Constructor
func NewSteamedMilk(b Beverager) Beverager {
	s := SteamedMilk{b, "Steamed Milk", 0.10}
	return &s
}

func (s *SteamedMilk) Cost() float32 {
	return s.beverage.Cost() + s.cost
}

func (s *SteamedMilk) GetDescription() string {
	return s.beverage.GetDescription() + ", " + s.description
}
