int maxPlayingMinutesPerYear = 30000;

int nonWorkingDays = int.Parse(Console.ReadLine());

int yearlyDays = 365 - nonWorkingDays;

int totalPlayingTime = yearlyDays * 63 + nonWorkingDays * 127;

int hours = Math.Abs((maxPlayingMinutesPerYear - totalPlayingTime) / 60);

int minutes = Math.Abs((maxPlayingMinutesPerYear - totalPlayingTime) % 60);


if (totalPlayingTime <= maxPlayingMinutesPerYear)
{
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{hours} hours and {minutes} minutes less for play");

}
else
{
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
}
