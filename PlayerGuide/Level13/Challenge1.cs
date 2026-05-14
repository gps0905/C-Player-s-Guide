namespace PlayerGuide.Level13;

public class Challenge1
{


    public static int AskForNumber(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    public static int AskForNumberInRange(string text, int min, int max)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > min && number < max)
        {
            return number;
        }
        return 0;
    }
    
    
    
}