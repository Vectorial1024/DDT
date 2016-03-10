using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDT
{
    class Randomizer
    {
        public static string generateFileName()
        {
            Random random = new Random();
            string name = "";

            // We generate a file name of 24 characters long. That should be enough.
            for (int i=0; i<24; i++)
            {
                name += (char)random.Next(32, 128);
            }
            return name;
        }

        private static bool isCharValid(int C)
        {
            // 0 to 31 are meaningless, 32 is space, 127 is del
            if (C <= 32 || C >= 127)
            {
                return false;
            }
            // The slashes and the pipe
            if (C == 47 || C == 92 || C == 124)
            {
                return false;
            }
            // Shift+, and Shift+.
            if (C == 60 || C == 62)
            {
                return false;
            }
            // And ! ?
            if (C == 33 || C == 63)
            {
                return false;
            }
            // Finally * "
            if (C == 42 || C == 34)
            {
                return false;
            }

            // We should have filtered out anything not suitable.
            return true;
        }
    }
}
