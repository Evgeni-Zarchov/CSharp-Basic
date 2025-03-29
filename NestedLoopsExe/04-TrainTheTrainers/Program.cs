int jury = int.Parse(Console.ReadLine());
int presentationCount = 0;
double gradeSum = 0;
string action;
while ((action = Console.ReadLine()) != "Finish")
{
    string currentPresentation = action;
    presentationCount++;
    double grades = 0;
    for (int i = 0; i < jury; i++)
    {

        double currentGrades = double.Parse(Console.ReadLine());
        grades += currentGrades;
        gradeSum += currentGrades;
    }

    Console.WriteLine($"{currentPresentation} - {grades / jury:f2}.");
}

Console.WriteLine($"Student's final assessment is {gradeSum / (jury * presentationCount):f2}.");