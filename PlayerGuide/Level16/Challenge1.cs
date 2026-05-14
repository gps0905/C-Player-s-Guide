namespace PlayerGuide.Level16;

public class Challenge1
{
    public static void Run()
    {
        var current = State.Locked;


        while (true)
        {
            
            Console.Write($"The chest is {current}. What do you want to do? ");
            var choice = Console.ReadLine();
            if (current == State.Locked && choice == "unlock") current = State.Closed;
            if (current == State.Closed && choice == "lock") current = State.Locked;
            if (current == State.Closed && choice == "open") current = State.Open;
            if (current == State.Open && choice == "close") current = State.Closed;
        }
    }
    
    enum State { Closed, Open, Locked}
}