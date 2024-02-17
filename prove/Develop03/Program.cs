using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture("2 Nephi ", 31, 20, "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.");
        Console.Clear();

        scripture1.Display();
        Console.WriteLine("\nPress Enter to continue or type 'Q' to exit.");

    
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
        {

            scripture1.Display();
        }
        // if (word.AllHidden = true)
        // {
        //     Console.WriteLine("\nYou got this, you memorized the scripture!!");
            
        // }

        else if (input.Key == ConsoleKey.Q)
        {
            Environment.Exit(0);
        }

        Console.Clear();


        




    }
}