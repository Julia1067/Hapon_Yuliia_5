using System.Collections.Generic;

Dictionary<int, int> BinarySystem = new Dictionary<int, int>();
Console.WriteLine("Enter the amount of numbers you want to convert");
int Amount = int.Parse(Console.ReadLine());
int Number;
string BinaryNum;
for (int i = 1; i <= Amount; i++)
{
    Console.WriteLine($"Enter the number {i}");
    Number = int.Parse(Console.ReadLine());
    BinaryNum = Convert.ToString(Number, 2);
    int BinaryNumber = Convert.ToInt32(BinaryNum);
    BinarySystem.Add(Number, BinaryNumber);
}

Console.Clear();

foreach (KeyValuePair<int, int> i in BinarySystem)
{
    Console.WriteLine($"{i.Key}, {i.Value}");
}

Console.Clear();
List<int> Numbers = new List<int>();
List<int> BinaryNumbers = new List<int>();
foreach (KeyValuePair<int, int> i in BinarySystem)
{
    Numbers.Add(i.Key);
    BinaryNumbers.Add(i.Value);
}

Queue<int> Queue = new Queue<int>();
for (int i = 0; i < Numbers.Count; i++)
{
    Queue.Enqueue(Numbers[i]);
}
for (int i = 0; i < BinarySystem.Count; i++)
{
    Queue.Enqueue(BinaryNumbers[i]);
}

foreach (int i in Queue)
{
    Console.Write(i + "\t");
}



