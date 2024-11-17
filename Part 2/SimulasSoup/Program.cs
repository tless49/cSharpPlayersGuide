(FoodType, MainIngredient, Seasoning) mySoup;

while (true)
{
    Console.WriteLine("Please enter the Type of liquid you want:" +
        "1 - Soup" +
        "2 - Stew" +
        "3 - Gumbo");
    int foodInput = int.Parse( Console.ReadLine());

    Console.WriteLine("Please enter the Main ingrediant that you want:" +
        "1 - Mushrooms" +
        "2 - Chicken" +
        "3 - Carrots" +
        "4 - Potatoes");
    int ingredientInput = int.Parse( Console.ReadLine());
    Console.WriteLine("Please enter the Seaonsoning that you want:" +
        "1 - Spicy" +
        "2 - Salty" +
        "3 - Sweet");
    int seasoningInput = int.Parse(Console.ReadLine());

    mySoup = ((FoodType)foodInput, (MainIngredient)ingredientInput, (Seasoning)seasoningInput);
    Console.WriteLine($"Your soup is {mySoup.Item3} {mySoup.Item2} {mySoup.Item1}!");
}


enum FoodType
{
    Soup = 1,
    Stew,
    Gumbo
}
enum MainIngredient
{
    Mushrooms = 1,
    Chicken,
    Carrots,
    Potatoes
}
enum Seasoning
{
    Spicy = 1,
    Salty,
    Sweet
}