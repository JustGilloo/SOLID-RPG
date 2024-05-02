using SOLID_RPG.Dice;
using SOLID_RPG.Enemies;
using SOLID_RPG.Equipment;
using SOLID_RPG.Logging;
using SOLID_RPG.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Encounters
{
    public class EncounterHandler : ICalculateDamageEnemy, ICalculatePlayerDamage, ICalculateHPMinusDamagePlayer, ICalculateHPMinusDamageEnemy, IDetermineWeaponType, IEncounterHandler
    {
        private ILogger logger;

        public EncounterHandler(ILogger logger)
        {
            this.logger = logger;
        }

        public void ResolveEnemyAttack(IRace hitPlayer, IEnemyStats enemy, IDiceRoller roller)
        {
            bool criticalHit = false;
            if (enemy.GetType() == EnemyType.CriticalEnemy.GetType())
            {
                criticalHit = roller.RollPercentageChance(25);
            }
            int damage = roller.RollEnemyDamageDie(enemy.MinDamage, enemy.MaxDamage);
            this.logger.WriteMessage($"{enemy.Name} attacks {hitPlayer.Name} for {damage} damage!");
            CalculateHPMinusDamagePlayer(hitPlayer, damage, criticalHit);
            this.logger.WriteMessage($"{hitPlayer.Name} has {hitPlayer.HP} HP left!");
        }

        public void CalculateHPMinusDamagePlayer(IRace hitPlayer, int damageAmount, bool criticalHit)
        {
            if (criticalHit == true)
            {
                damageAmount = damageAmount * 2;
            }
            hitPlayer.HP -= damageAmount;
        }

        public void ResolvePlayerAttack(IRace player, IEnemyStats enemy)
        {
            this.logger.WriteMessage($"{player.Name} attacks {enemy.Name} for {CalculatePlayerAttack(player)} damage!");
        }
        public int CalculatePlayerAttack(IRace player)
        {
            return player.EquippedWeapon.DamageRating * DetermineWeaponType(player.EquippedWeapon, player);
        }
        public void CalculateHPMinusDamageEnemy(IEnemyStats hitEnemy, int damageAmount)
        {
            hitEnemy.HP -= damageAmount;
        }

        public int DetermineWeaponType(IWeapon weapon, IRace player)
        {
            switch (weapon.Category)
            {
                case "Melee":
                    return player.Strength;
                case "Ranged":
                    return player.Intelligence;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
