## Strategy Pattern

This is the second chapter of "Head First Design Patterns" book.

## The problem

We are told to design a weather monitoring application. It consists of 3 sections 
1. weather station : to record humidity, temperature and pressure
2. weather data : tracks data from the weather station and forwards it to the displays
3. various display elements : 
   1. current conditions,
   2. weather statistics,
   3. a simple forecast, and 
   4. a heat index calculator 

## Thought process
- Weather station should collect the data, and notify the changes to the various devices.
- In design terminology, the weather station is the subject, and the display devices are the observers.
- Weather station is the single owner of the data, devices are dependent on it for any updates.
- The common analogy often used here is that of publisher-consumer models. Suppose you want to avail a newspaper subscription. Once you register for it, you get a daily copy. But the moment, your subscription ends, you no longer receive it.
- For our use-case, a loosely coupled system provided by the Observer Pattern, will greatly benefit us.
- The station is responsible in sending the collected data, it should not be bothered about how the observing devices use it.
- Suppose a better index (e.g. WBGT) comes up and heat index provides less valuable insight, we should be able to freely add the new device, and remove the heat index device.
- We would not want to modify the code for the subject, when a the new observer (WBGT device) comes in.
- Changes to either the subject or the observer should have no impact on each other.
- Similarly, both should be reusable and independent to each other.

## UML Class Diagram

![Class Diagram](https://i.stack.imgur.com/BxXQU.png)

In the code, few renaming has taken place.
- CurrentConditions -> CurrCondDisplay
- StatisticsDisplay -> StatDisplay

## Takeaways

The book defines, 

> The Observer Pattern defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically.

Some interesting design principles arise
 1. Identify the aspects of your application that vary and separate them out from what stays the same.
 2. Program to an interface, not an implementation.
 3. Favour composition over inheritance.
 4. Strive for loosely coupled designs between objects that interact.

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


