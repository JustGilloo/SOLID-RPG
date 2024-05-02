using SOLID_RPG.Dice;
using SOLID_RPG.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Enemies
{
    internal class EnemyShield : IEnemyStats, IDamageReductionChance
    {
        ILogger logger;
        IDiceRoller roller;

        public EnemyShield(ILogger logger, IDiceRoller roller, int hP, int minDamage, int maxDamage, int percentageDropChance, int damageReductionChance, string name)
        {
            this.logger = logger;
            this.roller = roller;
            HP = hP;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            PercentageDropChance = percentageDropChance;
            DamageReductionChance = damageReductionChance;
            Name = name;
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int PercentageDropChance { get; set; }
        public int DamageReductionChance { get; set; }
    }
}
