using SOLID_RPG.Players;

namespace SOLID_RPG.Factory
{
    public interface IRaceStatFactory
    {
        IRace Create(RaceType raceType);
    }
}