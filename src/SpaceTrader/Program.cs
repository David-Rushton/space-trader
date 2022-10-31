using SpaceTrader.Model;
using SpaceTrader.Views;

Console.CursorVisible = false;
Console.Clear();
Console.CancelKeyPress += (_, _) =>
{
    Console.Clear();
    Console.CursorVisible = true;
};
var universe = new Universe();
var player = new Player
{
    Status = PlayerStatus.Travelling,
    Location = universe.Planets.First().Location with { },
    Destination = universe.Planets.Last(),
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

Console.SetCursorPosition(left: 0, top: 42);
// Console.Clear();
Console.CursorVisible = true;
Environment.Exit(0);


void IncrementTime() => ticks++;

void VisitPlanet()
{

}

void TravelToPlanet()
{
    while (player.Status == PlayerStatus.Travelling)
    {
        player.Move();
        RefreshUI();
        Thread.Sleep(50);
    }
}

void RefreshUI() => gameView.Refresh();

// player
//  -> location
//  -> destination


