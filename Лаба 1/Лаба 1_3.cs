using System.Linq;


Console.WriteLine("Write the number of strings");
int NumberOfStrings = int.Parse(Console.ReadLine());

List<string> Strings = new List<string>();

for (int i = 0; i < NumberOfStrings; i++)
{
    Strings.Add(Console.ReadLine());
}

int Numb = Strings.Sum(s => s.Length);

Console.WriteLine($"\n{Numb}");

