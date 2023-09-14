namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, friend!");
            Console.WriteLine("What was/is your favorite school subject?");
            var userInput = Console.ReadLine();
            Console.WriteLine($"\n Ahh, I see it's {userInput}.\n");

            switch (userInput.ToLower())
            {
                case "gym":
                case "cooking":
                case "home economics":
                    Console.WriteLine("I LOVED that school subject. An excuse to not read, write and study at a desk all day. OMEGA POGGERS!!!");
                    break;

                case "art":
                    Console.WriteLine("That's an AMAZING subject.");
                    break;

                case "math":
                    Console.WriteLine("I fell asleep a lot in that school subject.");
                    break;

                case "history":
                case "social studies":
                    Console.WriteLine("That subject wasn't taught at my school.");
                    break;

                case "science":
                case "biology":
                case "chemistry":
                    Console.WriteLine("It was a grueling but fun school subject to take.");
                    break;

                case "english":
                case "reading":
                    Console.WriteLine("I enjoyed that school subject. Wanted to take it each semester.");
                    break;

                case "music":
                    Console.WriteLine("I used to play the saxophone in music class and the band.");
                    break;

                case "computers":
                    Console.WriteLine("I wanted to take that subject each semester.");
                    break;

                case "drama":
                    Console.WriteLine("A waste of time that school subject. I'd skip it all the time.");
                    break;

                case "spanish":
                    Console.WriteLine("I don't remember anything from taking that class. Totally useless.");
                    break;

                case "business":
                case "accounting":
                case "personal finance":
                case "typing":
                    Console.WriteLine("Such a USEFULE and insightful school subject. I wish we studied it more before we were thrown into the wilds of adulthood, lol...");
                    break;

                default:
                    Console.WriteLine("I'm not familiar or didn't take that school subject.");
                    break;

            }


        }
    }
}