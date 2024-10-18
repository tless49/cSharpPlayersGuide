var h = Console.ReadLine();
var b = Console.ReadLine();
if(double.TryParse((string)h, out var hDouble) == false)
    return;
if(double.TryParse((string)b, out var bDouble) == false)
    return;
Console.WriteLine($"The area of your triangle is: {(hDouble*bDouble)/2}!");