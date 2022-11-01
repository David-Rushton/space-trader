namespace SpaceTrader.Model;

public enum SafetyRating
{
    LowRisk,
    SomeCrime,
    Dangerous
}

public class Planet
{
    public string Name { get; init; } = string.Empty;

    public Location Location { get; init; }

    public SafetyRating SafetyRating { get; init; }

    public int LandingTax { get; init; }
}

public class PlanetsCollection
{
    Dictionary<string, Planet> _planets = new Dictionary<string, Planet>
    {
        { "Draxis",          new Planet { Name = "Draxis",           SafetyRating = SafetyRating.LowRisk,   LandingTax = 100,  Location = new() { Left = 2,   Top = 2  } } },
        { "Toppertron",      new Planet { Name = "Toppertron",       SafetyRating = SafetyRating.SomeCrime, LandingTax = 150,  Location = new() { Left = 22,  Top = 17 } } },
        { "Mega Nexis",      new Planet { Name = "Mega Nexis",       SafetyRating = SafetyRating.LowRisk,   LandingTax = 300,  Location = new() { Left = 44,  Top = 22 } } },
        { "New Yandale",     new Planet { Name = "New Yandale",      SafetyRating = SafetyRating.Dangerous, LandingTax = 200,  Location = new() { Left = 66,  Top = 35 } } },
        { "Eye of the Sky",  new Planet { Name = "Eye of the Sky",   SafetyRating = SafetyRating.SomeCrime, LandingTax = 150,  Location = new() { Left = 88,  Top = 9  } } },
        { "Capital",         new Planet { Name = "Capital",          SafetyRating = SafetyRating.SomeCrime, LandingTax = 1000, Location = new() { Left = 122, Top = 3  } } },
        { "Smugglers Rut",   new Planet { Name = "Smugglers Rut",    SafetyRating = SafetyRating.Dangerous, LandingTax = 350,  Location = new() { Left = 104, Top = 23 } } }
    };

    public Planet this[string index] => _planets[index];

    public  Dictionary<string, Planet> Items => _planets;
}
