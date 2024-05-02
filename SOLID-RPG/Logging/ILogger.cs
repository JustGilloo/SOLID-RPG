using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Logging
{
    public interface ILogger
    {
        void WriteMessage(string message);
    }
}
