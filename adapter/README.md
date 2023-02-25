# Adapter Pattern

This is the seventh chapter of "Head First Design Patterns" book.

## The problem

Accidentally a Turkey's egg falls among that of Ducks and it tries hard to "adapt" with its duck siblings. How should it adapt?

Simplifying the huge list of behavourial changes the Turkey needs to undergo to two.
1. [Mallard Duck](https://en.wikipedia.org/wiki/Mallard): 
   - It can fly.
   - It makes a quack sound.

2. [Wild Turkey](https://en.wikipedia.org/wiki/Wild_turkey): 
   - It can fly but for shorter distances
   - It makes a gobble sound.

## Thought process

- We need to create a new implementation such that it emulates the behaviour of a Duck but uses underlying behaviour of the Turkey itself.

## UML Class Diagram

![Class Diagram](https://pic002.cnblogs.com/images/2012/358984/2012042415500298.png)
You can think the `Client` as the mother (matriarch) which tries to teach the ways of duck (`Target` interface) to the turkey `Adapter` on top of its true self `Adaptee`.

## Takeaways

The book defines, 

> The Adapter Pattern converts the interface of a class into another interface the clients expect. Adapter lets class work together that couldn't otherwise because of incompatible interfaces.

## Language specifics

- Since there's no concept of multiple inheritance in C#, we are using object adapters. 

## Output

```
The Turkey says...
Gobble gobble
I'm flying a short distance

The Duck says...
Quack
I'm flying

The TurkeyAdapter says...
Gobble gobble
I'm flying a short distance
I'm flying a short distance
I'm flying a short distance
```


# Pop culture analogies

One interesting analogy can be that of ugly duckling here!
![Ugly duckling](https://th.bing.com/th/id/R.5695d9b7ebff9cbbde5eb126d05ab50f?rik=%2bNEOZKq25JW6QQ&riu=http%3a%2f%2f1.bp.blogspot.com%2f-PZ0fQ4O-NCY%2fTjF9TikuNzI%2fAAAAAAAAABY%2fNnDpU0nGVhA%2fs1600%2fUgly%2bDuckling%2bpage%2b1%2bartwork%2bonly%2b%252528Large%252529.jpg&ehk=bm5eqyq5bMABOCPpXhrldZU5eHM6iY0zoGUD55aZx9k%3d&risl=&pid=ImgRaw&r=0)

Standardized test making everyone of different abilities to pass the same test.
![Standardized test](https://img.ifunny.co/images/30a8c0524d8cabfe81657b8c2912e33eb7295092f4d4271ea8c4eb69988d7b4a_1.webp)

