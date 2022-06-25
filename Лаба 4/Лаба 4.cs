Drink[] drink = { new Puer(), new Tea(), new Coffee(), new Late() };
foreach (var item in drink)
{
    CheckInfo(item);
    Beaverage(item);
    Console.WriteLine();
}

static void CheckInfo(Drink drink)
{
    drink.ShowInfo();
}
static void Beaverage(Drink drink)
{
    drink.Beaverage();
}



abstract class Drink
{
    public abstract int Volume { get; }
    public abstract void Beaverage();

    public void ShowInfo()
    {
        Console.WriteLine(GetType().Name);
        Console.WriteLine($"Volume {Volume}");
    }
}

class Tea : Drink
{
    public override int Volume => 500;

    public override void Beaverage()
    {
        Console.WriteLine("This beaverage is brown");
    }
}

class Coffee : Drink
{
    public override int Volume => 50;

    public override void Beaverage()
    {
        Console.WriteLine("This beaverage has the dark-brown colour");
    }
}

class Late : Coffee
{
    public override int Volume => 250;

    public override void Beaverage()
    {
        Console.WriteLine("This beaverage has the light-brown colour");
    }
}

class Puer : Tea
{
    public override int Volume => 500;

    public override void Beaverage()
    {
        Console.WriteLine("This beaverage has brown colour as the Tea");
    }
}