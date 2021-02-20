# Strategy Pattern

This is the first chapter of "Head First Design Patterns" book.

## The problem

We are told to design a duck pond simulation where different species of ducks exist. They can have a variety of swimming styles and sounds.

Requirements keep on changing, but finally we have four types of ducks.

1. [Mallard Duck](https://en.wikipedia.org/wiki/Mallard): 
   - Which is actually a kind of duck species.
   - It can fly.
   - It makes a quack sound.
   - It can float.
2. [Redhead Duck](https://en.wikipedia.org/wiki/Redhead_(bird)): 
   - Which is actually a kind of duck species.
   - It can fly.
   - It makes a quack sound.
   - It can float.
3. **Rubber Duck**: 
   - Which is the kind of yellow rubber ducks we use/see in bathrooms!
   - It can NOT fly.
   - It makes a squeaking sound.
   - It can float.
4. **Decoy Duck**: 
   - Which is the kind of wooden ducks showcased in your living rooms!
   - It can NOT fly.
   - It does NOT make any sound.
   - It can float.

## Thought process

- Our initial instinct is to make a class of Duck, which has the functions of fly, quack and swim.
- Subclasses Mallard, Redhead, Rubber and Decoy can inherit the behaviours from Duck.
- Rubber and Decoy Ducks will override the default fly and quack behaviours to do nothing. Which do not make much sense!
- We change our approach to have Flyable and Quackable interfaces, which the individual subclasses may choose to use.
- We can implement the behaviours, inside the respective classes, but that will lead to repetition of behaviour. e.g. Both Rubber and Decoy ducks cannot fly. So, it is better to have a FlyWithWings class (for Mallard and Redhead) and FlyNoWay (for Rubber and Decoy) implement the Flyable interface.
- Similarly, for Quackable we make classes based on behaviours.
- The final solution (shown in UML) can appear over-engineered for the simple use case but helps a lot in flexibility for more bigger applications.
- To enable switching behaviours at run-time (*dynamic dispatch*), we add two setters setQuacker and setFlyer to the Duck class. 
- A new type of Duck is introduced whose flight is powered by a rocket.
- I took creative liberty, to instead have **Donald Duck** the cartoon character. As far as I remember he can't fly depsite having 2 wings (hands?). He mutters "Aw, phooey!", in his quintessential tone,

## UML Class Diagram

![Class Diagram](https://i.stack.imgur.com/fPXch.png)
FlyBehaviour has been renamed to Flyer; likewise for QuackBehaviour.

## Takeaways

The book defines, 

> The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

- This pattern "Favours composition over inheritance" which is in alignment with golang's philosophy (inheritance is not supported).
- Some interesting design principles arise
 1. Identify the aspects of your application that vary and separate them from what stays the same.
 2. Program to an interface, not an implementation.


## Language specifics

Golang is not a object-oriented programming language. However, we can use the language constructs to implement strategy pattern and can benefit from it.

There is no concept of class. A `struct` can have fields (data members). Interface can declare functions which need to be implemented by the struct.

[Setter is NOT considered an idiomatic Go approach](https://softwareengineering.stackexchange.com/a/278830).
In the code I have shown use of both a setter and a direct member access of a public field.




