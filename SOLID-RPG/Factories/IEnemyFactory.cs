using SOLID_RPG.Enemies;

namespace SOLID_RPG.Factories
{
    public interface IEnemyFactory
    {
        IEnemyStats Create(EnemyType enemyType);
    }
}