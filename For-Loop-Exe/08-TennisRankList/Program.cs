int tournamentsCount = int.Parse(Console.ReadLine());
int startUpPoints = int.Parse(Console.ReadLine());
int tournamentCount = 0;
double points = 0;
for (int i = 1; i <= tournamentsCount; i++)
{
    string currentStage = Console.ReadLine();

    if (currentStage == "W")
    {
        tournamentCount++;
        points += 2000;
    }
    else if (currentStage == "F")
    {
        points += 1200;
    }
    else if (currentStage == "SF")
    {
        points += 720;
    }
}

double totalPoints = points + startUpPoints;
double average = points / tournamentsCount;
double percent = (tournamentCount / (double)tournamentsCount);

Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {Math.Floor(average)}");
Console.WriteLine($"{percent * 100:f2}%");
