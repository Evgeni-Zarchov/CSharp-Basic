string command;
int studentTicketCount = 0;
int standartTicketCount = 0;
int kidTicketCount = 0;

while ((command = Console.ReadLine()) != "Finish")
{
    int totalSeats = int.Parse(Console.ReadLine());
    string projectionType;
    int takenSeats = 0;
    string movieProjection = command;

    while (takenSeats < totalSeats && (projectionType = Console.ReadLine()) != "End")
    {
        takenSeats++;
        if (projectionType == "student")
        {
            studentTicketCount++;
        }
        else if (projectionType == "standard")
        {
            standartTicketCount++;
        }
        else if (projectionType == "kid")
        {
            kidTicketCount++;
        }
    }

    Console.WriteLine($"{movieProjection} - {((double)takenSeats / totalSeats) * 100:f2}% full.");
}

int totalTicketsCount = standartTicketCount + studentTicketCount + kidTicketCount;

Console.WriteLine($"Total tickets: {totalTicketsCount}");
Console.WriteLine($"{((double)studentTicketCount / totalTicketsCount) * 100:f2}% student tickets.");
Console.WriteLine($"{((double)standartTicketCount / totalTicketsCount) * 100:f2}% standard tickets.");
Console.WriteLine($"{((double)kidTicketCount / totalTicketsCount) * 100:f2}% kids tickets.");