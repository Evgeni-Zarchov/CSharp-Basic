double greenPaint = 3.4;
double redPaint = 4.3;

// house parametes
double houseHeight = double.Parse(Console.ReadLine());
double houseLength = double.Parse(Console.ReadLine());
double roofHeight = double.Parse(Console.ReadLine());

// Windows, doors, sides to reduce from the front and back side.
double windows = 1.5 * 1.5;
double doors = 1.2 * 2;
double sides = 2;

// Calculations for how much paint is needed to paint the house.
// The paint is green.
double houseSide = houseHeight * houseLength;
double totalFrontSide = (sides * houseSide) - sides * windows;

double backSide = houseHeight * houseHeight;

double totalBackSide = (sides * backSide) - doors;

// Total greenPaint.
double totalSquareMeters = (totalFrontSide + totalBackSide) / greenPaint;

// Roof parameters the roof is red.
double rectangle = sides * (houseHeight * houseLength);
double triangle = sides * (houseHeight * roofHeight / sides);
double totalRoof = rectangle + triangle;

// Total redPaint.
double totalSquareRoof = totalRoof / redPaint;

Console.WriteLine($"{totalSquareMeters:f2}");
Console.WriteLine($"{totalSquareRoof:f2}");


