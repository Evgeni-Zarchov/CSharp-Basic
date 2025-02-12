int workingHours = int.Parse(Console.ReadLine());
string workingDays = Console.ReadLine();

if (workingHours >= 10 && workingHours < 18)
{
    if (workingDays == "Monday" || workingDays == "Tuesday" || workingDays == "Wednesday" || workingDays == "Thursday" || workingDays == "Friday" || workingDays == "Saturday")
    {
        Console.WriteLine("open");
    }
    else
    {
        Console.WriteLine("closed");
    }

}
else
{
    Console.WriteLine("closed");
}
