string animalType = Console.ReadLine();
string type = "";

switch (animalType)
{
    case "dog":
        type = "mammal";
        break;
    case "crocodile":
    case "tortoise":
    case "snake":
        type = "reptile";
        break;
    default:
        type = "unknown";
        break;
}

Console.WriteLine(type);