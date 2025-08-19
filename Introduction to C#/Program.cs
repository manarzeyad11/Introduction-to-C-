using System;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            // === Menu for choosing program ===
            Console.WriteLine("\n=== Choose a Program to Run ===");
            Console.WriteLine("1. Even or Odd");
            Console.WriteLine("2. Largest of 3 Numbers");
            Console.WriteLine("3. Multiplication Table");
            Console.WriteLine("4. Sum of 5 Numbers");
            Console.WriteLine("5. Reverse a Word");
            Console.WriteLine("6. Count Vowels");
            Console.WriteLine("7. Simple Calculator");
            Console.WriteLine("8. Prime Number Check");
            Console.WriteLine("9. Fibonacci (first 10 numbers)");
            Console.WriteLine("10. Guessing Game (1–50)");
            Console.WriteLine("0. Exit");
            Console.Write("Your choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            // === Switch for program selection ===
            switch (choice)
            {
                case "1": EvenOrOdd(); break;
                case "2": LargestOfThree(); break;
                case "3": MultiplicationTable(); break;
                case "4": SumOfFive(); break;
                case "5": ReverseWord(); break;
                case "6": CountVowels(); break;
                case "7": SimpleCalculator(); break;
                case "8": PrimeCheck(); break;
                case "9": Fibonacci(); break;
                case "10": GuessingGame(); break;
                case "0": return;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }

    // === 1. Even or Odd ===
    static void EvenOrOdd()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
    }

    // === 2. Largest of 3 Numbers ===
    static void LargestOfThree()
    {
        Console.Write("Enter 1st number: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("Enter 3rd number: ");
        int n3 = int.Parse(Console.ReadLine());

        int max = Math.Max(n1, Math.Max(n2, n3));
        Console.WriteLine("The largest is: " + max);
    }

    // === 3. Multiplication Table ===
    static void MultiplicationTable()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{num} x {i} = {num * i}");
    }

    // === 4. Sum of 5 Numbers ===
    static void SumOfFive()
    {
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum is: " + sum);
    }

    // === 5. Reverse a Word ===
    static void ReverseWord()
    {
        Console.Write("Enter a word: ");
        string input = Console.ReadLine();
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        Console.WriteLine("Reversed: " + new string(chars));
    }

    // === 6. Count Vowels in a String ===
    static void CountVowels()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine().ToLower();
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        int count = text.Count(c => vowels.Contains(c));
        Console.WriteLine("Vowels count = " + count);
    }

    // === 7. Simple Calculator ===
    static void SimpleCalculator()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Enter operation (+, -, *, /): ");
        char op = Console.ReadLine()[0];

        double result = 0;
        switch (op)
        {
            case '+': result = num1 + num2; break;
            case '-': result = num1 - num2; break;
            case '*': result = num1 * num2; break;
            case '/':
                if (num2 != 0) result = num1 / num2;
                else { Console.WriteLine("Error: Division by zero!"); return; }
                break;
            default: Console.WriteLine("Invalid operation!"); return;
        }
        Console.WriteLine("Result = " + result);
    }

    // === 8. Prime Number Check ===
    static void PrimeCheck()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine($"{number} is not a prime number.");
            return;
        }

        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime ? $"{number} is a prime number." : $"{number} is not a prime number.");
    }

    // === 9. Fibonacci (first 10 numbers) ===
    static void Fibonacci()
    {
        int n1 = 0, n2 = 1, n3;
        Console.Write("Fibonacci (first 10 numbers): ");
        Console.Write(n1 + " " + n2 + " ");
        for (int i = 2; i < 10; i++)
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }
        Console.WriteLine();
    }

    // === 10. Guessing Game ===
    static void GuessingGame()
    {
        Random rand = new Random();
        int target = rand.Next(1, 51);  // random number between 1 and 50
        int guess = -1;                 // start with an invalid value

        Console.WriteLine("Guess the number between 1 and 50!");

        while (guess != target)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue; // go back to the loop without checking
            }

            if (guess < target) Console.WriteLine("Higher!");
            else if (guess > target) Console.WriteLine("Lower!");
            else Console.WriteLine("Correct! 🎉");
        }
    }
}
