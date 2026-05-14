namespace PlayerGuide.Level13;

public class Challenge2
{
    public static void Run()
    {
        
       Console.WriteLine(CountDown(1500)); 
        
        
        int CountDown(int x)
        {
            if ( x == 0) return 0;
            Console.WriteLine(x);
            return CountDown(x - 1);
        }
        
        
    }
}