using SpaceTrader.Model;

namespace SpaceTrader.Views;

public class GameView
{
    private readonly Universe _universe;
    private readonly Player _player;

    public GameView(Universe universe, Player player) =>
        (_universe, _player) = (universe, player);

    public void Refresh()
    {
        RefreshBoarder();
        RefreshMap();
        RefreshPlayerLocation();
    }

    public void PostEvent(Event @event)
    {

    }

    private void RefreshBoarder()
    {
        var space = ' ';
        var wideBoarder = new string('-', 148);
        var narrowBoarder = new string('-', 48);
        var wideWhiteSpace = new string(space, 148);
        var narrowWhiteSpace = new string(space, 48);

        Console.SetCursorPosition(top: 0, left: 0);

        Console.WriteLine($"+{wideBoarder}+{narrowBoarder}+");

        for (var rows = 0; rows < 38; rows++)
        {
            Console.WriteLine($"|{wideWhiteSpace}|{narrowWhiteSpace}|");
        }

        Console.WriteLine($"+{wideBoarder}+{narrowBoarder}+");
    }

    private void RefreshMap()
    {
        foreach (var planet in _universe.Planets)
        {
            Console.SetCursorPosition(planet.Location.Left, planet.Location.Top);
            Console.Write("🪐");

            Console.SetCursorPosition(planet.Location.Left, planet.Location.Top + 1);
            Console.Write(planet.Name);

            Console.SetCursorPosition(planet.Location.Left, planet.Location.Top + 2);
            Console.Write($"Landing Tax: {planet.LandingTax}");

            Console.SetCursorPosition(planet.Location.Left, planet.Location.Top + 3);
            Console.Write($"Safety Rating: {planet.SafetyRating}");
        }
    }

    private void RefreshPlayerLocation()
    {
        Console.SetCursorPosition(_player.Location.Left, _player.Location.Top);
        Console.Write("🚀");
    }
}
