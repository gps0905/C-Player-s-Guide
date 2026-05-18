namespace PlayerGuide.Level17;

public class Challenge1
{
    public static void Run()
    {
        (FoodType, Ingredient, Seasoning) soup = (FoodType.Soup, Ingredient.Mushrooms,  Seasoning.Sweet);
        
        Console.WriteLine("Choose a food type:");
        var food =  Console.ReadLine();
        Console.WriteLine("Choose a ingredient:");
        var ingredient = Console.ReadLine();
        Console.WriteLine("Choose a seasoning:");
        var seasoning = Console.ReadLine();

        soup.Item1 = food switch
        {
            "Soup" => FoodType.Soup,
            "Stew" => FoodType.Stew,
            "Gumbo" => FoodType.Gumbo,
            _ => soup.Item1
        };

        soup.Item2 = ingredient switch
        {
            "Mushrooms" => Ingredient.Mushrooms,
            "Chicken" => Ingredient.Chicken,
            "Carrots" => Ingredient.Carrots,
            "Potatoes" => Ingredient.Potatoes,
            _ => soup.Item2
        };

        soup.Item3 = seasoning switch
        {
            "Spicy" => Seasoning.Spicy,
            "Salty" => Seasoning.Salty,
            "Sweet" => Seasoning.Sweet,
            _ => soup.Item3
        };
        
        Console.WriteLine($"You made a {soup.Item3} {soup.Item2} {soup.Item1}");
        

    }
    
    private enum FoodType { Soup, Stew, Gumbo}
    private enum Ingredient { Mushrooms, Chicken, Carrots, Potatoes}
    private enum Seasoning {Spicy, Salty, Sweet}
    
}