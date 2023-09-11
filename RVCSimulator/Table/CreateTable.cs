using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVCSimulator.Table;

internal class CreateTable
{
    public static char[,] CreateNewTable(int x, int y)
    {
        char[,] table = new char[y, x];

        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                table[i, j] = '#';
            }
        }
        return table;
    }
}
