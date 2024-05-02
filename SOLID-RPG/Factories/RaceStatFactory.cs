using SOLID_RPG.Dice;
using SOLID_RPG.Factories;
using SOLID_RPG.Input;
using SOLID_RPG.Logging;
using SOLID_RPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Factory
{
    public class RaceStatFactory : IRaceStatFactory
    {
        private IDiceRoller roller;
        private ILogger logger;
        private IInputter inputter;
        private IWeaponFactory weaponFactory;

        public RaceStatFactory(IDiceRoller roller, ILogger logger, IInputter inputter, IWeaponFactory weaponFactory)
        {
            this.roller = roller;
            this.logger = logger;
            this.inputter = inputter;
            this.weaponFactory = weaponFactory;
        }

        public IRace Create(RaceType raceType)
        {
            switch (raceType)
            {
                case RaceType.Human:
                    return new Human(logger, roller, inputter.ReadInput(), this.weaponFactory);
                case RaceType.Elf:
                    return new Elf(logger, roller, inputter.ReadInput(), this.weaponFactory);
                case RaceType.Dwarf:
                    return new Dwarf(logger, roller, inputter.ReadInput(), this.weaponFactory);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
