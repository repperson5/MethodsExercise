namespace MethodsExercise
{
    public class Program
    {
        public static string MyDetails()
        {
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Welcome, {userName}. We're so excited to have you with us! Please answer the following questions, so that we can get to know you better! Your answers will allow us to find you the best hotel room for your stay.");
            Console.WriteLine("What is your faveorite color?");
            string faveColor = Console.ReadLine();

            Console.WriteLine("Nice! That's a gorgeous color. Here's another question, what's your faveorite animal?");
            string faveAnimal = Console.ReadLine();

            Console.WriteLine("Lastly, what is your faveorite band? If you don't have a faveorite band, no worries! Just list one of your top faveorite songs!");
            string faveBand = Console.ReadLine();

            Console.WriteLine("Wow, sounds like you're a really cool person! Thank you for answering our questions. Based on your answers, we believe we found the perfect hotel room for you! I'm going to print our chat conversation for your records. I sure hope we get to chat again soon! Enjoy your stay at the hotel :)");
            Console.WriteLine();

            string MyDetails = $"CHAT: Our guest {userName}, booked a stay at the hotel. When booking a room, our hotel staff greeted {userName} via our chat box. The chat asked what {userName}'s faveorite color is. To which {userName} responded {faveColor}. We also inquired what their faveorite animal is. {userName} typed out that their faveorite animal is a {faveAnimal}. That's such a unqiue answer. Our staff doesn't see that answer often :). Finally, we asked {userName} if they would be so kind to state what their faveorite band or song is, to which {userName} replied with {faveBand}.";

            return MyDetails;


        }

        static void Main(string[] args)
        {
            string story = MyDetails();

            Console.WriteLine(story);
        }
    }
}
