using SOLID_RPG.Dice;
using SOLID_RPG.Enemies;
using SOLID_RPG.Equipment;
using SOLID_RPG.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Factories
{
    public class EnemyFactory : IEnemyFactory
    {
        private ILogger logger;
        private IDiceRoller roller;

        public EnemyFactory(ILogger logger, IDiceRoller roller)
        {
            this.logger = logger;
            this.roller = roller;
        }

        public IEnemyStats Create(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.DefaultEnemy:
                    return new EnemyDefault(logger, roller, 40, 1, 4, 50, "Goblin");
                case EnemyType.CriticalEnemy:
                    return new EnemyCritical(logger, roller, 30, 1, 4, 50, 25, "Thief");
                case EnemyType.ShieldEnemy:
                    return new EnemyShield(logger, roller, 50, 1, 4, 50, 25, "Ogre");
                default:
                    throw new ArgumentException();
            }
        }
    }
}
