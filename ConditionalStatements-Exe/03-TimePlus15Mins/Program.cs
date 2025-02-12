int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int currentMinutes = minutes + 15;


if (currentMinutes > 59)
{
    currentMinutes = currentMinutes - 60;
    hours = hours + 1;
}

if (hours > 23)
{
    hours = 0;
}

if (currentMinutes < 10)
{
    Console.WriteLine($"{hours}:0{currentMinutes}");
}
else
{
    Console.WriteLine($"{hours}:{currentMinutes}");
}
