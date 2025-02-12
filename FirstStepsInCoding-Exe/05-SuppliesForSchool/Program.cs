double pensPrice = 5.80;
double markersPrice = 7.20;
double chemicals = 1.20;

int pensPackage = int.Parse(Console.ReadLine());
int markersPackage = int.Parse(Console.ReadLine());
int chemicalLitre = int.Parse(Console.ReadLine());
double discount = double.Parse(Console.ReadLine());

double priceWithoutDiscount = pensPackage * pensPrice + markersPackage * markersPrice + chemicalLitre * chemicals;
double finalPrice = priceWithoutDiscount - (priceWithoutDiscount * discount / 100);
Console.WriteLine(finalPrice);


