int students = int.Parse(Console.ReadLine());

double topStudentsGrade = 0;
double studentsBetweenFour = 0;
double studentsBetweenThree = 0;
double studentsFailure = 0;
double average = 0;

for (int i = 1; i <= students; i++)
{
    double currentGrade = double.Parse(Console.ReadLine());
    average += currentGrade;

    if (currentGrade >= 5)
    {
        topStudentsGrade++;
    }
    else if (currentGrade >= 4 && currentGrade <= 4.99)
    {
        studentsBetweenFour++;
    }
    else if (currentGrade >= 3 && currentGrade <= 3.99)
    {
        studentsBetweenThree++;
    }
    else
    {
        studentsFailure++;
    }
}

double averageGrade = average / students;
double topGrades = (topStudentsGrade / students) * 100;
double fourGrades = (studentsBetweenFour / students) * 100;
double threeGrades = (studentsBetweenThree / students) * 100;
double fail = (studentsFailure / students) * 100;

Console.WriteLine($"Top students: {topGrades:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {fourGrades:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {threeGrades:f2}%");
Console.WriteLine($"Fail: {fail:f2}%");
Console.WriteLine($"Average: {averageGrade:f2}");