string actorName = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n && academyPoints <= 1250.5; i++)
{
    string juryName = Console.ReadLine();
    double juryPoints = double.Parse(Console.ReadLine());

    academyPoints += (juryName.Length * juryPoints) / 2;
}

if (academyPoints > 1250.5)
{
    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
}
else
{
    double neededPoints = Math.Abs(academyPoints - 1250.5);
    Console.WriteLine($"Sorry, {actorName} you need {$"{neededPoints:f1}"} more!");
}
