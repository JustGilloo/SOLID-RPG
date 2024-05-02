using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Players
{
    public interface IStats
    {
        int Strength { get; set; }
        int Intelligence { get; set; }
        int HP { get; set; }
    }
}
