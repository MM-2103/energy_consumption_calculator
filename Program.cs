public class EnergyCalc
{
    public static void Main()
    {
        Console.Clear();

        Console.WriteLine("Enter the power of your fridge\n");
        double fridge = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Enter the power of your microwave\n");
        double microwave = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Enter the power of your heater\n");
        double heater = int.Parse(Console.ReadLine());
        Console.Clear();

        var total_energy = fridge + microwave + heater;

        Console.WriteLine("Total value is {0}", total_energy);
    }
}
