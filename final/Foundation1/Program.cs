using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("James", "How I found a peach", 32);
        Video video2 = new Video("Suz", "My new book", 39);
        Video video3 = new Video("Tony", "How to propogate a pothos", 130);

        Comment comment1 = new Comment("Em", "That is so cool!");
        Comment comment2 = new Comment("Zac", "I love peaches!");
        Comment comment3 = new Comment("Ellen", "I want a peach tree");

        video1._commentList.Add(comment1);
        video1._commentList.Add(comment2);
        video1._commentList.Add(comment3);
        

        Comment comment4 = new Comment("Drew", "I love that book");
        Comment comment5 = new Comment("Linda", "How long is the book?");
        Comment comment6 = new Comment("Audrey", "That is my favorite book!");

        video2._commentList.Add(comment4);
        video2._commentList.Add(comment5);
        video2._commentList.Add(comment6);
     

        Comment comment7 = new Comment("Landon", "Does this work on other plants");
        Comment comment8 = new Comment("David", "How long does it take to grow roots");
        Comment comment9 = new Comment("Kori", "Can it be propogated with other plants?");

        video3._commentList.Add(comment7);
        video3._commentList.Add(comment8);
        video3._commentList.Add(comment9);

        VideoList videoList = new VideoList();
        videoList._videoList.Add(video1);
        videoList._videoList.Add(video2);
        videoList._videoList.Add(video3);

        videoList.Display();
      
    }
}