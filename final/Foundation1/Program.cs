using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating videos
        List<Video> videos = new List<Video>
        {
            new Video("2024 Astronomy Discoveries", "ScienceWeekly", 650),
            new Video("Funny Cat Videos", "Janet Jackson", 180),
            new Video("Top Ten Episodes of Seinfeld", "TVRanked", 450)
        };

        // Adding comments to videos
        videos[0].AddComment("Neil_Degrasse_Tyson", "The discovery of gs-350 will profoundly change the way we look at our universe.");
        videos[0].AddComment("Ethan_Smith", "Appreciate all of your videos!");
        videos[0].AddComment("Alan_Webb", "Most of these are because of my telescope.");
        videos[0].AddComment("Carl_Sagan", "My show Cosmos was so much better at explaining astronomy.");

        videos[1].AddComment("CatLady313", "I love cats.");
        videos[1].AddComment("Joe_Smith", "Cats have no souls lol");
        videos[1].AddComment("DogLover4", "Dogs are better");

        videos[2].AddComment("Jery", "Every time jerry mentions airplane food i crack up.");
        videos[2].AddComment(" @TheRealGeorgeConstanza", "Justice for my boi george.");
        videos[2].AddComment("Ethan_Smith", "Te contest is such an underated episode.");

        // Displaying information about videos
        foreach (var video in videos)
        {
            video.DisplayInformation();
        }
    }
}