using System.Collections.Generic;

// 04 Generics
/*
1. Describe the problem generics address.

Generics provide a way to create classes, methods, and interfaces that can work with any type of data. This is useful because it allows code to be more generic and reusable.
Generics also help to improve type safety. The compiler can ensure that the types of the arguments and return values of a method are compatible. This helps to prevent errors and make code more reliable.


2. How would you create a list of strings, using the generic List class?

List<string> list = new List<string>();


3.How many generic type parameters does the Dictionary class have?

The Dictionary class has two generic type parameters: TKey and TValue. 


4. True/False. When a generic class has multiple type parameters, they must all match.
F

5. What method is used to add items to a List object?
list.Add(item);


6.Name two methods that cause items to be removed from a List.

list.Remove(item);
list.Remove(item);


7.How do you indicate that a class has a generic type parameter?

Include the type parameter after class name using angle brackets (< and >) and a single uppercase letter to represent the parameter.

    class List<T>
    {
    }


8.True / False.Generic classes can only have one generic type parameter.
F

9. True/False. Generic type constraints limit what can be used for the generic type.
T

10. True/False. Constraints let you use the methods of the thing you are constraining to.
T
*/



// Practice working with Generics

// A custom Stack class MyStack<T>
class MyStack<T>
{
    List<T> list = new List<T>();

    int Count()
    {
        return list.Count;
    }

    T Pop()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }
        T lastItem = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return lastItem;
    }

    void Push(T item)
    {
        list.Add(item);
    }
}



// A Generic List data structure MyList<T>
class MyList<T>
{
    List<T> list = new List<T>();

    void Add(T element)
    {
        list.Add(element);
    }

    T Remove(int index)
    {
        if (index < 0 || index >= list.Count)
        {
            throw new ArgumentOutOfRangeException("index out of range");
        }
        T item = list[index];
        list.RemoveAt(index);
        return item;
    }

    bool Contains(T element)
    {
        //return list.Contains(element);
        foreach (var item in list)
        {
            if (item.Equals(element)) return true;
        }
        return false;
    }

    void Clear()
    {
        list.Clear();
    }

    void InsertAt(T element, int index)
    {
        list.Insert(index, element);
    }

    void DeleteAt(int index)
    {
        if (index < 0 || index >= list.Count)
        {
            throw new ArgumentOutOfRangeException("index out of range");
        }
        list.RemoveAt(index);
    }

    T Find(int index)
    {
        if (index < 0 || index >= list.Count)
        {
            throw new ArgumentOutOfRangeException("index out of range");
        }
        return list[index];
    }
}
