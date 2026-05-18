namespace PlayerGuide.Level18;

public class Challenge1
{
    public static void Run()
    {
        Console.WriteLine("Choose an arrowhead type:");
        var arrowhead =  Console.ReadLine();
        Console.WriteLine("Choose a fletchling type:");
        var fletchling = Console.ReadLine();
        var length = 0;
        while (length < 60 || length > 100)
        {
            Console.WriteLine("Choose the length:");
            length = Convert.ToInt32(Console.ReadLine());
        }

        Arrowhead chosenArrowhead = arrowhead switch
        {
            "Steel" => Arrowhead.Steel,
            "Wood" => Arrowhead.Wood,
            "Obsidian" => Arrowhead.Obsidian,
            _ => Arrowhead.Steel
        };

        soup.Item2 = ingredient switch
        {
            "Mushrooms" => Ingredient.Mushrooms,
            "Chicken" => Ingredient.Chicken,
            "Carrots" => Ingredient.Carrots,
            "Potatoes" => Ingredient.Potatoes,
            _ => soup.Item2
        };
        
        
        
        
        
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
    
    
}