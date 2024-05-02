namespace SOLID_RPG.GameState
{
    public interface IGameState
    {
        bool IsGameOver { get; set; }

        void CombatLoop();
        void GameOver();
        void StartGame();
        void Victory();
    }
}