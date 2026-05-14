namespace PlayerGuide.Level11;

public class Challenge1
{
    public static void Run()
    {
        
        const int max = 100;
        const int min = 0;
        
        Console.WriteLine($"User 1, enter a number between {min} and {max}");
        var secret = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("User 2, guess the number");

        while (true)
        {
            Console.Write("What is your next guess?");
            var guess = Convert.ToInt32(Console.ReadLine());

            if (guess == secret)
            {
                Console.WriteLine("You guessed the number");
                break;
            }

            if (guess > secret)
            {
                Console.WriteLine($"{guess} is too high");
                continue;
            }
            
            Console.WriteLine($"{guess} is too low");



        }
    }
}