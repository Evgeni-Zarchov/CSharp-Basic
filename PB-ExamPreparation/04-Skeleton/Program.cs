int minutes = int.Parse(Console.ReadLine());
int seconds = int.Parse(Console.ReadLine());
double lengthInMeters = double.Parse(Console.ReadLine());
int secondsToReach = int.Parse(Console.ReadLine());

minutes = minutes * 60;

double totalTime = minutes + seconds;
double timesSlower = (lengthInMeters / 120);
double decreaseTime = timesSlower * 2.5;
double totalMarinTime = (lengthInMeters / 100) * (secondsToReach) - decreaseTime;


if (totalMarinTime <= totalTime)
{
    Console.WriteLine($"Marin Bangiev won an Olympic quota!");
    Console.WriteLine($"His time is {totalMarinTime:f3}.");
}
else
{
    Console.WriteLine($"No, Marin failed! He was {totalMarinTime - totalTime:f3} second slower.");
}
