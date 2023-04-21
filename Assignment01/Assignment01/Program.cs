/*

1.
A person’s telephone number: string
A person’s height: float
A person’s age: byte
A person’s gender (Male, Female, Prefer Not To Answer): enum
A person’s salary: float
A book’s ISBN: string
A book’s price: float
A book’s shipping weight: float
A country’s population: ulong
The number of stars in the universe: ulong
The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business): ushort

2. What are the difference between value type and reference type variables? What is boxing and unboxing?

Value type variables store the actual value of the data, whereas reference type variables store a reference to the memory location where the data is stored. Value types are stored on the stack, while reference types are stored on the heap. 
Boxing is the process of converting a value type to a reference type, while unboxing is the process of converting a reference type back to a value type.


3. What is meant by the terms managed resource and unmanaged resource in .NET

Managed resources are those that are pure .NET code and managed by the runtime and are under its direct control.
Unmanaged resources are those that are not and must be explicitly released by the programmer.


4. Whats the purpose of Garbage Collector in .NET?

The purpose of the garbage collector in .NET is to automatically manage memory by freeing up memory that is no longer being used by the application. It does this by periodically scanning the heap for objects that are no longer being referenced by the application and then reclaiming the memory used by those objects. This helps to prevent memory leaks.

*/


// Playing with Console App
Console.WriteLine("what's your favorite color?");
string color = Console.ReadLine();
Console.WriteLine("What's your astrology sign？");
string sign = Console.ReadLine();
Console.WriteLine("What's your street address number？");
string num = Console.ReadLine();
Console.WriteLine("Your hacker name is " + color + sign + num);


// Practice number sizes and ranges
// 1.
namespace _02UnderstandingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,-10} {1,-6} {2,-30} {3,-30}", "Data Type", "Bytes", "Minimum Value", "Maximum Value");
            Console.WriteLine("{0,-10} {1,-6} {2,-30} {3,-30}", "--------", "-----", "-------------", "-------------");
            Console.WriteLine("{0,-10} {1,-6} {2,-30} {3,-30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("{0,-10} {1,-6} {2,-30} {3,-30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0,-10} {1,-6} {2,-30} {3,-30}", "short", sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine("{0,-10} {1,-6} {2,-30} {3,-30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("{0,-10} {1,-6} {2,-30} {3,-30}", "int", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("{0,-10} {1,-6} {2,-30} {3,-30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine("{0,-10} {1,-6} {2,-30} {3,-30}", "long", sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine("{0,-10} {1,-6} {2,-30} {3,-30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("{0,-10} {1,-6} {2,-30} {3,-30}", "float", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("{0,-10} {1,-6} {2,-30} {3,-30}", "double", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("{0,-10} {1,-6} {2,-30} {3,-30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        }
    }
}


// 2.
namespace CenturyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many centuries?");
            int centuries = int.Parse(Console.ReadLine());
            long years = centuries * 100;
            long days = years * 365;
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            long nanoseconds = microseconds * 1000;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}

/*
1.What happens when you divide an int variable by 0?
System.DivideByZeroException is thrown at runtime.

2. What happens when you divide a double variable by 0?
The result Infinity.

3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
At assignment, we'll get the error "Constant value 'xxx' cannot be converted to a int". At calculation, its value will go around to the opposite end of the range.

4. What is the difference between x = y++; and x = ++y;?
y++ first assigns the value of y to x, then increments the value of y by 1. ++y first increments the value of y by 1, then assigns the new value of y to x.

5. What is the difference between break, continue, and return when used inside a loop
statement?
break terminates the loop and continues execution at the statement immediately following the loop. continue skips the current iteration of the loop and starts the next iteration. return terminates the entire method and returns value.

6. What are the three parts of a for statement and which of them are required?
The three parts are: initializer, condition, iterator. All of them are optional.

7. What is the difference between the = and == operators?
= is the assignment operator and is used to assign a value to a variable. == is the equality operator and is used to compare two values for equality. 

8. Does the following statement compile? for ( ; true; ) ;
Yes, it creates an infinite loop that executes the empty statement.

9. What does the underscore _ represent in a switch expression?
The underscore (_) character is used as a "default" case to match any value that doesn't match any of the other cases.

10.What interface must an object implement to be enumerated over by using the foreach
statement ?
object must implements System.Collections.IEnumerable interface.
*/


// Practice loops and operators
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}

/*
    The code will result in an infinite loop. Because the maximum value of a byte variable is 255, so when i reaches 255, it will wrap around to 0 and the loop will continue indefinitely. We could add the following:

    if (max > byte.MaxValue)
    {
        Console.WriteLine("Warning: max value exceeds maximum value of byte data type.");
    }
*/



// 2.
namespace PrintPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                // print spaces
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                // print stars
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}


// 3.
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctNumber = new Random().Next(3) + 1;
            do
            {
                Console.WriteLine("Take a guess on random number between 1 and 3:");
                int guess = int.Parse(Console.ReadLine());

                if (guess < 1 || guess > 3)
                {
                    Console.WriteLine("Your guess is outside the range of valid numbers.");
                }
                else if (guess == correctNumber)
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                else if (guess < correctNumber)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else // guess > correctNumber
                {
                    Console.WriteLine("Your guess is too high.");
                }
            } while (true);

        }
    }
}



// 4.
namespace BirthAnniversary
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(2021, 4, 19);
            DateTime today = DateTime.Today;

            //get difference of two dates
            var diffOfDates = today - birthday;
            Console.WriteLine("This person is {0} days old.", diffOfDates.Days);
            int daysToNextAnniversary = 10000 - (diffOfDates.Days % 10000);
            Console.WriteLine("{0} days until the next anniversary.", daysToNextAnniversary);
        }
    }
}



// 5.
namespace TimeGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            int morning = 6;
            int afternoon = 12;
            int evening = 18;
            int night = 21;

            if (currentTime.Hour >= morning && currentTime.Hour < afternoon)
            {
                Console.WriteLine("Good Morning");
            }
            if (currentTime.Hour >= afternoon && currentTime.Hour < evening)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (currentTime.Hour >= evening && currentTime.Hour < night)
            {
                Console.WriteLine("Good Evening");
            }
            if (currentTime.Hour >= night || currentTime.Hour < morning)
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}



// 6.
namespace Count24
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                int j = 0;
                for (; j < 24;)
                {
                    Console.Write(j + ",");
                    j += i;
                }
                Console.Write(j);
                Console.WriteLine();
            }
        }
    }
}

