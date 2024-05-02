namespace SOLID_RPG.Dice
{
    public class DiceRoller : IDiceRoller
    {
        public int[] RollDiceArray(int amountOfDice, int amountOfSides)
        {
            Random random = new Random();
            int[] rolls = new int[amountOfDice];
            for (int i = 0; i < amountOfDice; i++)
            {
                rolls[i] += random.Next(1, amountOfSides + 1);
            }
            return rolls;
        }
        public int RollStatsDice(int amountOfDice, int amountOfSides)
        {
            Random random = new Random();
            int statsTotal = 0;
            for (int i = 0; i < amountOfDice; i++)
            {
                statsTotal += random.Next(1, amountOfSides + 1);
            }
            return statsTotal;
        }
        public bool RollPercentageChance(int percentageTarget)
        {
            Random random = new Random();
            return random.Next(1, 101) <= percentageTarget;
        }
        public int RollEnemyDamageDie(int minDamage, int maxDamage)
        {
            Random random = new Random();
            return random.Next(minDamage, maxDamage + 1);
        }
    }
}
