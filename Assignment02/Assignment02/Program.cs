// 02 Arrays and Strings

/*
1.When to use String vs. StringBuilder in C# ?

Use String when we have a fixed string that doesn't require much manipulation or changes. Strings are immutable in C#, so we cannot modify a string once we create it.
Use StringBuilder when we have a dynamic string that requires frequent manipulation or changes, such as appending or inserting characters. StringBuilder is mutable, so we can modify its contents without creating a new object each time.
Also use StringBuilder for a large number of concatenations.


2. What is the base class for all arrays in C#?

System.Array


3.How do you sort an array in C#?

Use the Array.Sort() method.
eg.Array.Sort(arr);


4.What property of an array object can be used to get the total number of elements in an array?

arr.Length;


5.Can you store multiple data types in System.Array?

No, Array is homogeneous in nature, so it cannot hold multiple data types. Unless we declare it as object [].


6.What’s the difference between the System.Array.CopyTo() and System.Array.Clone() ?

System.Array.CopyTo() copies the contents of one array to another array, while the System.Array.Clone() creates a new array with the same contents as the original array.
*/



// Practice Arrays

//1.Copying an Array
int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] arr2 = new int[arr1.Length];

for (int i = 0; i < arr1.Length; i++)
{
    arr2[i] = arr1[i];
}

Console.WriteLine("Original Array:");
foreach (int i in arr1)
{
    Console.Write(i + " ");
}

Console.WriteLine("\nCopied Array:");
foreach (int i in arr2)
{
    Console.Write(i + " ");
}



