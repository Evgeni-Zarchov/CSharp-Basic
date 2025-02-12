int examHours = int.Parse(Console.ReadLine());
int examMinutes = int.Parse(Console.ReadLine());
int arrivalHours = int.Parse(Console.ReadLine());
int arrivalMinutes = int.Parse(Console.ReadLine());

int currentTime = examHours * 60 + examMinutes;
int studentTime = arrivalHours * 60 + arrivalMinutes;
string onTimeOrLate = "";

int totalTime = currentTime - studentTime;

if (totalTime < 0)
{
    onTimeOrLate = "after the start";
    Console.WriteLine("Late");


}
else if (totalTime == totalTime && totalTime <= 30)
{
    onTimeOrLate = "before the start";
    Console.WriteLine("On time");

}
else if (totalTime > 1)
{
    onTimeOrLate = "before the start";
    Console.WriteLine("Early");
}


int finalTime = Math.Abs(totalTime);

if (finalTime != 0)
{
    if (finalTime < 60)
    {
        Console.WriteLine($"{finalTime} minutes {onTimeOrLate}");
    }
    else
    {
        int hours = finalTime / 60;
        int minutes = finalTime % 60;
        if (minutes < 10)
        {
            Console.WriteLine($"{hours}:0{minutes} hours {onTimeOrLate}");
        }
        else
        {
            Console.WriteLine($"{hours}:{minutes} hours {onTimeOrLate}");
        }
    }
}
