double recordInSeconds = double.Parse(Console.ReadLine());
double distancePerMeter = double.Parse(Console.ReadLine());
double timeInSeconds = double.Parse(Console.ReadLine());

double swimmingSeconds = distancePerMeter * timeInSeconds;

double delay = Math.Floor(distancePerMeter / 15) * 12.5;


double bestRecord = swimmingSeconds + delay;

if (recordInSeconds <= bestRecord)
{
    Console.WriteLine($"No, he failed! He was {bestRecord - recordInSeconds:f2} seconds slower.");
}
else
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {bestRecord:f2} seconds.");
}



