using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_RPG.Input
{
    internal class UserInput : IInputter
    {
        public string ReadInput()
        {
           return Console.ReadLine();
        }
    }
}
