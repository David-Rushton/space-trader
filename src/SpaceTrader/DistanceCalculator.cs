using SpaceTrader.Model;

namespace SpaceTrader;

public class DistanceCalculator
{
    public IEnumerable<Planet> FindPlanetsInRange(Player player, PlanetsCollection planets)
    {
        foreach (var planet in planets.Items.Values)
        {
            if (planet.Location != player.Location)
            {
                var distance = Math.Abs(planet.Location.Left - player.Location.Left);
                distance += Math.Abs(planet.Location.Top - player.Location.Top);

                if (distance <= player.Ship.MaxRange)
                {
                    yield return planet;
                }
            }
        }
    }
}
