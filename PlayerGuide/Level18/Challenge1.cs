namespace PlayerGuide.Level18;

public class Challenge1
{
    public static void Run()
    {
        var arrowhead = GetArrowhead();
        var fletchling = GetFletching();
        var length = GetLength();
        
        Arrow arrow = new Arrow(arrowhead, fletchling, length);
        Console.WriteLine(arrow.GetCost());

        
        
    }

    private static Arrowhead GetArrowhead()
    {
        Console.WriteLine("Choose an arrowhead type:");
        var arrowhead =  Console.ReadLine();
        return arrowhead switch
        {
            "Steel" => Arrowhead.Steel,
            "Wood" => Arrowhead.Wood,
            "Obsidian" => Arrowhead.Obsidian
        };
    }

    private static Fletching GetFletching()
    {
        Console.WriteLine("Choose a fletching type:");
        var fletching = Console.ReadLine();
        return fletching switch
        {
            "Plastic" => Fletching.Plastic,
            "Turkey" => Fletching.Turkey,
            "Goose" => Fletching.Goose
        };
    }
    
    private static int GetLength()
    {
        var length = 0;
        while (length < 60 || length > 100)
        {
            Console.WriteLine("Choose the length:");
            length = Convert.ToInt32(Console.ReadLine());
        }

        return length;

    }
    
    
    
    }
    
    

    class Arrow
    {
        private Arrowhead _arrowhead;
        private Fletching _fletching;
        private int _length;

        public Arrow(Arrowhead arrowhead, Fletching fletching, int length)
        {
            this._arrowhead = arrowhead;
            this._fletching = fletching;
            this._length = length;
        }

        public float GetCost()
        {
            float cost = 0;
            switch (_arrowhead)
            {
                case Arrowhead.Steel:
                    cost += 10;
                    break;
                case Arrowhead.Obsidian:
                    cost += 5;
                    break;
                case Arrowhead.Wood:
                    cost += 3;
                    break;
            }

            switch (_fletching)
            {
                case Fletching.Goose:
                    cost += 3;
                    break;
                case Fletching.Plastic:
                    cost += 10;
                    break;
                case Fletching.Turkey:
                    cost += 5;
                    break;
            }

            cost += _length * 0.05f;
            
            return cost;
        }
        
        
        
    }
    
    enum Arrowhead { Steel, Wood, Obsidian }
    enum Fletching { Plastic, Turkey, Goose}
    
    
