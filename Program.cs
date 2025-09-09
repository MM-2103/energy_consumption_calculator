public class EnergyCalc
{
    public static void Main()
    {
        const double fridge = 200;
        const double microwave = 300;
        const double heater = 100;

        var total_energy = fridge + microwave + heater;

        Console.WriteLine("The Energy used in total is {0} kwh", total_energy);
    }
}
