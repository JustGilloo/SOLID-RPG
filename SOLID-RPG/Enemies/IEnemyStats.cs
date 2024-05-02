using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Enemies
{
    public interface IEnemyStats : IPercentageDropChance
    {
        string Name { get; set; }
        int HP { get; set; }
        int MinDamage { get; set; }
        int MaxDamage { get; set; }

    }
}
