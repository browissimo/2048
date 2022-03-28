using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.Helpers
{
    public static class Helper
    {
        public static int GetMaxValFromArr(int[,] arr)
        {
            int maxVal = 0;

            foreach (var item in arr)
            {
                maxVal = maxVal < item ? item : maxVal;
            }

            return maxVal;
        }
    }
}
