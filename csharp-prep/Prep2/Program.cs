using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        string grade = "";
//A
        if (number >= 93)
        {
            grade = "A";
        }

        else if (number >= 90)
        {
            grade = "A-";
        }
// B
        else if (number >= 87)
        {
            grade = "B+";
        }
        else if (number >= 83)
        {
            grade = "B";
        }
        else if (number >= 80)
        {
            grade = "B-";
        }
// C
        else if (number >= 77)
        {
            grade = "C+";
        }
        else if (number >= 73)
        {
            grade = "C";
        }
        else if (number >= 70)
        {
            grade = "C-";
        }
// D

        else if (number >= 67)
        {
            grade = "D+";
        }
        else if (number >= 63)
        {
            grade = "D";
        }
        else if (number >= 60)
        {
            grade = "D-";
        }
// F
        else 
        {
            grade = "F";
        }

        Console.WriteLine($"Your letter grade is: {grade}");
        
        if (number >= 70)
        {
            Console.WriteLine("You passed! Good work!");
        }
        else 
        {
            Console.WriteLine("Hehe you failed loser. ");
        }
    }
}