Dictionary<int, string> new1 = new Dictionary<int, string>();
ForWorkOuts forWorkOuts = new ForWorkOuts(new1);
new1.Add(550, "Ganteles");
new1.Add(150, "Resistance bands");
new1.Add(5000, "Cycle");
new1.Add(800, "Mat");
new1.Add(700, "Ball");
new1.Add(2500, "Rollers");
new1 = forWorkOuts.AddingAndSortingByKey();


Dictionary<int, string> new2 = new Dictionary<int, string>();
SummerWearing summerWearing = new SummerWearing(new1, new2);
new2.Add(200, "Crop Top");
new2.Add(600, "Pants");
new2.Add(2000, "Snickers");
new2.Add(1000, "Jump suit");
new2.Add(250, "Shirt");
new2 = summerWearing.AddingAndSortingByKey();


new2 = new Dictionary<int, string>();
WinterWearing winterWearing = new WinterWearing(new1, new2);
new2.Add(900, "Windbreaker");
new2.Add(400, "Pants");
new2.Add(3000, "Snickers");
new2.Add(1500, "Jump suit");
new2.Add(350, "Shirt");
new2 = winterWearing.AddingAndSortingByKey();


new2 = new Dictionary<int, string>();
Sportsfood sportsfood = new Sportsfood(new1, new2);
new2.Add(3000, "Protein");
new2.Add(50, "Energy Bar");
new2.Add(40, "Protein Bar");
new2.Add(5000, "Amino acids");
new2 = sportsfood.AddingAndSortingByKey();

Console.WriteLine("Enter the diapason of of sports food \nLeft limit");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Right limit");
int b = int.Parse(Console.ReadLine());
foreach (KeyValuePair<int, string> i in new2)
{
    if (i.Key >= a && i.Key <= b)
    {
        Console.WriteLine(i.Value);
    }
}



class ForWorkOuts
{
    public static Dictionary<int, string> ForWorkOut = new Dictionary<int, string>();
    public ForWorkOuts(Dictionary<int, string> forWorkOut)
    {
        ForWorkOut = forWorkOut;
    }
    public virtual Dictionary<int, string> AddingAndSortingByKey()
    {
        return ForWorkOut.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
    }
}

class SummerWearing: ForWorkOuts
{
    public SummerWearing(Dictionary<int, string> ForWorkOut, Dictionary<int, string> summerWearing) : base(ForWorkOut)
    {
        SummerWear = summerWearing;
    }
    static Dictionary <int, string> SummerWear = new Dictionary<int,string>();
    public override Dictionary<int, string> AddingAndSortingByKey()
    {
        return SummerWear.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
    }
}

class WinterWearing: ForWorkOuts
{
    public WinterWearing(Dictionary<int, string> ForWorkOut, Dictionary<int, string> winterWearing) : base(ForWorkOut)
    {
        WinterWear = winterWearing;
    }
    static Dictionary<int, string> WinterWear = new Dictionary<int, string>();
    public override Dictionary<int, string> AddingAndSortingByKey()
    {
        return WinterWear.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
    }
}

class Sportsfood : ForWorkOuts
{
    public Sportsfood(Dictionary<int, string> ForWorkOut, Dictionary<int, string> sportsFood) : base(ForWorkOut)
    {
        SportsFood = sportsFood;
    }
    static Dictionary<int, string> SportsFood = new Dictionary<int, string>();
    public override Dictionary<int, string> AddingAndSortingByKey()
    {
        return SportsFood.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
    }
}
