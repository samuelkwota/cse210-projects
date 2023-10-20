using System;
using System.Collections.Generic;

// Abstract class for a Comment
abstract class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }

    public abstract void Display();
}

// Concrete class for a Video

class Program
{
    static void Main()
    {
        Video video1 = new Video("Israel-Hamas war", "CNBC", 360);
        Video video2 = new Video("Learn Graphic Design - beginner.", "Samuel Kwota", 420);
        Video video3 = new Video("New Movie 2023", "Osei Prince", 300);

        video1.AddComment(new TextComment("User1", "I don't enjoy whats happening between Israel and Hamas."));
        video1.AddComment(new TextComment("User2", "The killing has to stop on both side."));
        video1.AddComment(new VideoComment("User3", "Irael has the right to defend itself."));

        video2.AddComment(new TextComment("User4", "Interesting content, I love it."));
        video2.AddComment(new VideoComment("User5", "I've made a video related to this, you can join me on facebook."));

        video3.AddComment(new TextComment("User6", "I enjoyed watching this."));
        video3.AddComment(new TextComment("User7", "Keep up the good work!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}