namespace SpaceTrader.Model;

public enum PlayerStatus
{
    Travelling,
    Landed
}

public class Player
{
    private Planet? _destination;

    public PlayerStatus Status { get; set; }

    public int Credits { get; set; } = 1000;

    public int Health { get; set; } = 100;

    public Location Location { get; init; } = default!;

    public Planet? Destination
    {
        get => _destination;
        set
        {
            _destination = value;
            if (_destination != null && Location != _destination.Location)
            {
                Status = PlayerStatus.Travelling;
            }
        }
    }

    public IShip Ship { get; init; } = default!;

    public void Move()
    {
        if (Destination is null)
        {
            return;
        }

        if (Location.Top != Destination.Location.Top)
        {
            Location.Top = Location.Top > Destination.Location.Top
                ? Location.Top - 1
                : Location.Top + 1;
        }

        if (Location.Left != Destination.Location.Left)
        {
            Location.Left = Location.Left > Destination.Location.Left
                ? Location.Left - 1
                : Location.Left + 1;
        }

        if (Location == Destination.Location)
        {
            Destination = null;
            Status = PlayerStatus.Landed;
        }
    }
}

