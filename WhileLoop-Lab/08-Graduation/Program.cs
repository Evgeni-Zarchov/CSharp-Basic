string studentName = Console.ReadLine();
int classCount = 0;
int fail = 0;
double gradeSum = 0;
while (classCount < 12)
{
    double grades = double.Parse(Console.ReadLine());


    if (grades >= 4)
    {
        gradeSum += grades;
        classCount++;
    }
    else
    {
        fail++;

        if (fail > 1)
        {
            break;
        }
    }


}

if (fail > 1)
{
    Console.WriteLine($"{studentName} has been excluded at {classCount + 1} grade");
}
else
{
    Console.WriteLine($"{studentName} graduated. Average grade: {gradeSum / 12:f2}");
}


