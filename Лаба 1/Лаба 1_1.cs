using System.Collections.Generic;

List<double> NumberString = new List<double>();
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("Choose the wanted method of filling the collection");

Console.WriteLine("* if you want to fill the list in random way, press 1, if you want the handwriting method, press something else * ");
Console.ResetColor();
char Method = char.Parse(Console.ReadLine());


if (Method == '1')            
{
    RandomWay(NumberString);                      //способ заполнения списка рандомными числами
}
else
{
    HandWritingWay(NumberString);                //ручной способ заполнения списка
}

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("\nYour List");                //вывод списка
Console.ResetColor();

for (int i = 0; i < NumberString.Count; i++)
{
    Console.Write(NumberString[i] + " ");
}
double Summary = 0;
double Temp = 0;
for (int i = 0;i < NumberString.Count; i++)
{

    if(NumberString[i] < 0)
    {
        Summary = Summary + NumberString[i];
        Temp++;
    }
}
double Average = Summary / Temp;
Console.WriteLine("\n" + $"Average = {Average}");
double MinValue = NumberString[0] ;
for (int i = 1; i < NumberString.Count; i++)
{
    if (MinValue > NumberString[i])
    {
        MinValue = NumberString[i];
    }
}

for (int i = 0; i < NumberString.Count; i++)
{
    if (NumberString[i] == MinValue)
    {
        NumberString[i] = Average;
    }
    Console.Write(NumberString[i] + " ");
}
Console.WriteLine("\nMinValue" + MinValue);
static void RandomWay(List<double> NumberString)
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("Enter wanted amount of numbers in your List");
    Console.ResetColor();
    int Number = int.Parse(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("Enter wanted rage of numbers");
    Console.Write("From: ");
    Console.ResetColor();
    int LeftBoard = int.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
    Console.Write("To: ");
    Console.ResetColor();
    int RightBoard = int.Parse(Console.ReadLine());
    
    Random Rand = new Random();
    for (int i = 0; i < Number; i++)
    {
        NumberString.Add(Rand.Next(LeftBoard, RightBoard));
    }
}

static void HandWritingWay(List<double> NumberString)
{
    Console.WriteLine("Enter wanted amount of numbers in your List"); 
    int Number = int.Parse(Console.ReadLine());


    for (int i = 0; i < Number; i++)
    {
        Console.WriteLine($"Enter {i} element of yor List");
        //Console.WriteLine("Enter " + i + " element of yor List");
        NumberString.Add(int.Parse(Console.ReadLine()));
    }
}


