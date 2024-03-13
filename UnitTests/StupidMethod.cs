using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    internal class StupidMethod
    {
        public string ReturnsGhostIfZero(int num)
        {
            if (num == 0)
            {
                return "Ghost";
            }
            else
            {
                return "Price";
            }
        }
    }
}
