string serialName = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());
int restDuration = int.Parse(Console.ReadLine());

double lunchTime = restDuration * 0.125;
double restTime = restDuration * 0.25;

double timeLeft = restDuration - (lunchTime + restTime);

if (timeLeft >= episodeDuration)
{
    Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(timeLeft - episodeDuration)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Abs(Math.Ceiling(episodeDuration - timeLeft))} more minutes.");
}