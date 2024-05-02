using SOLID_RPG.Dice;
using SOLID_RPG.Equipment;

namespace SOLID_RPG.Players
{
    public interface IRace : IStats
    {
        string Name { get; set; }
        IWeapon EquippedWeapon { get; set; }
    }
}
