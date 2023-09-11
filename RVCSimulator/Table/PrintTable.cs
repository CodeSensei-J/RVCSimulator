using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVCSimulator.Table;

internal class PrintTable
{
    public static void PrintNewTable(char[,] table)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                Console.Write(table[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
