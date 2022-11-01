using SpaceTrader;
using SpaceTrader.Controllers;
using SpaceTrader.Model;
using SpaceTrader.Views;

Console.CursorVisible = false;
Console.Clear();
Console.CancelKeyPress += (_, _) =>
{
    Console.Clear();
    Console.CursorVisible = true;
};

var distanceCalculator = new DistanceCalculator();
var inputController = new InputController();
var universe = new PlanetsCollection();
var player = new Player
{
    Status = PlayerStatus.Travelling,
    Location = universe.Items.First().Value.Location with { },
    Destination = universe.Items.Last().Value,
    Ship = new CrawlerShip()
};
var eventGenerator = new EventGenerator();
var gameView = new GameView(universe, player);
var ticks = 0;

while (true)
{
    IncrementTime();
    TravelToPlanet();
    VisitPlanet();
    RefreshUI();

    Thread.Sleep(300);
}


// Console.Clear();
Console.CursorVisible = true;
Environment.Exit(0);


void IncrementTime() => ticks++;

void VisitPlanet()
{
    KeyPressResult keyPressResult;

    foreach (var planet in distanceCalculator.FindPlanetsInRange(player, universe))
    {
        Console.WriteLine(planet.Name);
    }

    // gameView.PresentOptions();


    while (true)
    {
        IncrementTime();

        keyPressResult = inputController.WaitForKeyPress(500);

        RefreshUI();

        if (!keyPressResult.RequestedTimedOut)
        {
            break;
        }
    }

    Console.WriteLine(keyPressResult.ConsoleKeyInfo!.Value.KeyChar);
}

void TravelToPlanet()
{
    var iteration = 0;

    while (player.Status == PlayerStatus.Travelling)
    {
        player.Move();

        RefreshUI();

        if (iteration % 30 == 0)
        {
            IncrementTime();
        }

        Thread.Sleep(20);
    }
}

void RefreshUI() => gameView.Refresh(ticks);

// player
//  -> location
//  -> destination


