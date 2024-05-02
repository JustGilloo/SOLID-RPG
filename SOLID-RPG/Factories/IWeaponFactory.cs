using SOLID_RPG.Equipment;

namespace SOLID_RPG.Factories
{
    public interface IWeaponFactory
    {
        IWeapon Create(WeaponType weaponType);
    }
}