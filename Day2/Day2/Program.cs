//// See https://aka.ms/new-console-template for more informationusing


int sum = 0;


List<string> lines = new List<string>(File.ReadAllLines("C:\\Users\\ericd\\source\\repos\\AdventOfCode2015\\Day2\\Day2\\ListofGiftSizes.txt"));
int ribbonLength = 0;
int sumOfRibbon = 0;
foreach (string line in lines)
{
    string[] parts = line.Split('x');

    int x = int.Parse(parts[0]);
    int y = int.Parse(parts[1]);
    int z = int.Parse(parts[2]);

    int area1 = x * y;
    int area2 = y * z;
    int area3 = z * x;

    int surfaceAreaOfSide1 = 2 * x * y;
    int surfaceAreaOfSide2 = 2 * y * z;
    int surfaceAreaOfSide3 = 2 * z * x;

    int perimeter1 = 2 * x + 2 * y; ;
    int perimeter2 = 2 * y + 2 * z;
    int perimeter3 = 2 * z + 2 * x;


    int smallestArea = Math.Min(Math.Min(area1, area2), area3);

    int smallestPeremiter = Math.Min(Math.Min(perimeter1, perimeter2), perimeter3);
    int surfaceArea = surfaceAreaOfSide1 + surfaceAreaOfSide2 + surfaceAreaOfSide3 + smallestArea;

    int cubicFeet = x * y * z;
    sum += surfaceArea;
    ribbonLength = cubicFeet + smallestPeremiter;
    sumOfRibbon += ribbonLength;


}
Console.WriteLine($"The ribbon length is {sumOfRibbon}");
Console.WriteLine(sum);
Console.ReadLine();


//This is so ugly im pretty sure i can se linq or something to make it super easy.just sort the lists or ararys but size and just get the irst 2 or somthing
