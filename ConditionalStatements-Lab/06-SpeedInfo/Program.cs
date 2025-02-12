double currentSpeed = double.Parse(Console.ReadLine());

if (currentSpeed <= 10)
{
    Console.WriteLine("slow");
}
else if (currentSpeed <= 50)
{
    Console.WriteLine("average");
}
else if (currentSpeed <= 150)
{
    Console.WriteLine("fast");
}
else if (currentSpeed <= 1000)
{
    Console.WriteLine("ultra fast");
}
else
{
    Console.WriteLine("extremely fast");
}