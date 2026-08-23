using System.Runtime.CompilerServices;

namespace PlayerGuide.Level24;

public class Challenge4
{
    public static void Run()
    {
        Console.WriteLine("Enter a passcode for the door");
        var passcode = Convert.ToInt32(Console.ReadLine());
        var door = new Door(passcode);
        while (true)
        {
            Console.WriteLine($"The {door.State}  door appears, what do you do");
            var command = Console.ReadLine();


            switch (command)
            {
                case "open":
                    door.Open();
                    break;
                case "close" :
                    door.Close();
                    break;
                case "lock":
                    door.Lock();
                    break;
                case "unlock":
                    door.Unlock();
                    break;
            }
            
        }
    }


    class Door
    {
        
        public State State { get; private set; }
        private int Passcode { get; set; }

        public Door(int passcode)
        {
            this.State = State.Closed;
            this.Passcode = passcode;
        }

        public void Open()
        {
            if (State == Challenge4.State.Closed) State = State.Open;
        }

        public void Close()
        {
            if (State == State.Open) State = Challenge4.State.Closed;

        }

        public void Lock()
        {
            if (State == Challenge4.State.Closed) State = State.Locked;
        }

        public void Unlock()
        {
            Console.WriteLine("Input passcode");
            var passcode = Convert.ToInt32(Console.ReadLine());

            if (State == State.Locked && passcode == Passcode) State = Challenge4.State.Closed;
            
        }

        private void ChangePasscode()
        {
            var old = -1;

            while (old != Passcode)
            {
                Console.WriteLine("Input old passcode");
                old = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Input the new passcode");
            Passcode = Convert.ToInt32(Console.ReadLine());
            
        }   
        
        
    }
    
    enum State {Open, Closed, Locked}
    
}