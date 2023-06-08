namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(0, 1001);
            var counter = 0;
            int userInput;
            
            do
            {
                Console.WriteLine("Pick a number 1-1000");
                userInput = int.Parse(Console.ReadLine());
                if(userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low, try again");
                }
                else if(userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high, try again");
                }
                else
                {
                    Console.WriteLine("You got it!");
                }
                counter++;
                Console.WriteLine($"You have guessed {counter} times");
            } while (userInput != favNumber);
        //EX2
        Console.WriteLine("What is your favorite subject?");
        
        string subject = Console.ReadLine();

        switch(subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I'm not a fan of math.");
                    break;
                case "science":
                    Console.WriteLine("Science is pretty cool.");
                    break;
                case "PE":
                    Console.WriteLine("PE is kind of fun i guess.");
                    break;
                case "history":
                    Console.WriteLine("History is my favorite!");
                    break;
                case "english":
                    Console.WriteLine("If there is creative writing involved, english is pretty fun!");
                    break;
                default:
                    Console.WriteLine("I do not recognize that subject.");
                    break;
            }
        }
    }
}
