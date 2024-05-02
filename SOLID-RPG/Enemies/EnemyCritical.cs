using SOLID_RPG.Dice;
using SOLID_RPG.Encounters;
using SOLID_RPG.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Enemies
{
    internal class EnemyCritical : IEnemyStats, ICriticalHitChance
    {
        IDiceRoller roller;
        ILogger logger;

        public EnemyCritical(ILogger logger, IDiceRoller roller, int hP, int minDamage, int maxDamage, int percentageDropChance, int criticalHitChance, string name)
        {
            this.roller = roller;
            this.logger = logger;
            HP = hP;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            PercentageDropChance = percentageDropChance;
            CriticalHitChance = criticalHitChance;
            Name = name;
        }

        public string Name { get; set; }
        public int HP { get; set; } 
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int PercentageDropChance { get; set; }
        public int CriticalHitChance { get; set; }
    }
}
