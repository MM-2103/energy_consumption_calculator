public class EnergyCalc
{
    public static void Main()
    {
        Console.Clear();

        const double electricity_price = 0.25;

        string[] itemNames = new string[3];
        double[] itemPowers = new double[3];
        double[] itemHours = new double[3];
        double[] itemConsumptions = new double[3];
        double[] itemCosts = new double[3];


        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Enter the name of item_{0}", i);
            itemNames[i - 1] = Console.ReadLine();
            Console.WriteLine("How much power in watts does your {0} use", itemNames[i - 1]);
            itemPowers[i - 1] = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the average number of hours that your {0} for per day", itemNames[i - 1]);
            itemHours[i - 1] = double.Parse(Console.ReadLine());
            itemConsumptions[i - 1] = itemPowers[i - 1] * itemHours[i - 1] / 1000;
            Console.WriteLine("Daily consumption of {0} per day is {1}kwh", itemNames[i - 1], itemConsumptions[i - 1]);
            itemCosts[i - 1] = itemConsumptions[i - 1] * electricity_price;
            Console.WriteLine("Daily cost of {0} per day is ${1}\n", itemNames[i - 1], itemCosts[i - 1]);
        }

        var total_energy = itemConsumptions[0] + itemConsumptions[1] + itemConsumptions[2];
        var total_hours = itemHours[0] + itemHours[1] + itemHours[2];
        var total_cost = itemCosts[0] + itemCosts[1] + itemCosts[2];

        Console.WriteLine("Total value is {0}kwh", total_energy);
        Console.WriteLine("Total amount of hours is {0}h", total_hours);
        Console.WriteLine("Total cost in euro is ${0}", total_cost);

        Console.WriteLine("Total cost in euro per day is ${0}", total_cost * 24);
        Console.WriteLine("Total cost in euro per month is ${0}", total_cost * 720);
        Console.WriteLine("Total cost in euro per year is ${0}", total_cost * 8760);
    }
}
