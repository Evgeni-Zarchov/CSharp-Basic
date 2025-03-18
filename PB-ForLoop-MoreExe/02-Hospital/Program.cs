int n = int.Parse(Console.ReadLine());

int doctors = 7;
int treatedPatients = 0;
int untreatedPatients = 0;

for (int i = 1; i <= n; i++)
{
    int currentPatients = int.Parse(Console.ReadLine());

    if ((i % 3 == 0) && untreatedPatients > treatedPatients)
    {
        doctors++;
    }

    if (currentPatients > doctors)
    {
        treatedPatients += doctors;
        untreatedPatients += currentPatients - doctors;
    }
    else
    {
        treatedPatients += currentPatients;
    }
}

Console.WriteLine($"Treated patients: {treatedPatients}.");
Console.WriteLine($"Untreated patients: {untreatedPatients}.");