//2.A simple program that lets the user manage a list of elements. It can be a grocery list, "to do" list, etc. The operations available are Add, Remove, and Clear.
static void ManageList()
{
    List<string> groceryList = new List<string>();
    do
    {
        Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
        string operation = Console.ReadLine();
        switch (operation.Substring(0, 2))
        {
            case "+ ":
                groceryList.Add(operation.Substring(2, operation.Length - 2));
                break;
            case "- ":
                groceryList.Remove(operation.Substring(2, operation.Length - 2));
                break;
            default:
                groceryList.Clear();
                break;
        }

        foreach (var item in groceryList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine('\n');
    } while (true);
}



//3.A method that calculates all prime numbers in given range and returns them as array of integers.
static int[] FindPrimesInRange(int startNum, int endNum)
{
    List<int> primes = new List<int>();
    for (int i = startNum; i < endNum; i++)
    {
        bool isPrime = true;
        if (i <= 1)
        {
            isPrime = false;
        }

        for (int factor = 2; factor <= (i / 2); factor++)
        {
            if (i % factor == 0) { isPrime = false; break; }
        }
        if (isPrime)
        {
            primes.Add(i);
        }
    }
    return primes.ToArray();
}

/*
int[] primes = FindPrimesInRange(1, 30);
foreach (int prime in primes)
{
    Console.Write(prime + " ");
}
*/



//4.A program that reads an array of n integers (space separated on a single line) and an integer k, rotate the array right k times and sum the obtained arrays after each rotation.
static List<int> RotateSum(string inputArray, int k)
{
    List<int> integers = new List<int>();
    foreach (var i in inputArray.Split(" "))
    {
        integers.Add(int.Parse(i));
    }
    List<int> sums = new List<int>(integers.Count);
    for (int i = 0; i < integers.Count; i++)
    {
        int sumI = 0;
        for (int j = 1; j <= k; j++)
        {
            sumI += (integers[(i - j + (j / integers.Count + 1) * integers.Count) % integers.Count]);
        }
        sums.Add(sumI);
    }
    return sums;
}
/*
List<int> sums = RotateSum("3 2 4 -1", 2);
foreach (var s in sums)
{
    Console.Write(s + " ");
}
*/



//5.A program that finds the longest sequence of equal elements in an array of integers.If several longest sequences exist, print the leftmost one.
static void FindLongestSeq(int[] ints)
{
    int maxLen = 0;
    int len = 1;
    int maxInt = int.MinValue;
    int prevInt = int.MinValue;
    foreach (int i in ints)
    {
        if (i == prevInt) { len += 1; }
        else
        {
            if (len > maxLen)
            {
                maxLen = len;
                maxInt = prevInt;
                len = 1;
            }
        }
        prevInt = i;
    }
    string output = string.Concat(Enumerable.Repeat(maxInt.ToString() + ' ', maxLen));
    Console.WriteLine(output);
}
/*
int[] ints = new int[] { 0, 1, 1, 5, 2, 2, 6, 3, 3 };
FindLongestSeq(ints);
*/



//7.A program that finds the most frequent number in a given sequence of numbers. In case of multiple numbers with the same maximal frequency, print the leftmost one.
static void FindMostFreqNum(int[] ints)
{
    Dictionary<int, int> numberCounts = new Dictionary<int, int>();
    Dictionary<int, int> modes = new Dictionary<int, int>();
    int maxCount = 0;
    int maxNum = ints[0];
    foreach (var i in ints)
    {
        if (numberCounts.ContainsKey(i))
        {
            numberCounts[i] += 1;
        }
        else
        {
            numberCounts.Add(i, 1);
        }
    }
    foreach (var kv in numberCounts)
    {
        if (kv.Value > maxCount)
        {
            maxCount = kv.Value;
            maxNum = kv.Key;
        }
    }
    foreach (var kv in numberCounts)
    {
        if (kv.Value == maxCount)
        {
            modes.Add(kv.Key, kv.Value);
        }
    }

    if (modes.Count() == 1)
    {
        Console.WriteLine($"The number {maxNum.ToString()} is the most frequent (occurs {maxCount} times)");
    }
    else
    {
        Console.WriteLine($"The numbers {string.Join(", ", modes.Keys)} have the same maximal frequence (each occurs {maxCount} times). The leftmost of them is {modes.First().Key.ToString()}.");
    }
}
/*
int[] ints = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
int[] ints = new int[] { 7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10 };
FindMostFreqNum(ints);
*/



// Practice Strings

//1.A program that reads a string from the console, reverses its letters and prints the result back at the console in two ways.

//1st way: Convert the string to char array, reverse it, then convert it to string again.
Console.WriteLine("Type a string:");
string input = Console.ReadLine();
char[] chars = input.ToCharArray();
string output = string.Concat(chars.Reverse());
Console.WriteLine(output);

//2nd way: Print the letters of the string in back direction (from the last to the first) in a for-loop.
Console.WriteLine("Type a string:");
string input = Console.ReadLine();
foreach (char c in input.Reverse())
{
    Console.Write(c);
}



//2.A program that reverses the words in a given sentence without changing the punctuation and spaces.
static void ReverseWord(string sentence)
{
    string punctuations = ".,:;=()&[]\"'\\/!? ";
    string[] words = sentence.Split(punctuations.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
    string[] nonWords = sentence.Split(words, StringSplitOptions.None);
    //Console.WriteLine(string.Join("     ", words));
    //Console.WriteLine(string.Join("     ", nonWords));
    string output = "";
    for (int i = 0; i < words.Length; i++)
    {
        output += nonWords[i] + words[words.Length - 1 - i];
    }
    Console.WriteLine(output);
}
/*
string sentence = "C# is not C++, and PHP is not Delphi!";
ReverseWord(sentence);
*/



//3.A program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe” and prints them on the console on a single line, separated by comma and space.
static void FindPalindromes(string input)
{
    List<string> output = new List<string>();
    int i = 1;
    while (i < input.Length - 1)
    {
        //Console.WriteLine($"{i}, {input[i]}");
        if (input[i - 1] == input[i])
        {
            for (int j = i - 2; j >= 0; j--)
            {
                if (input[j] != input[2 * i - j - 1])
                {
                    output.Add(input.Substring(j + 1, 2 * (i - j) - 2));
                    i = 2 * i - j - 2;
                    break;
                }
            }
        }
        if (input[i - 1] == input[i + 1])
        {
            for (int j = i - 2; j >= 0; j--)
            {
                if (input[j] != input[2 * i - j - 1])
                {
                    output.Add(input.Substring(j + 1, 2 * (i - j) - 1));
                    i = 2 * i - j;
                    break;
                }
            }
        }
        i += 1;
    }

    Console.WriteLine(string.Join(", ", output));
}
/*
string input = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
FindPalindromes(input);
*/



//4.A program that parses an URL given in the following format: [protocol]://[server]/[resource]
static void ParseUrl(string url)
{
    string[] parts = url.Split(new string[] { "://", "/" }, StringSplitOptions.None);
    string protocol = "";
    string server = "";
    string resource = "";
    if (url.Contains("://"))
    {
        protocol = parts[0];
        server = parts[1];
    }
    else
    {
        server = parts[0];
        if (url.Contains("/"))
        {
            resource = parts[1];
        }
    }

    Console.WriteLine($"[protocol] = \"{protocol}\"");
    Console.WriteLine($"[server] = \"{server}\"");
    Console.WriteLine($"[resource] = \"{resource}\"");
}
/*
string url = "https://www.apple.com/iphone";
string url = "https://google.com";
ParseUrl(url);
*/
