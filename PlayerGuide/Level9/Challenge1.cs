namespace PlayerGuide.Level9;

public class Challenge1
{
    public static void Run()
    {
        Console.WriteLine("Input Number:");
        var num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Tick");
        }
        else
        {
            Console.WriteLine("Tock");
        }
    }
    
}

