using Microsoft.Extensions.DependencyInjection;
using SOLID_RPG;
using SOLID_RPG.GameState;


internal class Program
{
    private static void Main(string[] args)
    {
        ServiceCollection services = new ServiceCollection();
        StartupConfiguration startupConfiguration = new StartupConfiguration();
        services = startupConfiguration.RegisterServices();
        ServiceProvider serviceProvider = services.BuildServiceProvider();


        IGameState gameState = serviceProvider.GetService<IGameState>();

        gameState.StartGame();
        gameState.CombatLoop();
    }
}