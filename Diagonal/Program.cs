using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
                for (int a_i = 0; a_i < n; a_i++)
                {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);

                 }


            int downright = 0;
            int upright = 0;
            int diff = 0;

            //topleft corner
            

            //Console.WriteLine(a.GetLength(0));

            //row
            for (int r = 0; r < a.GetLength(0); r++)
            {

                if (r == 0)
                {
                    downright += a[0][0];
                }
                else if (r + 1 > a.GetLength(1))
                {
                    downright += a[r][a.GetLength(1) - 1];
                }
                else
                {
                    downright += a[r][r + 1];
                }

                
            }

            Console.WriteLine(downright);

            upright += a[0][a.GetLength(1) - 1];

            for (int c = a.GetLength(1); c < a.GetLength(1) - 1; c++)
            {
                upright += a[a.GetLength(1) - c][c];

            }

            diff = downright - upright;

            diff = Math.Abs(diff);

            Console.WriteLine(diff);

        }
    }
}
