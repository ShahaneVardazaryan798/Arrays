using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] jarray1 = new int[2][,];

            jarray1[0] = new int[2, 2] { { 15, 24 }, { 43, 54 } };

            jarray1[1] = new int[,] { { 11, 12 }, { 13, 14 }, { 25, 26 } };

           

            for (int i = 0; i < jarray1.Length; i++)
            {
                Console.Write("Element[{0}]: ", i);

                for (int j = 0; j < jarray1[i].GetLength(0); j++)
                {
                    for (int k = 0; k <jarray1[i].GetLength(1); k++)
                    {

                        Console.Write("{0}{1}", jarray1[i][j, k]);

                    }
                }
            }      

                //inch vor mi ban ayn che

                

            

         
        }
    }
}
