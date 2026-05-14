namespace PlayerGuide.Level8;

public class Challenge1
{
    public static void Run()
    {
        Console.WriteLine("Target Row?");
        Console.ForegroundColor = ConsoleColor.Yellow;
        var row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Target Column?");
        var col = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Deploy To:");
        Console.WriteLine($"{row}, {col - 1}");
        Console.WriteLine($"{row - 1}, {col}");
        Console.WriteLine($"{row}, {col + 1}");
        Console.WriteLine($"{row + 1}, {col}");
    }
}