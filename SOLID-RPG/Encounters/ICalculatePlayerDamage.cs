using SOLID_RPG.Enemies;
using SOLID_RPG.Equipment;
using SOLID_RPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Encounters
{
    internal interface ICalculatePlayerDamage
    {
        int CalculatePlayerAttack(IRace player);
        void ResolvePlayerAttack(IRace player, IEnemyStats enemy);
    }
}
