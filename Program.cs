public class EnergyCalc
{
    public static void Main()
    {
        Console.Clear();

        const double electricity_price = 0.25;

        Console.WriteLine("Enter the name of item_1");
        string item_1 = Console.ReadLine();
        Console.WriteLine("How much power in watts does your {0} use", item_1);
        double item_1_power = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the average number of hours that your {0} for per day", item_1);
        double item_1_hours = int.Parse(Console.ReadLine());
        double item_1_consumption = item_1_power * item_1_hours / 1000;
        Console.WriteLine("Daily consumption of {0} per day is {1}kwh", item_1, item_1_consumption);
        double item_1_cost = item_1_consumption * electricity_price;
        Console.WriteLine("Daily cost of {0} per day is ${1}\n", item_1, item_1_cost);

        Console.WriteLine("Enter the name of item_2");
        string item_2 = Console.ReadLine();
        Console.WriteLine("How much power in watts does your {0} use", item_2);
        double item_2_power = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the average number of hours that your {0} for per day", item_2);
        double item_2_hours = int.Parse(Console.ReadLine());
        double item_2_consumption = item_2_power * item_2_hours / 1000;
        Console.WriteLine("Daily consumption of {0} per day is {1}kwh\n", item_2, item_2_consumption);
        double item_2_cost = item_2_consumption * electricity_price;
        Console.WriteLine("Daily cost of {0} per day is ${1}\n", item_2, item_2_cost);


        Console.WriteLine("Enter the name of item_3");
        string item_3 = Console.ReadLine();
        Console.WriteLine("How much power in watts does your {0} use", item_3);
        double item_3_power = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the average number of hours that your {0} for per day", item_3);
        double item_3_hours = int.Parse(Console.ReadLine());
        double item_3_consumption = item_3_power * item_3_hours / 1000;
        Console.WriteLine("Daily consumption of {0} per day is {1}kwh\n", item_3, item_3_consumption);
        double item_3_cost = item_3_consumption * electricity_price;
        Console.WriteLine("Daily cost of {0} per day is ${1}\n", item_3, item_3_cost);

        var total_energy = item_1_consumption + item_2_consumption + item_3_consumption;
        var total_hours = item_1_hours + item_2_hours + item_3_hours;
        var total_cost = item_1_cost + item_2_cost + item_3_cost;

        Console.WriteLine("Total value is {0}kwh", total_energy);
        Console.WriteLine("Total amount of hours is {0}h", total_hours);
        Console.WriteLine("Total cost in euro is ${0}", total_cost);

        Console.WriteLine("Total cost in euro per day is ${0}", total_cost * 24);
        Console.WriteLine("Total cost in euro per month is ${0}", total_cost * 720);
        Console.WriteLine("Total cost in euro per year is ${0}", total_cost * 8760);
    }
}
