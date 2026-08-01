using System;

// Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.

// Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoLibrary = new List<Video>();


        Video firstVideo = new Video();
        firstVideo.SetTitle("How to Code in C#");
        firstVideo.SetAuthor("Munachi Chinedu");
        firstVideo.SetLengthInSeconds(3600);
        videoLibrary.Add(firstVideo);

        Video secondVideo = new Video();
        secondVideo.SetTitle("Understanding Object-Oriented Programming");
        secondVideo.SetAuthor("Neche Samuel");
        secondVideo.SetLengthInSeconds(1800);
        videoLibrary.Add(secondVideo);

        Video thirdVideo = new Video();
        thirdVideo.SetTitle("Introduction to Algorithms");
        thirdVideo.SetAuthor("Eaphael Asiabaka");
        thirdVideo.SetLengthInSeconds(2400);
        videoLibrary.Add(thirdVideo);

        Comments comment1 = new Comments();
        comment1.SetCommentAuthor("Samuel");
        comment1.SetCommentText("Great video!");
        firstVideo.AddComment(comment1);

        Comments comment2 = new Comments();
        comment2.SetCommentAuthor("Phillip");
        comment2.SetCommentText("Very helpful!");
        secondVideo.AddComment(comment2);

        Comments comment3 = new Comments();
        comment3.SetCommentAuthor("Charles");
        comment3.SetCommentText("Thanks for the explanation!");
        thirdVideo.AddComment(comment3);

        for (int i = 0; i < videoLibrary.Count; i++)
        {
            Video video = videoLibrary[i];
            Console.WriteLine($"Video {i + 1}:");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            List<Comments> comments = video.GetComments();
            for (int j = 0; j < comments.Count; j++)
            {
                Comments comment = comments[j];
                Console.WriteLine($"Comment {j + 1}:");
                Console.WriteLine($"Author: {comment.GetCommentAuthor()}");
                Console.WriteLine($"Text: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}