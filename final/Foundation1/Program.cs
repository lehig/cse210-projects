using System;

class Program
{
    List<Videos> videosList = new List<Videos>();
    static void Main(string[] args)
    {
        List<Videos> videosList = new List<Videos>();

        Videos video1 = new Videos("The Big Cheese Ball", "LongsilverSnacks0099", 180);
        video1.AddComment("Larry Birdenstock", "This video was absolutely banging! Loved every send of it! CRAZY CHEESE!!!!");
        video1.AddComment("Hungry Hippo", "Wicked CHEESE BALL!!!!");
        video1.AddComment("Brie Cheddar", "THIS VIDEO GAVE ME GOOSE BUMPS");
        videosList.Add(video1);
        Videos video2 = new Videos("I Saw The End of The World!!!!", "NetLuigi2233", 10923);
        video2.AddComment("General B", "I don't like marshmallows and gravy!!!!!!");
        video2.AddComment("Hector Namibia", "I've seen that too!");
        video2.AddComment("Mary Poppins", "I think a spoon full of sugar will help the medicine go down. :)");
        videosList.Add(video2);
        Videos video3 = new Videos("Days should be counted in 10s not 7s like we have now!", "Marianne Potato", 1542);
        video3.AddComment("Kimberly Ngyuen", "I agree 100% percent with this!");
        video3.AddComment("Nate Laremy", "You know this sounds like 17th century French propoganda");
        video3.AddComment("Beverally Lindrus", "I hate this point of view. You should not be saying this here!");
        videosList.Add(video3);

        foreach(Videos videos in videosList){
            Console.WriteLine($"Video - \nTitle: {videos.GetTitle()}\nAuthor: {videos.GetAuthor()}\nLength of video: {videos.GetLength()} seconds");
            Console.WriteLine($"Comments - ");
            foreach(Comments comments in videos.RetreiveComments()){
                Console.WriteLine($"{comments.GetName()} - {comments.GetComment()}");
            }
        }
        
    }
}