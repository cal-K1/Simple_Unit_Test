using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    public static class StupidMethodTest
    {
        public static void StupidMethod_RetunsGhostIfZero_ReturnString()
        {
            try
            {
                // Arrange - Go get the varibles, methods, classes etc.
                int num = 0;
                StupidMethod ghostMethod = new StupidMethod();

                // Act - Excecute the function.
                string result = ghostMethod.ReturnsGhostIfZero(num);

                // Assert - Whatever is returned by the test.
                if (result == "Ghost")
                {
                    Console.WriteLine("PASSED: StupidMethod.RetunsGhostIfZero.ReturnString");
                }
                else
                {
                    Console.WriteLine("FAILED: StupidMethod_RetunsGhostIfZero_ReturnString");
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
