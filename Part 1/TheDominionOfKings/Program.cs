using System.Runtime.CompilerServices;

List<Kingdom> kings = new List<Kingdom>();
Console.WriteLine("Please enter your name and press enter. When all Kings have entered their name, simply press enter again");
bool stillEntering = true;
int counter = 0;
while (stillEntering)
{
    var tempName = Console.ReadLine();
    if (string.IsNullOrEmpty(tempName))
    {
        stillEntering = false;
        continue;
    }

    kings.Add(new Kingdom { OwnerName = tempName, Provinces = 0, Duchies = 0, Estates = 0 });
    counter++;
}

for (int i = 0; i < kings.Count; i++)
{
    Kingdom temp = kings[i];
    Console.WriteLine($"Your Majesty, King {kings[i].OwnerName}, how many Provinces do you rule?");
    temp.Provinces = int.Parse(Console.ReadLine());
    Console.WriteLine("How many Duchies do you rule?");
    temp.Duchies = int.Parse(Console.ReadLine());
    Console.WriteLine("How many Estates do you Have?");
    temp.Estates = int.Parse(Console.ReadLine());
    kings[i] = temp;

    int points = kings[i].Estates + kings[i].Duchies*3 + kings[i].Provinces*6;
    Console.WriteLine($"You have {points} points");
}

struct Kingdom
{
    public string OwnerName;
    public int Provinces;
    public int Duchies;
    public int Estates;
}