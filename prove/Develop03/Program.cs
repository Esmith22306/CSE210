using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture("3 Nephi ", 5, 13, "Behold, I am a disciple of Jesus Christ, the Son of God. I have been called of him to declare his word among his people, that they might have everlasting life. ");
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