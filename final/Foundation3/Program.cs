using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address lectureAddress = new Address("123 Main St", "Cityville", "ID", "12345");
        Address receptionAddress = new Address("456 Elm St", "Townsville", "AK", "67890");
        Address outdoorAddress = new Address("789 Oak St", "Villageton", "UT", "13579");


        // Create events
        Lecture lectureEvent = new Lecture("Lecture on AI", "Doctor Fridman will provide an in depth introduction to AI and its applications.", new DateTime(2024, 4, 15), new TimeSpan(14, 0, 0), lectureAddress, "Lex Fridman", 50);
        Reception receptionEvent = new Reception("Networking Reception", "Come join us for a networking reception and meet new people in your career field.", new DateTime(2024, 5, 20), new TimeSpan(18, 30, 0), receptionAddress, "Network@gmail.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("End of semester picnic", "Join us for an end of the semester celebratory picnic.", new DateTime(2024, 6, 25), new TimeSpan(11, 0, 0), outdoorAddress, "Sunny with a chance of rain.");


        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());

    }


}