namespace SpaceTrader.Model;

public interface IShip
{
    public int Shields { get; set; }

    public int FirePower { get; set; }

    public int MaxSpeed { get; set; }

    public int MaxRange { get; set; }

    public int CargoHoldSize { get; set; }
}

public class CrawlerShip : IShip
{
    public int Shields { get; set; } = 20;

    public int FirePower { get; set; } = 10;

    public int MaxSpeed { get; set; } = 5;

    public int MaxRange { get; set; } = 50;

    public int CargoHoldSize { get; set; } = 10;
}
