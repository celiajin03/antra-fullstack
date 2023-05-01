// 03 Object-Oriented Programming

/*
1.What are the six combinations of access modifier keywords and what do they do? 

- Public: Members can be accessed from anywhere in the program.
- Private: Members can only be accessed from within the same class in which they are declared.
- Protected: Members can be accessed from within the same class or a derived class.
-Internal: Members can be accessed from within the same assembly.
- Protected internal: Members can be accessed from within the same assembly, as well as any derived classes within or outside the assembly. 
- Private protected: Members can be accessed by any code in the same class or any derived class within the same assembly.


2. What is the difference between the static, const, and readonly keywords when applied to a type member?

- Static members belong to the type itself, not to any instance of the type. They are initialized once, when the type is loaded, and they are shared by all instances of the type.
- Const members are also implicitlystatic, but they must be initialized with a constant value. Once they are initialized, their value cannot be changed at runtime.
- Readonly members are not necessarily static. They are used to declare a member that can be assigned a value only once, either inline or in a constructor, and cannot be changed thereafter. Readonly member can be of a reference type, and its value can be determined at runtime.


3. What does a constructor do?

A constructor is a special method of a class that initializes a newly created object of that type. The main purpose of a constructor is to initialize the state of the object, including its fields, properties, and other variables.


4. Why is the partial keyword useful?

It allows you to split the definition of a class, struct, or interface across multiple files.


5.What is a tuple ?

A tuple is an ordered collection of values that can be of different types.


6. What does the C# record keyword do?

The keyword is used to define a new type of object, known as a record. A record is a reference type that provides built-in implementations of common functionality such as equality, hashing, and string representation. It's immutable by default.


7. What does overloading and overriding mean?

Overloading is the ability to create multiple methods with the same name but different parameters.
Overriding is the ability to create a method in a derived class that has the same name, same parameters, and same return type, but different implementations.


8. What is the difference between a field and a property?

A field is a variable that is declared directly in a class. A property is a method that gets or sets the value of a field.


9. How do you make a method parameter optional?

- Using a default value
- Using the [Optional] attribute


10.What is an interface and how is it different from abstract class?

An interface is a blueprint for a class. It defines the methods that a class must have, but it does not define the implementation of those methods. An abstract class is a class that cannot be instantiated. It can have both abstract methods and concrete methods.
A class can implement multiple interfaces, but can only inherit from a single abstract class;
An interface cannot have a constructor, while an abstract class can;
All members of an interface are implicitly public, while members of an abstract class can have any access modifier;
An interface cannot be sealed, but an abstract class can be.


11.What accessibility level are members of an interface?

Members of an interface are always public.


12.True / False.Polymorphism allows derived classes to provide different implementations of the same method.
T

13. True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
T

14. True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
T

15. True/False. Abstract methods can be used in a normal (non-abstract) class. 
F

16. True/False. Normal (non-abstract) methods can be used in an abstract class. 
T

17. True/False. Derived classes can override methods that were virtual in the base class. 
T

18. True/False. Derived classes can override methods that were abstract in the base class. 
T

19. True/False. In a derived class, you can override a method that was neither virtual non abstract in the base class.
F

20. True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.
F

21. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.
T

22. True/False. A class can have more than one base class.
F

23. True/False. A class can implement more than one interface.
T

*/




// Working with methods

//1. FlipArray
//The program take an array and reverse the contents of it.

class FlipArray
{
    static void Main()
    {
        int[] numbers = GenerateNumbers(10);
        Reverse(ref numbers);
        PrintNumbers(numbers);
    }

    static int[] GenerateNumbers(int n)
    {
        int[] arr = Enumerable.Range(1, n).ToArray();
        return arr;
    }

    static void Reverse(ref int[] arr)
    {
        Array.Reverse(arr);
    }

    static void PrintNumbers(int[] arr)
    {
        foreach (var a in arr)
        {
            Console.Write(a + " ");
        }
    }
}


//2.Fibonacci sequence
//The program takes in a number n and returns the n(th) number of the Fibonacci sequence.

class FibonacciSeq
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }

    static int Fibonacci(int n)
    {
        if (n == 2 || n == 1) return 1;
        else return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}