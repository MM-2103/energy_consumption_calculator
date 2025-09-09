public class EnergyCalc
{
    public static void Main()
    {
        Console.Clear();

        Console.WriteLine("Enter the name of item_1");
        string item_1 = Console.ReadLine();
        Console.WriteLine("How much power in watts does your {0} use", item_1);
        double item_1_power = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the average number of hours that your {0} for per day", item_1);
        double item_1_hours = int.Parse(Console.ReadLine());
        double item_1_consumption = item_1_power * item_1_hours;
        Console.WriteLine("Daily consumption of {0} per day is {1}kwh\n", item_1, item_1_consumption);

        Console.WriteLine("Enter the name of item_2");
        string item_2 = Console.ReadLine();
        Console.WriteLine("How much power in watts does your {0} use", item_2);
        double item_2_power = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the average number of hours that your {0} for per day", item_2);
        double item_2_hours = int.Parse(Console.ReadLine());
        double item_2_consumption = item_2_power * item_2_hours;
        Console.WriteLine("Daily consumption of {0} per day is {1}kwh\n", item_2, item_2_consumption);

        Console.WriteLine("Enter the name of item_3");
        string item_3 = Console.ReadLine();
        Console.WriteLine("How much power in watts does your {0} use", item_3);
        double item_3_power = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the average number of hours that your {0} for per day", item_3);
        double item_3_hours = int.Parse(Console.ReadLine());
        double item_3_consumption = item_3_power * item_3_hours;
        Console.WriteLine("Daily consumption of {0} per day is {1}kwh\n", item_3, item_3_consumption);

        var total_energy = item_1_consumption + item_2_consumption + item_3_consumption;
        var total_hours = item_1_hours + item_2_hours + item_3_hours;

        Console.WriteLine("Total value is {0}kwh", total_energy);
        Console.WriteLine("Total amount of hours is {0}h", total_hours);
    }
}
