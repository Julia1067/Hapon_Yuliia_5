/*
 Створити об'єкт класу Квадрат, використовуючи класи Точка, Відрізок. Методи: завдання розмірів, розтягнення, стиснення, поворот, зміна кольору.
 */
Square square = new Square();
Console.WriteLine("Set the size of the square");
int AB = square.SettingSize();
List<string> Points = new List<string> {"A", "B", "C", "D"};
string ABCD = "ABCD";

while (true)
{
    Console.WriteLine("What function do you want to use?");
    string Choice = Console.ReadLine();

    switch (Choice)
    {
        case "Rotating":
            square.RotatingClockwise();
            break;

        case "Making bigger":
            int res = square.MakingBigger();
            break;

        case "Making smaller":
            res = square.MakingSmaller();
            break;

        case "Making another colour":
            Choice = Console.ReadLine();
            square.MakingAnotherColour(Choice);
            break;

        default:
            Console.WriteLine("Ooops, this program doesn't have this function");
            break;
    }
    Console.WriteLine("Do you want to continue?");
    Choice = Console.ReadLine();
    if (Choice == "yes")
    {
        continue;
    }
    else 
    {
        break;
    }
    
}


class Point
{
    public List<string> Points = new List<string>();
    //public Point(List<string> points )
    //{
    //    Points = points;
    //}
    public void RotatingClockwise()
    {
        Console.WriteLine(Points.Count());
        for (int i = 1; i <= 3; i++)
        {
            string temp1 = Points[0];
            Points[0] = Points[i];
            Points[i] = temp1;
        }

        string temp = Points[2];
        Points[2] = Points[3];
        Points[3] = temp;

        int k = 0;
        foreach (string item in Points)
        {
            if (k == 2)
            {
                Console.WriteLine("\n");
            }
            Console.Write(item + "\t");
            k++;
        }
       
    }
}

class Leg : Point
{
    public int AB { get; set; }
    
    //public Leg(List<string> Points, int ab) : base(Points)
    //{
    //    AB = ab;
    //}
    public int SettingSize()
    {
        AB = int.Parse(Console.ReadLine());
        return AB;
    }
    public int MakingBigger()
    {
        Console.WriteLine("Enter the number you want to multiply the side of your square");
        int n = int.Parse(Console.ReadLine());
        return AB * n;
        Console.WriteLine($"Now the side of your square is {AB * n}");
    }
    public int MakingSmaller()
    {
        Console.WriteLine("Enter the number you want to divide the side of your square");
        int n = int.Parse(Console.ReadLine());
        return AB / n;
        Console.WriteLine($"Now the side of your square is {AB / n}");
    }
}

class Square : Leg
{
    public string ABCD { get; set; }
    //public Square(List<string> Points, int ab, string abcd) : base(Points, ab)
    //{
    //    ABCD = abcd;
    //}
    
    public void MakingAnotherColour(string Colour)
    {
        Console.WriteLine($"Now your square is {Colour}");
    }
}

