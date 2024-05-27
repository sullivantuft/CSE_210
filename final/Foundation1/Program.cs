using System;

class Program
{
    static void Main(string[] args)
    {
     
     List <Video> _videos = new List<Video>();

     Video video1 = new Video("Dog jumps super high", "Doggies4Life", 240);

     _videos.Add(video1);

     Comment comment1 = new Comment("DogLuver10", "Wow that dog is so cute!");
     Comment comment2 = new Comment("AnimalHippie", "My dog is better");
     Comment comment3 = new Comment("CatMan", "Didn't ask...");

     video1.AddComment(comment1);
     video1.AddComment(comment2);
     video1.AddComment(comment3);
     
     Video video2 = new Video("Mario64 Speedrun WR", "MarioOfficial", 1000);

     _videos.Add(video2);

     Comment comment4 = new Comment("Speedrunz", "I could go faster");
     Comment comment5 = new Comment("AnimalHippie", "I don't understand");
     Comment comment6 = new Comment("Luigi", "Where's my game?");

     video2.AddComment(comment4);
     video2.AddComment(comment5);
     video2.AddComment(comment6);
    
    Video video3 = new Video("GTA 6 Unboxing", "NotFake", 22);

     _videos.Add(video3);

     Comment comment7 = new Comment("GamerFan", "No way, can I get a copy?");
     Comment comment8 = new Comment("GTANews100", "Fake.");
     Comment comment9 = new Comment("GullibleGamer", "But this isn't out yet?");

     video3.AddComment(comment7);
     video3.AddComment(comment8);
     video3.AddComment(comment9);
     

    
    foreach(Video video in _videos)
    {
        Console.Write("Video: ");
        video.DisplayInfo();
        Console.WriteLine("Comments: " + video.GetNumberOfComments());
        video.DisplayComments();
        Console.WriteLine(" ");
    }


     
    }
}