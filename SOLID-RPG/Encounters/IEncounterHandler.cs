using SOLID_RPG.Dice;
using SOLID_RPG.Enemies;
using SOLID_RPG.Equipment;
using SOLID_RPG.Players;

namespace SOLID_RPG.Encounters
{
    public interface IEncounterHandler
    {
        void CalculateHPMinusDamageEnemy(IEnemyStats hitEnemy, int damageAmount);
        void CalculateHPMinusDamagePlayer(IRace hitPlayer, int damageAmount, bool criticalHit);
        int CalculatePlayerAttack(IRace player);
        int DetermineWeaponType(IWeapon weapon, IRace player);
        void ResolveEnemyAttack(IRace hitPlayer, IEnemyStats enemy, IDiceRoller roller);
        void ResolvePlayerAttack(IRace player, IEnemyStats enemy);
    }
}