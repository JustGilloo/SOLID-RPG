using SOLID_RPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Equipment
{
    internal interface IDetermineWeaponType
    {
        int DetermineWeaponType(IWeapon weapon, IRace player);
    }
}
