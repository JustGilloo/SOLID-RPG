using SOLID_RPG.Dice;
using SOLID_RPG.Equipment;
using SOLID_RPG.Input;
using SOLID_RPG.Logging;
using SOLID_RPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Factories
{
    public class WeaponFactory : IWeaponFactory
    {
        private ILogger logger;

        public WeaponFactory(ILogger logger)
        {
            this.logger = logger;
        }

        public IWeapon Create(WeaponType weaponType)
        {
            switch (weaponType)
            {
                case WeaponType.Dagger:
                    return new Dagger(logger);
                case WeaponType.Sword:
                    return new Sword(logger);
                case WeaponType.Staff:
                    return new Bow(logger);
                case WeaponType.Axe:
                    return new Axe(logger);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
