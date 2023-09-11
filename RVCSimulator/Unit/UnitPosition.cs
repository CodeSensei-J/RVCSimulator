using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVCSimulator.Unit;

internal class UnitPosition
{
    public static void PlaceUnitOnTable(char[,] table, int x, int y, char obj)
    {
        if (x >= 0 && x < table.GetLength(1) && y >= 0 && y < table.GetLength(0))
        {
            table[y, x] = obj;
        }

        else
        {
            Console.WriteLine("Roboten kan inte placeras utanför rummet.");
        }
    }
}
