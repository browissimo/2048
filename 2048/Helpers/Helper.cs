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

        public static bool DoesArrayContainNull(int [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
