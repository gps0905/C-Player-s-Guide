namespace PlayerGuide.Level9;

public class Challenge2
{
    public static void Run()
    {
        Console.WriteLine("X coords:");
        var x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Y coords:");
        var y = Convert.ToInt32(Console.ReadLine());

        const string msg = "The enemy is ";
        
        switch (x)
        {
            case < 0 when y > 0:
                Console.WriteLine(msg + "NW");
                break;
            case > 0 when y > 0:
                Console.WriteLine(msg + "NE");
                break;
            case 0 when y > 0:
                Console.WriteLine(msg + "N");
                break;
            case < 0 when y == 0:
                Console.WriteLine(msg + "W");
                break;
            case > 0 when y == 0:
                Console.WriteLine(msg + "E");
                break;
            case 0 when y == 0:
                Console.WriteLine(msg + "HERE");
                break;
            case < 0 when y < 0:
                Console.WriteLine(msg + "SW");
                break;
            case 0 when y < 0:
                Console.WriteLine(msg + "S");
                break;
            case > 0 when y < 0:
                Console.WriteLine(msg + "SE");
                break;
        }
    }
}