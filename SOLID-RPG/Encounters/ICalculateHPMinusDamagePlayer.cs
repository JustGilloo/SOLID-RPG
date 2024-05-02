using SOLID_RPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Encounters
{
    internal interface ICalculateHPMinusDamagePlayer
    {
        void CalculateHPMinusDamagePlayer(IRace hitPlayer, int damageAmount, bool criticalHit);
    }
}
