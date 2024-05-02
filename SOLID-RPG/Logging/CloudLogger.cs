using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Logging
{
    internal class CloudLogger : ILogger
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine($"Cloud: {message}");
        }
    }
}
