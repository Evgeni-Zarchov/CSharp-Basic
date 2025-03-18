int stadiumCapaciy = int.Parse(Console.ReadLine());
int fansCount = int.Parse(Console.ReadLine());

double sectorA = 0;
double sectorB = 0;
double sectorV = 0;
double sectorG = 0;

for (int i = 1; i <= fansCount; i++)
{
    string typeOfSector = Console.ReadLine();

    if (typeOfSector == "A")
    {
        sectorA++;
    }
    else if (typeOfSector == "B")
    {
        sectorB++;
    }
    else if (typeOfSector == "V")
    {
        sectorV++;
    }
    else
    {
        sectorG++;
    }
}

double percentSectorA = (sectorA / fansCount) * 100;
double percentSectorB = (sectorB / fansCount) * 100;
double percentSectorV = (sectorV / fansCount) * 100;
double percentSectorG = (sectorG / fansCount) * 100;
double allFans = (fansCount / (double)stadiumCapaciy) * 100;

Console.WriteLine($"{percentSectorA:f2}%");
Console.WriteLine($"{percentSectorB:f2}%");
Console.WriteLine($"{percentSectorV:f2}%");
Console.WriteLine($"{percentSectorG:f2}%");
Console.WriteLine($"{allFans:f2}%");