namespace PlayerGuide.Level10;

public class Challenge1
{
    public static void Run()
    {
        const string trueName = "Link";
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        
        Console.WriteLine("The following items are available:");
        Console.WriteLine("1 - Lamp Oil:");
        Console.WriteLine("2 - Rope:");
        Console.WriteLine("3 - Bombs:"); 
        var choice = Level13.Challenge1.AskForNumber("What number do you want to see the price of my friend?");


        var response = choice switch
            {
                1 => (name == trueName) ? "17 Rupees" : "35 Rupees",
                2 => (name == trueName) ? "7 Rupees" : "15 Rupees",
                3 => (name == trueName) ? "25  Rupees" : "50 Rupees",
                _ => $"Sorry {name}, I don't give credit, come back when you're a little hmmm richer"
            };
        
        Console.WriteLine(response);
    }
}