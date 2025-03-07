string destination = Console.ReadLine();

while (destination != "End")
{
    double budged = double.Parse(Console.ReadLine());
    double totalSum = 0;

    while (totalSum < budged)
    {
        double currentBudged = double.Parse(Console.ReadLine());

        totalSum += currentBudged;
    }

    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
}
