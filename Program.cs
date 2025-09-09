using System;

// Kata 1: Greet the user

/*public class Greeting
{
    public string Greet(string name)
    {
        string msg = $"Hello, {name}!";
        return msg;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var greeting = new Greeting();
        string message = greeting.Greet("Alice");

        Console.WriteLine(message);
    }
}*/

// Trying to rewrite the solution from memory
// Day 2: expanding the Kata with good morning messages

/*
public class Greeting
{
    public string Greet(string time, string name)
    {
        string msg = $"Good {time}, {name}!";
        return msg;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var greeting = new Greeting();
        string messageA = greeting.Greet("morning", "Alice");
        string messageB = greeting.Greet("afternoon", "Bob");

        Console.WriteLine(messageA);
        Console.WriteLine(messageB);
    }

}
*/

// This is not how I would write code like this
// I would rather list the variables of time and names in my Greeting method,
// and then just call that method once in Program. 
// Pseudo-notes (incorrect syntax):

/*
public class Greeting
{
    public string Greet(string time, string name)
    {
        var = name
        {
            Alice , Bob , Rowan
        }
        var = time
        {
            morning , afternoon , evening
        }
        string msg = $"Good {time}, {name}!";
        return msg;
    }
}
*/

// It would then print both messages entirely from two lines of code in Program:

/*
Console.WriteLine(${Greeting});
*/

// ...or something like that.

using System;



public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Solution.SolutionClass.EvenOrOdd(7));
    }
}

namespace Solution
{
    public class SolutionClass
    {
        public static string EvenOrOdd(int i)
        {
            if (i % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }

        }
    }
}