ChestLock _currentChestState = ChestLock.Locked;

while (true)
{
    Console.Write($"The Chest is {_currentChestState}. What do you want to do? ");
    var userInput = Console.ReadLine();

    switch (_currentChestState)
    {
        case ChestLock.Open:
            if (userInput == "close")
                _currentChestState = ChestLock.Closed;
            break;

        case ChestLock.Closed:
            if (userInput == "lock")
                _currentChestState = ChestLock.Locked;
            else if (userInput == "open")
                _currentChestState = ChestLock.Open;
            break;

        case ChestLock.Locked:
            if (userInput == "unlock")
                _currentChestState = ChestLock.Closed;
            break;
    }

}
Interface with Windows features: https://github.com/Tyrrrz/LightBulb
Handle the networking:  https://github.com/Tyrrrz/YoutubeDownloader
MahApps:  https://github.com/HearthSim/Hearthstone-Deck-Tracker