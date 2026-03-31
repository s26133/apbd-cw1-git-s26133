using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramAfirmacja
{
    internal class StatisticsHelper
    {
        public static int CalculateMax(int[] values) => values.Max();

        public static int CalculateMin(int[] values)
        {
            return values.Min();
        }
    }
}
