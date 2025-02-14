
int n = int.Parse(Console.ReadLine());
int g1 = 0, g2 = 0, g3 = 0, g4 = 0, g5 = 0;

for (int i = 0; i < n; i++)
{
    int currentGroup = int.Parse(Console.ReadLine());

    if (currentGroup < 200)
    {
        g1++;
    }
    else if (currentGroup < 400)
    {
        g2++;
    }
    else if (currentGroup < 600)
    {
        g3++;
    }
    else if (currentGroup < 800)
    {
        g4++;
    }
    else
    {
        g5++;
    }
}


double p1 = g1 / (double)n;
double p2 = g2 / (double)n;
double p3 = g3 / (double)n;
double p4 = g4 / (double)n;
double p5 = g5 / (double)n;

Console.WriteLine($"{p1 * 100:f2}%");
Console.WriteLine($"{p2 * 100:f2}%");
Console.WriteLine($"{p3 * 100:f2}%");
Console.WriteLine($"{p4 * 100:f2}%");
Console.WriteLine($"{p5 * 100:f2}%");
