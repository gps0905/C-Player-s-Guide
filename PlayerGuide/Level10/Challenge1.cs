namespace PlayerGuide.Level10;

public class Challenge1
{
    public static void Run()
    {
        Console.WriteLine("The following items are available:");
        Console.WriteLine("1 - Lamp Oil:");
        Console.WriteLine("2 - Rope:");
        Console.WriteLine("3 - Bombs:"); 
        Console.WriteLine("What number do you want to see the price of my friend?");
        var choice = Convert.ToInt32(Console.ReadLine());


        string response = choice switch
            {
                1 => "35 Rupees",
                2 => "15 Rupees",
                3 => "50 Rupees",
                _ => "Sorry Link, I don't give credit, come back when you're a little hmmm richer"
            };
        
        Console.WriteLine(response);
    }
}