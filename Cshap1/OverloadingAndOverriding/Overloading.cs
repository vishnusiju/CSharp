using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingAndOverriding
{
    public class Load
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
    }
}
