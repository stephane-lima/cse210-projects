using System;

class Program
{
    static void Main(string[] args)
    {

        Comment comment1 = new Comment("lifeIsGood", "So funny!");
        Comment comment2 = new Comment("user-darth-vader", "This cracks me up!");
        Comment comment3 = new Comment("amy-93", "Such a cute video! Love it.");
        Video video1 = new Video("Funny babies", "Funny Guy", 125);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Comment comment4 = new Comment("handsome-guy", "Amazing!");
        Comment comment5 = new Comment("Steve", "Wondering if they taste good");
        Comment comment6 = new Comment("sunnybunnie", "speechless");
        Video video2 = new Video("Giant Fruits", "Mr.FantasticFarmer", 189);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Comment comment7 = new Comment("yuki200", "Looks so yummy!");
        Comment comment8 = new Comment("bluebirdie", "I am feeling hungry now.");
        Comment comment9 = new Comment("Amanda123", "The best cooking video I have ever seen.");
        Comment comment10 = new Comment("Jason", "Wow, love the video.");
        Video video3 = new Video("How to make Shabu Shabu", "Tanaka", 345);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);


        List<Video> _videos = new List<Video>();
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        foreach (Video video in _videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}