public class EnergyCalc
{
    public static void Main()
    {
        Console.Clear();

        const double electricity_price = 0.25;
        const double co2_emission = 427;

        string[] itemNames = new string[3];
        double[] itemPowers = new double[3];
        double[] itemHours = new double[3];
        double[] itemConsumptions = new double[3];
        double[] itemCosts = new double[3];

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Enter the name of item_{0}", i);
            itemNames[i - 1] = Console.ReadLine() ?? "UNKNOWN";
            Console.WriteLine("How much power in watts does your {0} use", itemNames[i - 1]);
            itemPowers[i - 1] = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("What is the average number of hours that your {0} for per day", itemNames[i - 1]);
            itemHours[i - 1] = double.Parse(Console.ReadLine() ?? "0");
            itemConsumptions[i - 1] = itemPowers[i - 1] * itemHours[i - 1] / 1000;
            Console.WriteLine("Daily consumption of {0} per day is {1}kwh", itemNames[i - 1], itemConsumptions[i - 1]);
            itemCosts[i - 1] = itemConsumptions[i - 1] * electricity_price;
            Console.WriteLine("Daily cost of {0} per day is €{1}\n", itemNames[i - 1], itemCosts[i - 1]);
        }

        var total_energy = itemConsumptions[0] + itemConsumptions[1] + itemConsumptions[2];
        var total_hours = itemHours[0] + itemHours[1] + itemHours[2];
        var total_cost = itemCosts[0] + itemCosts[1] + itemCosts[2];

        Console.WriteLine("\n" + new string('-', 80));
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("| {0,-20} | {1,-12} | {2,-12} | {3,-15} | {4,-12} |",
            "Item Name", "Power (W)", "Hours/Day", "Consumption (kWh)", "Cost ($)");
        Console.ResetColor();
        Console.WriteLine(new string('-', 80));

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("| {0,-20} | {1,-12:F2} | {2,-12:F2} | {3,-15:F3} | {4,-12:F2} |",
                itemNames[i], itemPowers[i], itemHours[i], itemConsumptions[i], itemCosts[i]);
        }

        Console.WriteLine(new string('-', 80));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("| {0,-20} | {1,-12} | {2,-12} | {3,-15:F3} | {4,-12:F2} |",
            "TOTAL", "", "", total_energy, total_cost);
        Console.ResetColor();
        Console.WriteLine(new string('-', 80));

        Console.WriteLine("\n" + new string('=', 50));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("COST PROJECTIONS");
        Console.ResetColor();
        Console.WriteLine(new string('=', 50));
        Console.WriteLine("| {0,-30} | {1,-15} |", "Period", "Cost ($)");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("| {0,-30} | {1,-15:F2} |", "Per Day", total_cost);
        Console.WriteLine("| {0,-30} | {1,-15:F2} |", "Per Month (30 days)", total_cost * 30);
        Console.WriteLine("| {0,-30} | {1,-15:F2} |", "Per Year (365 days)", total_cost * 365);
        Console.WriteLine(new string('-', 50));

        Console.WriteLine("\n" + new string('=', 50));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ENVIRONMENTAL IMPACT");
        Console.ResetColor();
        Console.WriteLine(new string('=', 50));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Total CO2 emissions: {0:F2} kg per year", total_energy * 365 * co2_emission / 1000);
        Console.ResetColor();
        Console.WriteLine(new string('=', 50));
    }
}
