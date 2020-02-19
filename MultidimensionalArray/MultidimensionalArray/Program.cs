using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MultidimensionalArray
{
    class Program
    {
        private static int i;
        private static int j;

        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 2, 3, 6 }, { 5, 4, 7 } };
            int[,,] arr1 = new int[2, 2, 3] { { { 1, 2, 3 }, { 2, 4, 5 } }, { { 4, 5, 6 }, { 5, 6, 7 } } };
         
            for (int i = 0; i < 2; i++) ;
            {
                for (int j = 0; j < 3; j++) ;
                {
                    WriteLine("a[{0},{1}]={2}",i,j,arr[i,j]);
                    
                }
            }
            for(int k=0;k<2;k++)
            {
                for(int x=0;k<2;k++ )
                {
                    for(int y=0;y<3;y++)
                    {
                        WriteLine("a[{0},{1},{2}]={3}", k, x, y, arr1[k, x, y]);
                    }
                }
            }

        }

       
    }
}
