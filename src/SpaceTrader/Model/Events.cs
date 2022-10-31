namespace SpaceTrader.Model;

public class Event
{
    public Resource Resource { get; init; }

    public int ImpactPercent { get; init; }

    public Planet? Planet { get; init; }

    public string Title { get; init; } = string.Empty;
    
    public string Description { get; init; } = string.Empty;
}

public class EventGenerator
{
    private readonly List<Event> _events = new();
    
    public EventGenerator() => InitialiseEvents();
    
    public Event GenerateEvent()
    {
        var index = new Random().Next(_events.Count);
        return _events[index];
    }
    
    private void InitialiseEvents()
    {
        _events.Add(new() 
        { 
            Resource = Resource.Wood,
            ImpactPercent = 30,
            Planet = null,
            Title = "Forest Fires on Draxis",
            Description = "The price of wood has jumped, following an environmental disaster."
        });

        _events.Add(new()
        {
            Resource = Resource.Antimatter,
            ImpactPercent = -20,
            Planet = null,
            Title = "Antimatter Breakthrough",
            Description = """
                Scientists have discovered a new method for creating antimatter.  The new technique
                has dramatically increased yields and reduced the prices.
            """
    });
    }
}
