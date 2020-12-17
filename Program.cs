using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            arr ={ { 1,2,3,4,5,6} };

            int result = hourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        static int hourglassSum(int[][] arr)
        {
            List<int> sum = new List<int>();

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    sum.Add(arr[i][j]
                        + arr[i][j+1]
                        + arr[i][j+2]
                        + arr[i+1][j+1]
                        + arr[i+2][j]
                        + arr[i+2][j+1]
                        + arr[i+2][j+2]);
                }
            }
            int result = sum.Max();
            return result;
        }
    }
}
