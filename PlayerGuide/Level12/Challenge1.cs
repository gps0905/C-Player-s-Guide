namespace PlayerGuide.Level12;

public class Challenge1
{
    public static void Run()
    {
        const int length = 5;
        var arr1 = new int[length];
        var arr2 = new int[length];
        
        Console.WriteLine($"Gimme {length} numbahs");
        for (int i = 0; i < length; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int j = 0; j < length; j++)
        {
            arr2[j] = arr1[j];
            Console.WriteLine($"{arr1[j]} and {arr2[j]}");
        }
        
        
        
    }
}