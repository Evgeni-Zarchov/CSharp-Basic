string action = Console.ReadLine();

while (action != "Negative number!")
{
    double number = double.Parse(action);

    if (number >= 0)
    {
        Console.WriteLine($"Result: {number * 2:f2}");
    }


    if (number < 0)
    {
        Console.Write("Negative number!");
        break;
    }

    action = Console.ReadLine();
}
