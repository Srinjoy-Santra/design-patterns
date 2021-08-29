# Strategy Pattern

This is the third chapter of "Head First Design Patterns" book.

## The problem

We are told to design a ordering application at a coffee shop. 
It sells a variety of beverages like
- House Blend
- Dark Roast
- Decaf
- Espresso

Apart from these the customer has the choice to have condiments (basically add-ons) like
- steamed milk
- soy
- mocha
- whipped milk

Later we see prices differ for each beverage with the size of cups ordered.


## Thought process

### Approach 1
- What a noob coder like me would do is make an abstraction of `Beverage`, and derive concrete implementations of HouseBlend, Dark Roast, and so forth.
- The problem arises with the add-ons, using the above approach we are spoiled with choices and our implementations become
  -  HouseBlend with steamed milk and mocha
  -  Dark Roast with whip and soy
- Just imagine the number of possiblities,
  - \#(Beverage) X \#(condiments) X \#(other condiments or not)
  - 4 * 4 * 4 = 64 ; that's simply explosion of classes 

### Approach 2
- We maintain boolean properties of every add-ons for the `Beverage` abstraction. If customer insists on adding one of these the respective boolean will be set to truthy value.
- We have getters and setters for each of those properties.
- Number of implementations now is 4, and 1 abstraction.
- This reduces our implementations significantly, but we see some issues.
  - If things like price and number of add-ons change, we will need to rewrite the implementations.
  - A new beverage like iced tea can't be enjoyed with whip. But it will have the setter and getter for the same.

### Approach 3
- Here we make use of the decorator pattern.
- The idea here is to keep on adding things as the customer wishes.
- Suppose the customer orders "double mocha soy latte with whip" with espresso.\*
- We create espresso first, then keep putting our add-ons in any order. For example,
  - Mocha
  - Soy Latte
  - Mocha
  - Whip
- Cost function is incremented at each step with the power of polymorphism.

\* I am not sure how will that taste in real life. :sweat_smile_face:
## UML Class Diagram

![Class Diagram](https://i.stack.imgur.com/ctCkm.png)

## Takeaways

The book defines, 

> The Decorator Pattern attaches additional responsibilities to an object dynamically.Decorators provide a flexible alternative to subclassing for extending functionality.

Decorators make our code openly extensible but closed for modification.

In simpler terms, we can add new condiments (decorators) without touching the code of existing beverages or condiments. 

## Language specifics

Go doesn't have inheritance which saves us from some cognitive load.

We simply make an interface `Beverager` which is implemented by the structs of beverages or condiments.

```go
package utils

type Beverager interface {
	Cost() float32
	GetDescription() string
}
```

The implementation for Whip, a condiment.
```go
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
```

The implementation of a beverage like `DarkRoast` differ from condiments by the fact
- it does NOT accept another beverage on its creation(which makes sense, we should not mix DarkRoast with Espresso!)

![Decorator Diagram](https://i.stack.imgur.com/AaQQY.png)

One thing to note in decorator pattern is that the order does not matter while adding condiments. In tha above diagram we could have wrapped the `DarkRoast` with `Mocha` followed by `Whip`.

## Output

```go
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
```

The above code prints

```shell
Espresso = ₹ 1.99
Dark Roast, Mocha, Mocha, Whip = ₹ 1.4900001
House Blend, Soy, Mocha, Whip = ₹ 1.34
```


