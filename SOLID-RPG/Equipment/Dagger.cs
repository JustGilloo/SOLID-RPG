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
    internal class Dagger : IWeapon
    {
        private ILogger logger;

        public Dagger(ILogger logger)
        {
            this.logger = logger;
            this.Name = "Dagger";
            this.Description = "A small and cheaply made pocketknife, useful in a pinch";
            this.Category = "Melee";
            this.DamageRating = 2;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int DamageRating { get; set; }
    }
}
