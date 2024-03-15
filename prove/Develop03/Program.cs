using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture("2 Nephi ", 31, 20, "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.");
        Console.Clear();

        while (!scripture1.AllHidden())
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            Console.Clear();
            scripture1.HideWords();
            scripture1.Display();
        }

    
        if (scripture1.AllHidden())
        {
            Console.WriteLine("\nYou memorized the scripture!!");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }


}