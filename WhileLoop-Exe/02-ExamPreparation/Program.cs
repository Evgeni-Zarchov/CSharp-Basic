int poorGradeCount = int.Parse(Console.ReadLine());
string taskName = "";
int gradeSum = 0;
int poorGradesCount = 0;
int taskCounter = 0;
while (poorGradesCount < poorGradeCount)
{
    string currenTask = Console.ReadLine();
    if (currenTask == "Enough")
    {
        break;
    }

    int currentGrade = int.Parse(Console.ReadLine());
    if (currentGrade <= 4)
    {
        poorGradesCount++;
    }

    gradeSum += currentGrade;
    taskCounter++;
    taskName = currenTask;

}

if (poorGradesCount == poorGradeCount)
{

    Console.WriteLine($"You need a break, {poorGradesCount} poor grades.");

}
else
{
    Console.WriteLine($"Average score: {(double)gradeSum / taskCounter:f2}");
    Console.WriteLine($"Number of problems: {taskCounter}");
    Console.WriteLine($"Last problem: {taskName}");
}