int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int roomSize = width * length * height;
int totalCubicMeters = 0;

string action = Console.ReadLine();
bool isSpaceEnough = true;

while (action != "Done")
{
    int currentCubicMeters = int.Parse(action);
    totalCubicMeters += currentCubicMeters;

    if (roomSize - totalCubicMeters < 0)
    {
        isSpaceEnough = false;
        break;
    }


    action = Console.ReadLine();
}

int cubicMetersDiff = Math.Abs(roomSize - totalCubicMeters);

if (isSpaceEnough)
{
    Console.WriteLine($"{cubicMetersDiff} Cubic meters left.");
}
else
{
    Console.WriteLine($"No more free space! You need {cubicMetersDiff} Cubic meters more.");
}

