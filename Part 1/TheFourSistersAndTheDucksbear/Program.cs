Console.WriteLine("Enter number of eggs produced today?");
bool validInput = false;
int eggCount = 0;
while (!validInput)
{
    validInput = int.TryParse((string)Console.ReadLine(), out eggCount);
    if (!validInput)
        Console.WriteLine("Please enter a valid integer number");
}
    
int eggsPerSister = eggCount / 4;
int eggsLeftover = eggCount % 4;
Console.WriteLine($"Each sister gets {eggsPerSister} and the duckbear gets {eggsLeftover} eggs!");