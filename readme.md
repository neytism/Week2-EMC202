GAME PROGRAMMING 2
WEEK 2 ACTIVITY

INSTRUCTIONS

Create your own character class manager system with the following requirements:

- Create a readme.md file in your repository to describe the 3 classes and what they do . e.g. DPS, Tank, Support
- Create a base class that applies to all classes
- The 3 classes must inherit from base class
- Identify 3 functions all the base class can have
- Have 3 public properties on the base class with set computation.
- 3 private properties which derive their value by initializing in the constructor.
- The override functions must do different things based on the stat they have
- make use of overloads or labeling your functions and adding default values if need be.

I mainly made 5 different classes
    - Character Manager class
        Character Manager class is used on the Character Manager object on unity, it takes an array of Characters and Run specific function per Character object
    - Character class
        Character class are used to create properties and functions to be inherited by other classes. It contains name, health, max health, attack damage, experience, level, crit rate, and crit damage.
        It also includes functions such as Simulating the character, Introducing the character with its basic informations, Normal attack, using skill, buffing character
    - DPS class
        DPS character has properties that focuses on attacking.
    - Support class
        Support Character has properties that focuses on buffing the character.
    - Tank class
        Tank character has the property that increases the health/durability of the character
    
    


