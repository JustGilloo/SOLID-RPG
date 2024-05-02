using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Equipment
{
    public interface IItem
    {
        string Name { get; set; }
        string Description { get; set; }
        string Category { get; set; }
    }
}
