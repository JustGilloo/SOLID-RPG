using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.GameState
{
    internal interface IDetermineGameState
    {
        void StartGame();
        void GameOver();
        void CombatLoop();
        void Victory();
    }
}
