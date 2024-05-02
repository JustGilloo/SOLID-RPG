using SOLID_RPG.Dice;
using SOLID_RPG.Encounters;
using SOLID_RPG.Enemies;
using SOLID_RPG.Factories;
using SOLID_RPG.Factory;
using SOLID_RPG.Input;
using SOLID_RPG.Logging;
using SOLID_RPG.Players;
using System;

namespace SOLID_RPG.GameState
{
    public class GameState : IGameState
    {
        IRace playerCharacter;
        ILogger logger;
        IInputter inputter;
        RaceType raceType = new RaceType();
        IEnemyStats randomEnemy;
        IDiceRoller roller;
        IWeaponFactory weaponFactory;
        IRaceStatFactory raceFactory;
        IEnemyFactory enemyFactory;
        IEncounterHandler encounter;
        Random random = new Random();

        public GameState(IInputter inputter, IDiceRoller roller, IWeaponFactory weaponFactory, IRaceStatFactory raceFactory, IEnemyFactory enemyFactory, IEncounterHandler encounter, ILogger logger)
        {
            this.logger = logger;
            this.inputter = inputter;
            this.roller = roller;
            this.weaponFactory = weaponFactory;
            this.raceFactory = raceFactory;
            this.enemyFactory = enemyFactory;
            this.encounter = encounter;
        }

        public bool IsGameOver { get; set; } = false;

        public void StartGame()
        {
            logger.WriteMessage("What race would you like to play as?");
            logger.WriteMessage("1. Human");
            logger.WriteMessage("2. Elf");
            logger.WriteMessage("3. Dwarf");
            raceType = (RaceType)Convert.ToInt32(inputter.ReadInput());
            Console.Clear();
            logger.WriteMessage("What is your name?");
            playerCharacter = raceFactory.Create(raceType);
            Console.Clear();

            logger.WriteMessage($"Race: {playerCharacter.GetType().Name}");
            logger.WriteMessage($"Your name is: {playerCharacter.Name}");
            logger.WriteMessage($"Strength: {playerCharacter.Strength}");
            logger.WriteMessage($"Intelligence: {playerCharacter.Intelligence}");
            logger.WriteMessage($"HP: {playerCharacter.HP}");
            inputter.ReadInput();
            Console.Clear();
        }
        public void CombatLoop()
        {
            while (playerCharacter.HP > 0)
            {
                randomEnemy = enemyFactory.Create((EnemyType)random.Next(0, Enum.GetNames(typeof(EnemyType)).Length));
                logger.WriteMessage($"A {randomEnemy.Name} appeared!");
                logger.WriteMessage("Prepare to fight!");
                while (randomEnemy.HP > 0 && playerCharacter.HP > 0)
                {
                    encounter.ResolvePlayerAttack(playerCharacter, randomEnemy);
                    encounter.ResolveEnemyAttack(playerCharacter, randomEnemy, roller);
                }
                if (playerCharacter.HP > 0)
                {
                    Victory();
                }
            }
            GameOver();
        }
        public void GameOver()
        {
            logger.WriteMessage("Game over! You died!");
        }

        public void Victory()
        {
            logger.WriteMessage($"Victory!");
        }
    }
}
