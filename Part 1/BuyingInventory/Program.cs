//Oops, I associated the data in a list and lost the switchcase lol

List<Item> inventory = new();
inventory.Add(new Item { Name = "Rope", Value = 10 });
inventory.Add(new Item { Name= "Torches", Value=20 });
inventory.Add(new Item { Name="Climbing Equipment", Value=30 });
inventory.Add(new Item { Name = "Clean Water", Value = 2 });
inventory.Add(new Item { Name="Machete", Value = 3 });
inventory.Add(new Item { Name = "Canoe", Value = 200 });
inventory.Add(new Item { Name = "Food Supplies", Value = (2)});

Console.WriteLine("The following items are available:\r\n1 – Rope\r\n2 – Torches\r\n3 – Climbing Equipment\r\n4 – Clean Water\r\n5 – Machete\r\n6 – Canoe\r\n7 – Food Supplies\r\nWhat number do you want to see the price of?");
int input = int.Parse(Console.ReadLine());
Console.WriteLine("Whats your name?");
string inputName = Console.ReadLine();
if(inputName == "Tony")
    Console.WriteLine((inventory[input - 1].Value/2).ToString());
else
    Console.WriteLine(inventory[input - 1].Value.ToString());


struct Item
{
    public string Name; public int Value;
}