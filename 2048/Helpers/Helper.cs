using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public static bool DoesArrayHaveSameValuesNearby(int [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] == arr[i+1,j])
                    {
                        return true;

                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    if (arr[i, j] == arr[i, j + 1])
                    {
                        return true;

                    }
                }
            }

            return false;
        }

        public static int readHightScore()
        {
            using(StreamReader streamReader = new StreamReader("score.txt"))
            {
                int score = streamReader.Read();
                return score;
            }       
        }

        public static void writeHightScore(string score)
        {            
            StreamReader sr = new StreamReader("score.txt");
            if (Convert.ToInt32(sr.ReadLine()) < Convert.ToInt32(score))
            {
                sr.Close();
                using (StreamWriter sw = new StreamWriter("score.txt", false))
                    sw.WriteLine(score);
            }
        }
    }
}
