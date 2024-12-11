using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        videos.Add(new Video
        {
            Title = "Amazing Cat Video",
            Author = "FunnyCatLover",
            LengthInSeconds = 120,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "User1", Text = "So cute!" },
                new Comment { CommenterName = "User2", Text = "Hilarious!" },
                new Comment { CommenterName = "User3", Text = "Love it!" }
            }
        });

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.CommentCount}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}