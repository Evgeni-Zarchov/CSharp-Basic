//"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."

string architectName = Console.ReadLine();
int projectsCount = int.Parse(Console.ReadLine());

int hoursNeededToCompleteTheProjects = projectsCount * 3;

Console.WriteLine($"The architect {architectName} will need {hoursNeededToCompleteTheProjects} hours to complete {projectsCount} project/s.");