int buildingFloors = int.Parse(Console.ReadLine());
int buildingRooms = int.Parse(Console.ReadLine());

for (int floors = buildingFloors; floors >= 1; floors--)
{
    string officeOrApartment = "";

    if (buildingFloors == floors)
    {
        officeOrApartment = "L";
    }
    else if (floors % 2 == 0)
    {
        officeOrApartment = "O";

    }
    else
    {
        officeOrApartment = "A";
    }

    for (int rooms = 0; rooms < buildingRooms; rooms++)
    {
        Console.Write($"{officeOrApartment}{floors}{rooms} ");

    }

    Console.WriteLine();
}