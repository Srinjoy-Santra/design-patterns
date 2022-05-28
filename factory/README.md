# Factory Pattern

This is the fourth chapter of "Head First Design Patterns" book.

## The problem



## Thought process
- 
## UML Class Diagram

```mermaid
classDiagram
      BiryaniStore <|-- KolkataBiryaniStore
      BiryaniStore <|-- HyderabadBiryaniStore
      BiryaniStore: #Biryani CreateBiryani()*
      class KolkataBiryaniStore{
          #Biryani createBiryani()
      }
      class HyderabadBiryaniStore{
          #Biryani createBiryani()
      }
      class Biryani{
          +string Name
          #string Rice
          #string Item
          #List~string~ Ingredients
          +Prepare()
          +Simmer()
          +Churn()
          +Serve()
      }
      Biryani <|-- KolkataStyleVegetarianBiryani
      Biryani <|-- KolkataStyleChickenBiryani
      Biryani <|-- KolkataStyleMuttonBiryani
      Biryani <|-- HyderabadStyleVegetarianBiryani
      Biryani <|-- HyderabadStyleChickenBiryani
      Biryani <|-- HyderabadStyleMuttonBiryani
      KolkataBiryaniStore ..|> KolkataStyleVegetarianBiryani
      KolkataBiryaniStore ..|> KolkataStyleChickenBiryani
      KolkataBiryaniStore ..|> KolktaStyleMuttonBiryani
      HyderabadBiryaniStore ..|> HyderabadStyleVegetarianBiryani
      HyderabadBiryaniStore ..|> HyderabadStyleChickenBiryani
      HyderabadBiryaniStore ..|> HyderabadStyleMuttonBiryani


```

## Takeaways

The book defines, 

> 


 1. 
 2. 
 3. 
 4. 

## Language specifics

Note: Go channels which are idiomatic way of handling data in concurrent code (routines) can be applicable to this use-case. Perhaps, I'll cover that in another article.

I found two ways of handling multiple inheritance.
1. Composition of smaller interfaces to make a single interface.
```
type displayerObserver interface {
	Displayer
	Observer
}
```
2. Type assertion of structs.
```
...
func (sd *StatDisplay) update(temp float32, humidity float32, pressure float32) {
   ...
   var d Displayer = sd
   d.display()
   ...
}
// check statDisplay.go file for more detail
```

## Output

```
Current conditions: 80.0F degrees and 65.0% humidity.
Avg/Max/Min temperature = 80.0/80.0/80.0
Forecast : Improving weather on the way!
Heat index is 82.955345
Current conditions: 82.0F degrees and 70.0% humidity.
Avg/Max/Min temperature = 81.0/82.0/80.0
Forecast : Watch out for cooler, rainy weather!
Heat index is 86.901260
Current conditions: 78.0F degrees and 90.0% humidity.
Avg/Max/Min temperature = 80.0/82.0/78.0
Forecast : More of the same.
```


