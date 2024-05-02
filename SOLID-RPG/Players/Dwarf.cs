using SOLID_RPG.Dice;
using SOLID_RPG.Equipment;
using SOLID_RPG.Factories;
using SOLID_RPG.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Players
{
    internal class Dwarf : IRace
    {
        private ILogger logger;
        private IDiceRoller roller;
        private IWeaponFactory weaponFactory;

        public Dwarf(ILogger logger, IDiceRoller roller, string name, IWeaponFactory weaponFactory)
        {
            this.logger = logger;
            this.roller = roller;
            this.Name = name;
            this.Strength = roller.RollStatsDice(4, 6);
            this.Intelligence = roller.RollStatsDice(1, 6);
            this.HP = roller.RollStatsDice(2, 6);
            this.weaponFactory = weaponFactory;
            this.EquippedWeapon = this.weaponFactory.Create(WeaponType.Dagger);
        }

        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int HP { get; set; }
        public IWeapon EquippedWeapon { get; set; }
    }
}
