﻿string dayOfTheWeek = Console.ReadLine();
double price = 0;

switch (dayOfTheWeek)
{
    case "Monday":
    case "Tuesday":
    case "Friday":
        price = 12;
        break;
    case "Wednesday":
    case "Thursday":
        price = 14;
        break;
    case "Saturday":
    case "Sunday":
        price = 16;
        break;
}

Console.WriteLine(price);
