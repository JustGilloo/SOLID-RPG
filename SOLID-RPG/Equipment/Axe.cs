using SOLID_RPG.Dice;
using SOLID_RPG.Logging;
using SOLID_RPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Equipment
{
    internal class Axe : IWeapon
    {
        private ILogger logger;

        public Axe(ILogger logger)
        {
            this.logger = logger;
            this.Name = "Axe";
            this.Description = "A great two-handed axe, to be held and swung with pride";
            this.Category = "Melee";
            this.DamageRating = 4;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int DamageRating { get; set; }
    }
}
