using System;

class Program
{
    static readonly string[] AsciiArts = new[]
    {
        @"  (o\_/o)",
        @" (='.'=)",
           @" (\"")_(\"")",
        @"  (o.o)",
        @"  ( : )",
        @"  (\__/)",
        @"  (='x'=)",
           @"  (\"")_(\"")"
    };

    static void Main()
    {
        var rand = new Random();
        while (true)
        {
            Console.Clear();
            ShowRandomAsciiArt(rand);
            Console.WriteLine("==== Monkey Console App ====");
            Console.WriteLine("1. List all monkeys");
            Console.WriteLine("2. Get details for a specific monkey by name");
            Console.WriteLine("3. Get a random monkey");
            Console.WriteLine("4. Exit app");
            Console.Write("Select an option: ");
            var input = Console.ReadLine();
            Console.WriteLine();
            switch (input)
            {
                case "1":
                    ListAllMonkeys();
                    break;
                case "2":
                    GetMonkeyByName();
                    break;
                case "3":
                    GetRandomMonkey();
                    break;
                case "4":
                    Console.WriteLine("Bye bye! 🐒");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    static void ShowRandomAsciiArt(Random rand)
    {
        var art = AsciiArts[rand.Next(AsciiArts.Length)];
        Console.WriteLine(art + "\n");
    }

    static void ListAllMonkeys()
    {
        var monkeys = MonkeyHelper.GetMonkeys();
        Console.WriteLine("Name                 | Location                | Population");
        Console.WriteLine("---------------------+-------------------------+-----------");
        foreach (var m in monkeys)
        {
            Console.WriteLine($"{m.Name,-20} | {m.Location,-23} | {m.Population,9}");
        }
    }

    static void GetMonkeyByName()
    {
        Console.Write("Enter monkey name: ");
        var name = Console.ReadLine();
        var monkey = MonkeyHelper.GetMonkeyByName(name ?? string.Empty);
        if (monkey == null)
        {
            Console.WriteLine("Monkey not found!");
            return;
        }
        PrintMonkeyDetails(monkey);
    }

    static void GetRandomMonkey()
    {
        var monkey = MonkeyHelper.GetRandomMonkey();
        Console.WriteLine($"Randomly picked: {monkey.Name}");
        PrintMonkeyDetails(monkey);
        Console.WriteLine($"Random monkey picked {MonkeyHelper.GetRandomPickCount()} times.");
    }

    static void PrintMonkeyDetails(Monkey m)
    {
        Console.WriteLine($"Name: {m.Name}");
        Console.WriteLine($"Location: {m.Location}");
        Console.WriteLine($"Population: {m.Population}");
        Console.WriteLine($"Details: {m.Details}");
        Console.WriteLine($"Lat/Lon: {m.Latitude}, {m.Longitude}");
        if (!string.IsNullOrWhiteSpace(m.Image) && m.Image.EndsWith(".jpg"))
        {
            Console.WriteLine("[이미지: " + m.Image + "]");
        }
    }
}
