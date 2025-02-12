string workingOrWorkingDay = Console.ReadLine();

string weekend = "Weekend";
string workingDay = "Working day";

string workingOrWeekend = "";
switch (workingOrWorkingDay)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        workingOrWeekend = workingDay;
        break;
    case "Saturday":
    case "Sunday":
        workingOrWeekend = weekend;
        break;
    default:
        workingOrWeekend = "Error";
        break;
}

Console.WriteLine(workingOrWeekend);
