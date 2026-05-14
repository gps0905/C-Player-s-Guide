namespace PlayerGuide.Level11;

public class Challenge2
{
    public static void Run()
    {
        
        for (int a = 0; a <= 100; a++)
        {
            
            if(a % 3 == 0) Console.WriteLine($"{a}: Fire");
            else if (a % 5 == 0) Console.WriteLine($"{a}: Electric");
                else Console.WriteLine($"{a}: Normal");
        }
        
    }
}