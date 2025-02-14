int n = int.Parse(Console.ReadLine());
int musala = 0, monblan = 0, kilimanjaro = 0, k2 = 0, everest = 0;
for (int i = 1; i <= n; i++)
{
    int peopleCount = int.Parse(Console.ReadLine());


    if (peopleCount <= 5)
    {
        musala += peopleCount;
    }
    else if (peopleCount <= 12)
    {
        monblan += peopleCount;
    }
    else if (peopleCount <= 25)
    {
        kilimanjaro += peopleCount;
    }
    else if (peopleCount <= 40)
    {
        k2 += peopleCount;
    }
    else
    {
        everest += peopleCount;
    }

}
int peoples = musala + monblan + kilimanjaro + k2 + everest;
double p1 = (musala / (double)peoples);
double p2 = (monblan / (double)peoples);
double p3 = (kilimanjaro / (double)peoples);
double p4 = (k2 / (double)peoples);
double p5 = (everest / (double)peoples);

Console.WriteLine($"{p1 * 100:f2}%");
Console.WriteLine($"{p2 * 100:f2}%");
Console.WriteLine($"{p3 * 100:f2}%");
Console.WriteLine($"{p4 * 100:f2}%");
Console.WriteLine($"{p5 * 100:f2}%");

