# Inheritance
School assignment in inheritance

# About the task:

In this task, you will practice using inheritance in object-oriented programming. The task involves thinking about a structure for inheritance and implementing it in code.

# What you need to do:

Imagine that you are creating the foundation for a program that manages animals in a zoo.

- [ ] There should be a base class named `Animal`.
    - [ ] The class should have at least five properties that all animals share.
    - [ ] The class should also have at least three methods that all animals share.
- [ ] Create at least three different animals that inherit from the `Animal` class.
    - [ ] These animals should implement at least one new property each and at least one new method each.
    - [ ] These animals should also have default values for the properties, both those set in the class and those set in the base class.
    - [ ] All animals must have a method named `MakeSound()` that writes the animal's sound to the console.
    - [ ] There should be a constructor that can be used to create new animals.
- [ ] Choose one of the animals you created above and then divide it into two new classes that inherit from that animal.
    - [ ] For example, you might have a dog, so you can create Bulldog and Chihuahua classes. The result will be two levels of inheritance.
    - [ ] These animal variants should also implement some unique properties and methods, or at least an override that makes them unique.
- [ ] In your `Main` method, initialize several different animals and ensure that they make their sounds so that it is visible in the console that the animals have made sounds.
