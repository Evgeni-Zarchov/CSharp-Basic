int tabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());
int fine = 0;
for (int i = 1; i <= tabs; i++)
{
    string socialMedia = Console.ReadLine();

    if (socialMedia == "Facebook")
    {
        fine = 150;
        salary -= fine;
    }
    else if (socialMedia == "Instagram")
    {
        fine = 100;
        salary -= fine;
    }
    else if (socialMedia == "Reddit")
    {
        fine = 50;
        salary -= fine;
    }

    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }
}

if (salary > 0)
{
    Console.WriteLine($"{salary}");
}

