using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Chatgpt will change education", "Mr. Ai", 16.45);
        Video v2 = new Video("Object Oriented Program,ing", "Telusko", 30.00);
        Video v3 = new Video("Why you should learn C# in 2024", "C# developer", 4.30);

        Comment comment1ForV1 = new Comment("Joe","Chatgpt is amazing");
        Comment comment2ForV1 = new Comment("Person","Chatgpt will destroy humanity indeed");
        Comment comment3ForV1 = new Comment("AiMaster","I need a friend like AI who will be ther to answer my questions!");

        v1.AddComment(comment1ForV1);
        v1.AddComment(comment2ForV1);
        v1.AddComment(comment3ForV1);

        Comment comment1ForV2 = new Comment("Gale","I still figure it out. I dont get it!.");
        Comment comment2ForV2 = new Comment("Lauroy","Now I know");
        Comment comment3ForV2 = new Comment("MsCheet","The Video that I like to know the oop");

        v2.AddComment(comment1ForV2);
        v2.AddComment(comment2ForV2);
        v2.AddComment(comment3ForV2);

        Comment comment1ForV3 = new Comment("Pau","C# is the best, easy to learn");
        Comment comment2ForV3 = new Comment("Yazzi","Oh I like it to learn GUI");
        Comment comment3ForV3 = new Comment("Dong","A little bit cunfused with this language");

        v3.AddComment(comment1ForV3);
        v3.AddComment(comment2ForV3);
        v3.AddComment(comment3ForV3);


        v1.Display();
        v2.Display();
        v3.Display();




    }
}