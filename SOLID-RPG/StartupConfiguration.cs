using Microsoft.Extensions.DependencyInjection;
using SOLID_RPG.Dice;
using SOLID_RPG.Encounters;
using SOLID_RPG.Factories;
using SOLID_RPG.Factory;
using SOLID_RPG.GameState;
using SOLID_RPG.Input;
using SOLID_RPG.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG
{
    internal class StartupConfiguration
    {
        public ServiceCollection RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IDiceRoller, DiceRoller>();
            services.AddScoped<ILogger, CloudLogger>();
            services.AddScoped<IInputter, UserInput>();
            services.AddScoped<IWeaponFactory, WeaponFactory>();
            services.AddScoped<IEncounterHandler, EncounterHandler>();
            services.AddScoped<IRaceStatFactory, RaceStatFactory>();
            services.AddScoped<IEnemyFactory, EnemyFactory>();
            services.AddSingleton<IGameState, GameState.GameState>();
            return services;
        }
    }
}
