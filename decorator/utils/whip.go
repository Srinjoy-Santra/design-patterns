package utils

// Whip : Condiment
type Whip struct {
	beverage    Beverager
	description string
	cost        float32
}

// NewWhip : Constructor
func NewWhip(b Beverager) Beverager {
	m := Whip{b, "Whip", 0.10}
	return &m
}

func (w *Whip) Cost() float32 {
	return w.beverage.Cost() + w.cost
}

func (w *Whip) GetDescription() string {
	return w.beverage.GetDescription() + ", " + w.description
}
