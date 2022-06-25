using System.Text.Json;
Console.WriteLine("Enter the first numerator");
double numerator1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the first denominator");
double denominator1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the second numerator");
double numerator2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the second denominator");
double denominator2 = double.Parse(Console.ReadLine());

Fraction Frac = new Fraction(numerator1, denominator1);
Fraction Frac2 = new Fraction(numerator2, denominator2);

while (true)
{


    Console.WriteLine("What function do you want to use");
    string Choice = Console.ReadLine();
    switch (Choice)
    {
        case "Reducing":
            Console.WriteLine("Choose what fruction you want to reduce");
            Choice = Console.ReadLine();

            if (Choice == "1")
            {
                Frac.Reducing();
                Frac.Print();
            }
            if (Choice == "2")
            {
                Frac2.Reducing();
                Frac2.Print();
            }
            break;
        case "Sum":

            Frac.Sum(Frac2);
            Frac.Print();
            break;
        case "Difference":

            Frac.Difference(Frac2);
            break;
        case "Product":

            Frac.Product(Frac2);
            break;
        case "Division":

            Frac.Division(Frac2);
            break;
        case "Equality":

            Frac.Equality(Frac2);
            break;
        case "Correctness":
            
            if (Choice == "1")
            {
                Frac.CorrectnessVerification();
            }
            if (Choice == "2")
            {
                Frac2.CorrectnessVerification();
            }
            break;

        default:
            Console.WriteLine("Ooops... Something went wrong");
            Console.WriteLine("This calculator don't have that function");
            break;
    }
    Console.WriteLine("Do you want to contunue?");
    Choice = Console.ReadLine();
    if (Choice == "yes")
    {
        continue;
    }
    if (Choice == "no")
    {
        break;
    }
}
var FF = new Fraction(7, 9);
FF.Save();
FF = Open();
FF.Print();

Fraction Open()
{
    var Js = File.ReadAllText("fract.json");
    Fraction FF = JsonSerializer.Deserialize<Fraction>(Js);
    return FF;
}



class Fraction   
{
    
    public double numerator { get; set; }
    public double denominator { get; set; }
    public void Reducing()
    {
        double x = numerator;
        double y = denominator;
        
        while (x != 0 && y != 0)
        {
            if (x > y) x = x % y;
            else y = y % x;
        }
        numerator /= (x + y);
        denominator /= (x + y);
        if (denominator < 0)
        {
            numerator *= -1;
            denominator *= -1;
        }

    }
    public Fraction Sum(Fraction d2)                                       
    {                                                                                                 
        Fraction Res = new Fraction(numerator * d2.denominator + d2.numerator * denominator, denominator * d2.numerator);       
        Res.Reducing();
        return Res;
    }
    public Fraction Difference(Fraction d2)                                                      
    {                                                                                                                    
        Fraction Res = new Fraction(numerator * d2.denominator - d2.numerator * denominator, denominator * d2.numerator);                        
        Res.Reducing();
        return Res;
    }
    public Fraction Product(Fraction d2)
    {
        Fraction Res = new Fraction(numerator * d2.numerator, denominator * d2.denominator);
        Res.Reducing();
        return Res;
    }
    public Fraction Division(Fraction d2)
    {
        Fraction Res = new Fraction(numerator * d2.denominator, denominator * d2.numerator);
        Res.Reducing();
        return Res;
    }
    public void Equality(Fraction d2)
    {
        if ((numerator / denominator) == (d2.numerator / d2.denominator))
        {
            Console.WriteLine("These fructions are equal");
        }
        if ((numerator / denominator) > (d2.numerator / d2.denominator))
        {
            Console.WriteLine("The value of the first fruction is bigger");
        }
        if ((numerator / denominator) < (d2.numerator / d2.denominator))
        {
            Console.WriteLine("The value of the second fruction is bigger");
        }
    }
    public void CorrectnessVerification() 
    {
        if ((numerator / denominator) > 1)
        {
            Console.WriteLine("This fruction isn't correct");
        }
        if ((numerator / denominator) < 1)
        {
            Console.WriteLine("This fruction is correct");
        }
    }
    public void Print()
    {
        Console.WriteLine($"{numerator}/{denominator}");
    }
    public Fraction(double Numerator, double Denominator)
    {
        numerator = Numerator;
        denominator = Denominator;
    }
    public void Save()
    {
        string Js = JsonSerializer.Serialize(this);
        Console.WriteLine(Js);
        File.WriteAllText("fract.json", Js);
    }

    
}
