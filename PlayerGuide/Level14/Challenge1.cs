namespace PlayerGuide.Level14;

public class Challenge1
{

    public static void Run()
    {
        const int maxHp = 15;
        const int manticoreMaxHp = 10;
        var round = 1;
        var hp = maxHp;
        var manticoreHp = manticoreMaxHp;
        var manticorePosition =
            Level13.Challenge1.AskForNumber(
                "Player 1, how far away from the city do you want to station the Manticore?");

        Console.WriteLine("Player 2, it's your turn.");    
    
        while (hp > 0)
        {
            var damage = 0;
            var message = "";
            Console.WriteLine($"STATUS: Round: {round}, City: {hp}/{maxHp}, Manticore: {manticoreHp}/{manticoreMaxHp} ");

            if (round % 5 == 0 && round % 3 == 0) damage = 10;
            else if (round % 5 == 0 ^ round % 3 == 0) damage = 3;
                else damage = 1;
            
            Console.WriteLine($"The cannon is expected to deal {damage} damage this round");

            var cannonPosition =
                Level13.Challenge1.AskForNumber(
                    "Enter the desired cannon range:");


            if (cannonPosition < manticorePosition) message = "You Undershot!";
            else if (cannonPosition > manticorePosition) message = "You Overshot!";
            else
            {
                message = "You Hit!";
                manticoreHp -= damage;
            }
            
            Console.WriteLine(message);
            
            
            
            switch (manticoreHp)
            {
                case <= 0:
                    Console.WriteLine("You Won!");
                    break;
                case > 0:
                    hp--;
                    break;
            }

            round++;
        }
        Console.WriteLine("You Lost");
    }
    
    
    
}