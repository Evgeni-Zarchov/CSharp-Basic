int numberOfLoads = int.Parse(Console.ReadLine());
int totalTons = 0;
double bus = 0;
double truck = 0;
double train = 0;
double priceForBusPerTon = 0;
double priceForTruckPerTon = 0;
double priceForTrainPerTon = 0;

for (int i = 0; i < numberOfLoads; i++)
{
    int currentLoads = int.Parse(Console.ReadLine());
    totalTons += currentLoads;

    if (currentLoads <= 3)
    {
        bus += currentLoads;
        priceForBusPerTon = 200;
    }
    else if (currentLoads >= 4 && currentLoads <= 11)
    {
        truck += currentLoads;
        priceForTruckPerTon = 175;
    }
    else
    {
        train += currentLoads;
        priceForTrainPerTon = 120;
    }
}

double averagePerTon = bus * priceForBusPerTon + truck * priceForTruckPerTon + train * priceForTrainPerTon;

Console.WriteLine($"{averagePerTon / totalTons:f2}");
Console.WriteLine($"{(bus / totalTons) * 100:f2}%");
Console.WriteLine($"{(truck / totalTons) * 100:f2}%");
Console.WriteLine($"{(train / totalTons) * 100:f2}%");