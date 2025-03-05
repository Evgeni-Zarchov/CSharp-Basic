const int stepsGoal = 10000;
int totalSteps = 0;

string currentCommand = Console.ReadLine();
while (currentCommand != "Going home")
{
    int currentSteps = int.Parse(currentCommand);
    totalSteps += currentSteps;

    if (totalSteps == stepsGoal || totalSteps >= stepsGoal)
    {
        break;
    }

    currentCommand = Console.ReadLine();
}

if (currentCommand == "Going home")
{
    int stepsToHome = int.Parse(Console.ReadLine());
    totalSteps += stepsToHome;
}

if (totalSteps >= stepsGoal)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{totalSteps - stepsGoal} steps over the goal!");
}
else
{
    Console.WriteLine($"{stepsGoal - totalSteps} more steps to reach goal.");
}