using SOLID_RPG.Enemies;
using SOLID_RPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Encounters
{
    internal interface ICalculateHPMinusDamageEnemy
    {
        void CalculateHPMinusDamageEnemy(IEnemyStats hitEnemy, int damageAmount);
    }
}
