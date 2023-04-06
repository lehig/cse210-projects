using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        Event lectureSeries = new Lecture("The World Before the Invention of the Mobile Phone", "The world is chaotic and crazy with computers in our pockets at all times. However, this wasn't always the case. Come listen to how the world was affected by the invention of the mobile phone.", "October 10th, 2023", "11:00 PM", "Grand Lecture Hall 322 Rosen St. Rexburg, ID", "Collin Williams Jr.", 250);
        Event wedding = new Reception("Reception of Mary and Carl Withers", "Join us to celebrate this spectacular union", "June 30th, 2023", "7 - 9 PM", "Hallowed Hall 490 Riller Cv. Grand Junction, OH", "ellensharp72@gmail.com");
        Event gathering = new Outdoor("Nerf Wars", "Join the awesome battle and fight like your life depended on it! Nerf guns will be provided as well as snacks and drinks.", "July 3rd, 2023", "8 - 10 PM", "The Abandoned Mine Near the Denny's on Route 89", "It will be in the evening and a little chilly, so bring your coats so you don't get cold and can have fun!");

        events.Add(lectureSeries);
        events.Add(wedding);
        events.Add(gathering);

        foreach (Event _event in events){
            Console.WriteLine($"Standard Details: \n{_event.StandardDetails()}");
            Console.WriteLine($"Full Details: \n{_event.FullDetails()}");
            Console.WriteLine($"Short Description: \n{_event.ShortDescription()}");
        }

    }
}