namespace SOLID_RPG.Dice
{
    public interface IDiceRoller
    {
        int[] RollDiceArray(int amountOfDice, int amountOfSides);
        int RollEnemyDamageDie(int minDamage, int maxDamage);
        bool RollPercentageChance(int percentageTarget);
        int RollStatsDice(int amountOfDice, int amountOfSides);
    }
}